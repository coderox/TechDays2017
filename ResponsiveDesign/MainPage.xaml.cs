using ResponsiveDesign.Views;
using System;
using System.Collections.Generic;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ResponsiveDesign
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void NavView_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            if (args.IsSettingsInvoked)
            {
                //ContentFrame.Navigate(typeof(SettingsPage));
            }
            else
            {
                NavigateToPage(args.InvokedItem.ToString());
            }
        }

        private void NavView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            if (args.IsSettingsSelected)
            {
                //ContentFrame.Navigate(typeof(SettingsPage));
            }
            else
            {
                NavigationViewItem item = args.SelectedItem as NavigationViewItem;
                NavigateToPage(item.Tag.ToString());
            }
        }

        private void NavigateToPage(string page)
        {
            switch (page)
            {
                case "reposition":
                    ContentFrame.Navigate(typeof(Reposition));
                    break;

                case "resize":
                    ContentFrame.Navigate(typeof(Resize));
                    break;

                case "reflow":
                    ContentFrame.Navigate(typeof(Reflow));
                    break;

                case "replace":
                    ContentFrame.Navigate(typeof(Replace));
                    break;

                case "reveal":
                    ContentFrame.Navigate(typeof(Reveal));
                    break;

                case "rearchitecture":
                    ContentFrame.Navigate(typeof(Rearchitecture));
                    break;
            }
        }
    }
}
