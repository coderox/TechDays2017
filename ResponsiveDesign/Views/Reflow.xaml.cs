using ResponsiveDesign.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ResponsiveDesign.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Reflow : Page
    {
        ItemsViewModel ViewModel { get { return this.DataContext as ItemsViewModel; } }

        public Reflow()
        {
            this.InitializeComponent();

            this.DataContext = new ItemsViewModel();

            Loaded += async delegate {

                //if (ActualWidth < 641)
                //{
                //    VisualStateManager.GoToState(this, "small", false);
                //}
                //else if (ActualWidth < 1008)
                //{
                //    VisualStateManager.GoToState(this, "medium", false);
                //}
                //else
                //{
                //    VisualStateManager.GoToState(this, "large", false);
                //}

                //ResizeItem(ActualWidth);

                await ViewModel.LoadAsync();
            };
        }

        //private void OnSizeChanged(object sender, SizeChangedEventArgs e)
        //{
        //    ResizeItem(e.NewSize.Width);
        //}

        //private void ResizeItem(double originalWidth)
        //{
        //    //var width = originalWidth - ((ViewModel.MaximumRowsOrColumns) * 10) - gridView.Padding.Right;
        //    ViewModel.ItemWidth = Math.Floor(originalWidth / ViewModel.MaximumRowsOrColumns);
        //    Debug.WriteLine($"OriginalWidth = {originalWidth} Width = {originalWidth} Columns = {ViewModel.MaximumRowsOrColumns} ItemWidth = {ViewModel.ItemWidth}");
        //}

        private void OnGridViewSizeChanged(object sender, SizeChangedEventArgs e)
        {
            var columns = Math.Ceiling(ActualWidth / 300);
            ((VariableSizedWrapGrid)gridView.ItemsPanelRoot).ItemWidth = e.NewSize.Width / columns;
        }
    }
}
