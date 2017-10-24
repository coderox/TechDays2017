using ResponsiveDesign.Views;
using Windows.UI.Xaml.Controls;

namespace ResponsiveDesign
{
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
                case "home":
                    ContentFrame.Navigate(typeof(Rearchitect));
                    break;

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

                case "rearchitect":
                    ContentFrame.Navigate(typeof(Rearchitect));
                    break;
            }
        }
    }
}
