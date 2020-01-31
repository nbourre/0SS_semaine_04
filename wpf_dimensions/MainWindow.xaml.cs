using System;
using System.Collections.Generic;
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

namespace wpf_dimensions
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LayoutUpdated += MainWindow_LayoutUpdated;
            chkVisibilite.Checked += ChkVisibilite_Checked;
            chkVisibilite.Unchecked += ChkVisibilite_Unchecked;
            chkVisibilite.Indeterminate += ChkVisibilite_Indeterminate;
        }

        private void ChkVisibilite_Indeterminate(object sender, RoutedEventArgs e)
        {
            btn20.Visibility = Visibility.Collapsed;
            Visibilite22.Text = $"État : Plié";
        }

        private void ChkVisibilite_Unchecked(object sender, RoutedEventArgs e)
        {
            btn20.Visibility = Visibility.Visible;
            Visibilite22.Text = $"État : Visible";
        }

        private void ChkVisibilite_Checked(object sender, RoutedEventArgs e)
        {
            btn20.Visibility = Visibility.Hidden;
            Visibilite22.Text = $"État : Caché";
        }

        private void MainWindow_LayoutUpdated(object sender, EventArgs e)
        {
            Size00.Text = $"Largeur par défaut : {btn00.Width}\nLargeur actuelle : {btn00.ActualWidth}";
            Size11.Text = $"Largeur par défaut : {btn10.Width}\nLargeur actuelle : {btn10.ActualWidth}";
            Size12.Text = $"Largeur par défaut : {btn20.Width}\nLargeur actuelle : {btn20.ActualWidth}";
        }
    }
}
