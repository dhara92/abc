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

namespace Bill_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        decimal amount;
        decimal tip;
        decimal tax;
        decimal total;
        decimal change;

        public MainWindow()
        {
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(txtAmount.Text != null )
            {
                try
                {
                    amount = Decimal.Parse(txtAmount.Text);
                    if(amount > 0)
                    {
                        tip = amount * .15m;
                        tax = amount * .07m;

                        total = amount + tip + tax;

                        lblAmount.Content = amount.ToString("C");
                        lblTip.Content = tip.ToString("C");
                        lblTax.Content = tax.ToString("C");
                        lblTotal.Content = total.ToString("C");
                        btnChange.IsEnabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Please enter valid amount!", "Attention", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }

                }
                catch
                {
                    MessageBox.Show("Please enter valid amount!", "Attention", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
               
            }
            else
            {
                MessageBox.Show("Please enter valid amount!", "Attention", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
           
        }

        private void BtnChange_Click_1(object sender, RoutedEventArgs e)
        {
            
            if (txtCash.Text != null)
            {
                try
                {
                    change = decimal.Parse(txtCash.Text) - total;
                    MessageBox.Show("The change is " + change.ToString("0.00"),"Information",MessageBoxButton.OK,MessageBoxImage.Information);
                }
                catch
                {
                     MessageBox.Show("Please enter valid amount!", "Attention", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            else
            {
                 MessageBox.Show("Please enter valid amount!", "Attention", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
