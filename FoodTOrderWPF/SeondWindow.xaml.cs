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
using System.Windows.Shapes;

namespace FoodTOrderWPF
{
    /// <summary>
    /// Interaction logic for SeondWindow.xaml
    /// </summary>
    public partial class SeondWindow : Window
    {
        public SeondWindow()
        {
            InitializeComponent();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBoxItem li = (ListBoxItem)lstUsers.SelectedValue;
            string str = "";
            if (li.Content is StackPanel) {
                StackPanel sp = (StackPanel)li.Content;
                Label l = (Label)sp.Children[0];
                Button button = (Button)sp.Children[1];
                str += l.Content.ToString();
            }
            MessageBox.Show(str);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
