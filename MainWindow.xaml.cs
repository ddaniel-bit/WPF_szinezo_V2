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

namespace szinozom
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
        private void sliRGB_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            rctTeglalap.Fill = new SolidColorBrush(Color.FromRgb(Convert.ToByte(sliPiros.Value), Convert.ToByte(sliZold.Value), Convert.ToByte(sliKek.Value)));
            lbPirosSzam.Content = Convert.ToByte(sliPiros.Value);
            lbZoldSzam.Content = Convert.ToByte(sliZold.Value);
            lbKekSzam.Content = Convert.ToByte(sliKek.Value);
        }

        private void btnRogzit_Click(object sender, RoutedEventArgs e)
        {
            if (lbSzinek.Items.Contains(Convert.ToByte(sliPiros.Value) + "," + Convert.ToByte(sliZold.Value) + "," + Convert.ToByte(sliKek.Value)))
            {

            }
            else
            {
                lbSzinek.Items.Add(Convert.ToByte(sliPiros.Value) + "," + Convert.ToByte(sliZold.Value) + "," + Convert.ToByte(sliKek.Value));
            }
        }

        private void btnTorol_Click(object sender, RoutedEventArgs e)
        {
            if (lbSzinek.SelectedIndex == -1)
            {
                MessageBox.Show("Nincs kivalasztva");
            }
            else
            {
                lbSzinek.Items.RemoveAt(lbSzinek.SelectedIndex);
            }
        }

        private void btnUrit_Click(object sender, RoutedEventArgs e)
        {
            lbSzinek.Items.Clear();
        }

        private void lbSzinek_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            string[] rgb = lbSzinek.SelectedItem.ToString().Split(",");
            sliPiros.Value = Convert.ToDouble(rgb[0]);
            sliZold.Value = Convert.ToDouble(rgb[1]);
            sliKek.Value = Convert.ToDouble(rgb[2]);
        }
    }
}
