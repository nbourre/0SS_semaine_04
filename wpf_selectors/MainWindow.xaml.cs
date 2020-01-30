using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace wpf_selectors
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Dates_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            IList items = e.AddedItems;
            int index = Dates.SelectedIndex;
            object selectedItem = Dates.SelectedItem;
            object selectedValue = Dates.SelectedValue;

            Debug.WriteLine($"AddedItems[0]: {(DateTime)items[0]}");
            Debug.WriteLine($"SelectedIndex: {index}");
            Debug.WriteLine($"SelectedItem: {(DateTime)selectedItem}");
            Debug.WriteLine($"SelectedValue: {(DayOfWeek)selectedValue}");
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
