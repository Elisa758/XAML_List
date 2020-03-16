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

namespace XAML_WPF_Quest2
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

        private void AddInfectedButton_Click(object sender, RoutedEventArgs e)
        {
            string nameAndBehavior = String.Format("{0} | {1} ", nameOfInfected.Text, Behavior.Text);
            if (nameOfInfected.Text == String.Empty || listInfected.Items.Contains(nameAndBehavior))
            {
                MessageBox.Show("Something went wrong ! ");
            }
            else
            {
                listInfected.Items.Add(nameAndBehavior);
        
            }
        }
    }
}
