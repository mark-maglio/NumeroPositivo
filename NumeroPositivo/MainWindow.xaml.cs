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

namespace NumeroPositivo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Genera_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int numero = int.Parse(txtNumeri.Text);
                if (numero < 0)
                {
                    throw new Exception("il numero deve essere maggiore di 0");
                }
                else
                {
                    int[] array = new int[numero];
                    for (int i = 0; i < array.Length; i++)
                    {
                        array[i] = random.Next(1, 10);
                    }
                    lblArray.Content = "[";
                    for (int i = 0; i < array.Length; i++)
                    {
                        lblArray.Content = lblArray.Content + $"{array[i]}";
                        if (i < array.Length - 1)
                            lblArray.Content += ",";
                    }
                    lblArray.Content += "]";
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtNumeri.Text = "";
            }
        }
    }
}