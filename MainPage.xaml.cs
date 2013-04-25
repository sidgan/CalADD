using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace calADD
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            
             
        }

         
        private void mul_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                float num1 = float.Parse(number1.Text);
                float num2 = float.Parse(number2.Text);
                //exception handling
                float result = num1 * num2;

                answer.Text = result.ToString();
                PageTitle.Text = "CalC";
            }
            catch (ArithmeticException)
            {

                MessageBox.Show("You typed an invalid number.The number may be tending to positive or negative infinity.");
                answer.Text ="Check the data"; 
                PageTitle.Text = "ERROR!!";
            }
            catch (FormatException)
            {
                MessageBox.Show("You typed an invalid number. Check the format of the number entered.");
                answer.Text = "Check format of data"; 
                PageTitle.Text = "ERROR!!";
            }

            catch (Exception)
            {
                MessageBox.Show("Error Occoured while performing operation.");
                answer.Text = "Operation not possible";
                PageTitle.Text = "ERROR!!";
            }

            ApplicationTitle.Text = "Multiplying Numbers..";


             
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                float num1 = float.Parse(number1.Text);
                float num2 = float.Parse(number2.Text);
                float result = num1 + num2;
                answer.Text = result.ToString();
                PageTitle.Text = "CalC";
            }

            catch (FormatException)
            {
                MessageBox.Show("You typed an invalid number.Check the format of the number entered. ");
                PageTitle.Text = "ERROR!!";
                answer.Text = "Check format ";
            }
            catch (Exception)
            {
                answer.Text = "Operation not possible";
                MessageBox.Show("You typed an invalid number.The number may be tending to positive or negative infinity.");
                PageTitle.Text = "ERROR!!";
                
            }
             

            ApplicationTitle.Text = "Adding Numbers..";
        }

        private void div_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                float num1 = float.Parse(number1.Text);
                float num2 = float.Parse(number2.Text);
                if (num2 == 0)
                {
                    answer.Text = "Division By zero not allowed";
                    PageTitle.Text = "ERROR!! ";
                   MessageBox.Show(" Division By zero not allowed.");
                }
                else
                {
                    float result = num1 / num2;
                    answer.Text = result.ToString();
                    PageTitle.Text = "CalC";
                }
                 
                
            }
            catch (FormatException)
            {
                MessageBox.Show("You typed an invalid number.Check the format of numbr entered.");
                PageTitle.Text = "ERROR!! ";
                answer.Text = "Check format.";
            }
            catch (DivideByZeroException)
            {
                 answer.Text = "Division By zero not allowed."; 
                PageTitle.Text = "ERROR!! ";
                MessageBox.Show("Division by zero is not allowed.");
             
            }
            catch (Exception )
            {
                answer.Text = "Operation not possible.";
                PageTitle.Text = "ERROR!!";
                MessageBox.Show("You typed an invalid number.The number may be tending to positive or negative infinity.");
            }

            ApplicationTitle.Text = "Dividing Numbers..";


        }

        private void sub_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                float num1 = float.Parse(number1.Text);
                float num2 = float.Parse(number2.Text);
                float result = num1 - num2;
                answer.Text = result.ToString();
                PageTitle.Text = "CalC";
            }
            catch (FormatException)
            {
                MessageBox.Show("You typed an invalid number.Check format of number entered.");
                PageTitle.Text = "ERROR!!";
                answer.Text = "Check format.";

            }
            catch (Exception)
                {
                    MessageBox.Show("You typed an invalid number.The number may be tending to positive or negative infinity.");   
                answer.Text = "Operation not possible." ;
                PageTitle.Text = "ERROR!!";
                }

            ApplicationTitle.Text = "Subtracting Numbers..";
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            answer.Text = " ";
            number1.Text = " ";
            number2.Text = " ";
            ApplicationTitle.Text = " ";
            PageTitle.Text = "CalC";

        }

       
        private void buttonINFO_Click(object sender, RoutedEventArgs e)
        {
            //when button clicks the canvas should dissappear
            //userINFO.Opacity = 0;
            //textBxINFO.Opacity = 0;
            //buttonINFO.Opacity = 0;
            number1.Focus();
            
        }
        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
           number1.Focus();
           
        }

       

    }
}
