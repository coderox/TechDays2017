using ResponsiveDesign.ViewModels;
using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace ResponsiveDesign.Views
{
    public sealed partial class Reflow : Page
    {
        ItemsViewModel ViewModel { get { return this.DataContext as ItemsViewModel; } }

        public Reflow()
        {
            this.InitializeComponent();

            this.DataContext = new ItemsViewModel();

            Loaded += async delegate {

                await ViewModel.LoadAsync();
            };
        }

        private void OnGridViewSizeChanged(object sender, SizeChangedEventArgs e)
        {
            var columns = Math.Ceiling(ActualWidth / 400);
            ((VariableSizedWrapGrid)gridView.ItemsPanelRoot).ItemWidth = e.NewSize.Width / columns;
        }
    }
}
