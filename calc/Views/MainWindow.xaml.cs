
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

namespace calc
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        float a, b;
        int count;
        bool znak = true;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            txtBox.Text = txtBox.Text + 1;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            txtBox.Text = txtBox.Text + 2;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            txtBox.Text = txtBox.Text + 3;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            txtBox.Text = txtBox.Text + 4;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            txtBox.Text = txtBox.Text + 5;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            txtBox.Text = txtBox.Text + 6;
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            txtBox.Text = txtBox.Text + 7;
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            txtBox.Text = txtBox.Text + 8;
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            txtBox.Text = txtBox.Text + 9;
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            txtBox.Text = txtBox.Text + 0;
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            txtBox.Text = txtBox.Text + ",";
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        
            {
                a = float.Parse(txtBox.Text);
                txtBox.Clear();
              
            lbl.Content = a.ToString() + "+";
                znak = true;
            }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {


            a = float.Parse(txtBox.Text);
            txtBox.Clear();
            count = 2;
            lbl.Content = a.ToString() + "-";
            znak = true;
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            a = float.Parse(txtBox.Text);
            txtBox.Clear();
            count = 3;
            lbl.Content = a.ToString() + "*";
            znak = true;
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {

                calculate();
                lbl.Content = "";
           
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            a = float.Parse(txtBox.Text);
            txtBox.Clear();
            count = 4;
            lbl.Content = a.ToString() + "/";
            znak = true;
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {

                 txtBox.Text = "";
                 lbl.Content = "";
         }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {


         
            
                int lenght = txtBox.Text.Length - 1;
                string text = txtBox.Text;
                 txtBox.Clear();
                for (int i = 0; i < lenght; i++)
                {
                txtBox.Text = txtBox.Text + text[i];
                }
            
        }

        private void Button_Click_18(object sender, RoutedEventArgs e)
        {

            if (znak == true)
            {
                txtBox.Text = "-" + txtBox.Text;
                znak = false;
            }
            else if (znak == false)
            {
                txtBox.Text = txtBox.Text.Replace("-", "");
                znak = true;
            }

        }
        private void calculate()
        {
            switch (count)
            {
                case 1:
                    b = a + float.Parse(txtBox.Text);
                    txtBox.Text = b.ToString();
                    break;
                case 2:
                    b = a - float.Parse(txtBox.Text);
                    txtBox.Text = b.ToString();
                    break;
                case 3:
                    b = a * float.Parse(txtBox.Text);
                    txtBox.Text = b.ToString();
                    break;
                case 4:
                    b = a / float.Parse(txtBox.Text);
                    txtBox.Text = b.ToString();
                    break;

                default:
                    break;
            }

        }

    }
}
