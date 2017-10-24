using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Media;
using ResponsiveDesign.Models;

namespace ResponsiveDesign.ViewModels
{
    class ItemsViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<SimpleItem> Items { get; private set; }

        private double itemWidth = 200;
        public double ItemWidth
        {
            get { return itemWidth; }
            set
            {
                itemWidth = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ItemWidth"));
            }
        }

        private int maximumRowsOrColumns = 1;
        public int MaximumRowsOrColumns
        {
            get { return maximumRowsOrColumns; }
            set
            {
                maximumRowsOrColumns = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("MaximumRowsOrColumns"));
            }
        }

        private int columnSpan = 1;
        public int ColumnSpan
        {
            get { return columnSpan; }
            set
            {
                columnSpan = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ColumnSpan"));
            }
        }

        public ItemsViewModel()
        {
            Items = new ObservableCollection<SimpleItem>();
        }

        public async Task LoadAsync()
        {
            await Task.Delay(1);

            Items.Clear();

            Items.Add(new SimpleItem { Brush = new SolidColorBrush(Colors.Red), Width = SimpleItem.ItemWidth.Double });
            Items.Add(new SimpleItem { Brush = new SolidColorBrush(Colors.Green) });
            Items.Add(new SimpleItem { Brush = new SolidColorBrush(Colors.Gray) });
            Items.Add(new SimpleItem { Brush = new SolidColorBrush(Colors.Blue) });
            Items.Add(new SimpleItem { Brush = new SolidColorBrush(Colors.Yellow) });
            Items.Add(new SimpleItem { Brush = new SolidColorBrush(Colors.Pink), Width = SimpleItem.ItemWidth.Double });
            Items.Add(new SimpleItem { Brush = new SolidColorBrush(Colors.Purple) });
            Items.Add(new SimpleItem { Brush = new SolidColorBrush(Colors.CornflowerBlue) });
            Items.Add(new SimpleItem { Brush = new SolidColorBrush(Colors.Orange) });
            Items.Add(new SimpleItem { Brush = new SolidColorBrush(Colors.DarkOliveGreen) });
            Items.Add(new SimpleItem { Brush = new SolidColorBrush(Colors.Red), Width = SimpleItem.ItemWidth.Double });
            Items.Add(new SimpleItem { Brush = new SolidColorBrush(Colors.Green) });
            Items.Add(new SimpleItem { Brush = new SolidColorBrush(Colors.Gray) });
            Items.Add(new SimpleItem { Brush = new SolidColorBrush(Colors.Blue) });
            Items.Add(new SimpleItem { Brush = new SolidColorBrush(Colors.Yellow) });
            Items.Add(new SimpleItem { Brush = new SolidColorBrush(Colors.Pink), Width = SimpleItem.ItemWidth.Double });
            Items.Add(new SimpleItem { Brush = new SolidColorBrush(Colors.Purple) });
            Items.Add(new SimpleItem { Brush = new SolidColorBrush(Colors.CornflowerBlue) });
            Items.Add(new SimpleItem { Brush = new SolidColorBrush(Colors.Orange) });
            Items.Add(new SimpleItem { Brush = new SolidColorBrush(Colors.DarkOliveGreen) });
            Items.Add(new SimpleItem { Brush = new SolidColorBrush(Colors.Red), Width = SimpleItem.ItemWidth.Double });
            Items.Add(new SimpleItem { Brush = new SolidColorBrush(Colors.Green) });
            Items.Add(new SimpleItem { Brush = new SolidColorBrush(Colors.Gray) });
            Items.Add(new SimpleItem { Brush = new SolidColorBrush(Colors.Blue) });
            Items.Add(new SimpleItem { Brush = new SolidColorBrush(Colors.Yellow) });
            Items.Add(new SimpleItem { Brush = new SolidColorBrush(Colors.Pink), Width = SimpleItem.ItemWidth.Double });
            Items.Add(new SimpleItem { Brush = new SolidColorBrush(Colors.Purple) });
            Items.Add(new SimpleItem { Brush = new SolidColorBrush(Colors.CornflowerBlue) });
            Items.Add(new SimpleItem { Brush = new SolidColorBrush(Colors.Orange) });
            Items.Add(new SimpleItem { Brush = new SolidColorBrush(Colors.DarkOliveGreen) });
            Items.Add(new SimpleItem { Brush = new SolidColorBrush(Colors.Red), Width = SimpleItem.ItemWidth.Double });
            Items.Add(new SimpleItem { Brush = new SolidColorBrush(Colors.Green) });
            Items.Add(new SimpleItem { Brush = new SolidColorBrush(Colors.Gray) });
            Items.Add(new SimpleItem { Brush = new SolidColorBrush(Colors.Blue) });
            Items.Add(new SimpleItem { Brush = new SolidColorBrush(Colors.Yellow) });
            Items.Add(new SimpleItem { Brush = new SolidColorBrush(Colors.Pink), Width = SimpleItem.ItemWidth.Double });
            Items.Add(new SimpleItem { Brush = new SolidColorBrush(Colors.Purple) });
            Items.Add(new SimpleItem { Brush = new SolidColorBrush(Colors.CornflowerBlue) });
            Items.Add(new SimpleItem { Brush = new SolidColorBrush(Colors.Orange) });
            Items.Add(new SimpleItem { Brush = new SolidColorBrush(Colors.DarkOliveGreen) });
            Items.Add(new SimpleItem { Brush = new SolidColorBrush(Colors.Red), Width = SimpleItem.ItemWidth.Double });
            Items.Add(new SimpleItem { Brush = new SolidColorBrush(Colors.Green) });
            Items.Add(new SimpleItem { Brush = new SolidColorBrush(Colors.Gray) });
            Items.Add(new SimpleItem { Brush = new SolidColorBrush(Colors.Blue) });
            Items.Add(new SimpleItem { Brush = new SolidColorBrush(Colors.Yellow) });
            Items.Add(new SimpleItem { Brush = new SolidColorBrush(Colors.Pink), Width = SimpleItem.ItemWidth.Double });
            Items.Add(new SimpleItem { Brush = new SolidColorBrush(Colors.Purple) });
            Items.Add(new SimpleItem { Brush = new SolidColorBrush(Colors.CornflowerBlue) });
            Items.Add(new SimpleItem { Brush = new SolidColorBrush(Colors.Orange) });
            Items.Add(new SimpleItem { Brush = new SolidColorBrush(Colors.DarkOliveGreen) });
            Items.Add(new SimpleItem { Brush = new SolidColorBrush(Colors.Red), Width = SimpleItem.ItemWidth.Double });
            Items.Add(new SimpleItem { Brush = new SolidColorBrush(Colors.Green) });
            Items.Add(new SimpleItem { Brush = new SolidColorBrush(Colors.Gray) });
            Items.Add(new SimpleItem { Brush = new SolidColorBrush(Colors.Blue) });
            Items.Add(new SimpleItem { Brush = new SolidColorBrush(Colors.Yellow) });
            Items.Add(new SimpleItem { Brush = new SolidColorBrush(Colors.Pink), Width = SimpleItem.ItemWidth.Double });
            Items.Add(new SimpleItem { Brush = new SolidColorBrush(Colors.Purple) });
            Items.Add(new SimpleItem { Brush = new SolidColorBrush(Colors.CornflowerBlue) });
            Items.Add(new SimpleItem { Brush = new SolidColorBrush(Colors.Orange) });
            Items.Add(new SimpleItem { Brush = new SolidColorBrush(Colors.DarkOliveGreen) });
            Items.Add(new SimpleItem { Brush = new SolidColorBrush(Colors.Red), Width = SimpleItem.ItemWidth.Double });
            Items.Add(new SimpleItem { Brush = new SolidColorBrush(Colors.Green) });
            Items.Add(new SimpleItem { Brush = new SolidColorBrush(Colors.Gray) });
            Items.Add(new SimpleItem { Brush = new SolidColorBrush(Colors.Blue) });
            Items.Add(new SimpleItem { Brush = new SolidColorBrush(Colors.Yellow) });
            Items.Add(new SimpleItem { Brush = new SolidColorBrush(Colors.Pink), Width = SimpleItem.ItemWidth.Double });
            Items.Add(new SimpleItem { Brush = new SolidColorBrush(Colors.Purple) });
            Items.Add(new SimpleItem { Brush = new SolidColorBrush(Colors.CornflowerBlue) });
            Items.Add(new SimpleItem { Brush = new SolidColorBrush(Colors.Orange) });
            Items.Add(new SimpleItem { Brush = new SolidColorBrush(Colors.DarkOliveGreen) });
        }
    }

}
