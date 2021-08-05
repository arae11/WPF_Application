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
using Calculator_Model;

namespace WPF_Application
{
    /// <summary>
    /// Interaction logic for CalculatorWindow.xaml
    /// </summary>
    public partial class CalculatorWindow : Window
    {
        private Calculator _calculator;
        private string _number;
        private string _operator;
        public CalculatorWindow()
        {
            InitializeComponent();
            _calculator = new Calculator();
        }

        private void tbxNum1_TextChanged(object sender, TextChangedEventArgs e)
        {
            var success = double.TryParse(tbxNum1.Text, out double num1);
            if (success)
            {
                _calculator.Num1 = num1;
            }
            else
            {
                lblresult.Content = "Invalid input";
            }
        }

        private void tbxNum2_TextChanged(object sender, TextChangedEventArgs e)
        {
            var success = double.TryParse(tbxNum2.Text, out double num2);
            if (success)
            {
                _calculator.Num2 = num2;
            }
            else
            {
                lblresult.Content = "Invalid input";
            }
        }

        // Operators
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            tbxOperator.Text = "+";
            _operator = "+";
        }
        private void btnSubtract_Click(object sender, RoutedEventArgs e)
        {
            tbxOperator.Text = "-";
            _operator = "-";
        }
        private void btnTimes_Click(object sender, RoutedEventArgs e)
        {
            tbxOperator.Text = "X";
            _operator = "X";
        }
        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            tbxOperator.Text = "/";
            _operator = "/";
        }
        private void btnEquals_Click(object sender, RoutedEventArgs e)
        {
            var firstValue = double.TryParse(tbxNum1.Text, out double num1);
            var secondValue = double.TryParse(tbxNum2.Text, out double num2);
            try
            {
                if (firstValue)
                {
                    _calculator.Num1 = num1;
                    if (secondValue)
                    {
                        _calculator.Num2 = num2;
                        switch (_operator)
                        {
                            case "+":
                                lblresult.Content = _calculator.Add();
                                break;
                            case "-":
                                lblresult.Content = _calculator.Subtract();
                                break;
                            case "X":
                                lblresult.Content = _calculator.Multiply();
                                break;
                            case "/":
                                lblresult.Content = _calculator.Divide();
                                break;
                        }
                    }
                    else
                    {
                        lblresult.Content = "Invalid input!";
                    }
                }
                else
                {
                    lblresult.Content = "Invalid input!";
                }
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        // Numpad
        private void btnOne_Click(object sender, RoutedEventArgs e)
        {
            _number = "1";
            if (tbxOperator.Text == "")
            {
                tbxNum1.Text += "1";
            }
            else
            {
                tbxNum2.Text += "1";
            }
        }
        private void btnTwo_Click(object sender, RoutedEventArgs e)
        {
            _number = "2";
            if (tbxOperator.Text == "")
            {
                tbxNum1.Text += "2";
            }
            else
            {
                tbxNum2.Text += "2";
            }
        }
        private void btnThree_Click(object sender, RoutedEventArgs e)
        {
            _number = "3";
            if (tbxOperator.Text == "")
            {
                tbxNum1.Text += "3";
            }
            else
            {
                tbxNum2.Text += "3";
            }
        }
        private void btnFour_Click(object sender, RoutedEventArgs e)
        {
            _number = "4";
            if (tbxOperator.Text == "")
            {
                tbxNum1.Text += "4";
            }
            else
            {
                tbxNum2.Text += "4";
            }
        }
        private void btnFive_Click(object sender, RoutedEventArgs e)
        {
            _number = "5";
            if (tbxOperator.Text == "")
            {
                tbxNum1.Text += "5";
            }
            else
            {
                tbxNum2.Text += "5";
            }
        }
        private void btnSix_Click(object sender, RoutedEventArgs e)
        {
            _number = "6";
            if (tbxOperator.Text == "")
            {
                tbxNum1.Text += "6";
            }
            else
            {
                tbxNum2.Text += "6";
            }
        }
        private void btnSeven_Click(object sender, RoutedEventArgs e)
        {
            _number = "7";
            if (tbxOperator.Text == "")
            {
                tbxNum1.Text += "7";
            }
            else
            {
                tbxNum2.Text += "7";
            }
        }
        private void btnEight_Click(object sender, RoutedEventArgs e)
        {
            _number = "8";
            if (tbxOperator.Text == "")
            {
                tbxNum1.Text += "8";
            }
            else
            {
                tbxNum2.Text += "8";
            }
        }
        private void btnNine_Click(object sender, RoutedEventArgs e)
        {
            _number = "9";
            if (tbxOperator.Text == "")
            {
                tbxNum1.Text += "9";
            }
            else
            {
                tbxNum2.Text += "9";
            }
        }
        private void btnZero_Click(object sender, RoutedEventArgs e)
        {
            _number = "0";
            if (tbxOperator.Text == "")
            {
                tbxNum1.Text += "0";
            }
            else
            {
                tbxNum2.Text += "0";
            }
        }
        private void btnDecimal_Click(object sender, RoutedEventArgs e)
        {
            _number = ".";
            if (tbxOperator.Text == "")
            {
                tbxNum1.Text += ".";
            }
            else
            {
                tbxNum2.Text += ".";
            }
        }
        // Extras
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (tbxOperator.Text == "")
            {
                tbxNum1.Text.Remove(tbxNum1.Text.Length - 1, 1);
            }
            else
            {
                tbxNum2.Text.Remove(tbxNum1.Text.Length - 1, 1);
            }
        }
        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            tbxNum1.Text = "";
            tbxNum2.Text = "";
            tbxOperator.Text = "";
        }

    }
}
