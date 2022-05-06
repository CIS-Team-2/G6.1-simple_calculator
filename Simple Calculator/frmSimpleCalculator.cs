using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/***************************************************************************************************
* CIS 123: Introduction to OOP     |    Exercise 6-1 Create a simple calculator                    *
* Murach's C#, 7th Edition         |    Code a private method named Calculate() that performs      *
* Chapter 6 Extra Exercises        |    the requested operation and returns a decimal value.       *
* Team 2 Assignment, 04MAY2022     |    This method should accept the following arguments:         *
* Patrick McKee & Dominique Tepper |         decimal operand1, string operator1, decimal operand2  *                    
***************************************************************************************************/


namespace Simple_Calculator
{
    public partial class frmSimpleCalculator : Form
    {
        public frmSimpleCalculator()
        {
            InitializeComponent();
        }

        /* *****************************************************************************************
         * 3. Code a private method name Calculate() that performs the requested      |            *
         *    operation and returns a decimal value. This method should accept the    |            *
         *    following arguments:                                                    |            *
         *                                                                            |   McKee    *
         *      A. decimal operand1         txtFirst.Text                             |   &        *
         *      B. string operator1         txtOperator.Text                          |   Tepper   *
         *      C. decimal operand2         txtSecond.Text                            |            *
         * ****************************************************************************************/
 
        // declare data types and default values for numeric input
        decimal operand1 = 0m;
        decimal operand2 = 0m;

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal operand1 = Convert.ToDecimal(txtFirst.Text);
            decimal operand2 = Convert.ToDecimal(txtSecond.Text);
            string operator1 = txtOperator.Text;

            // declares result data type and default value
            // 4A. declaration statement that calls the Calculate() method
            decimal result = Calculate(operand1, operator1, operand2);

            txtResult.Text = result.ToString();
            txtFirst.Focus(); // 4C. Move focus to Operand1 text box

        }

        /* ****************************************************************************************
        * 4. Create an event handler for the Click event of the Calculate button     |            *
        *    that retrieves two numbers and the operand the user enters.             |            *
        *                                                                            |            *
        *    A. Call the Calculate() method to get the result of the calculation     |   McKee    *
        *    B. Display the result rounded to four decimal places                    |   &        *
        *    C. Move the focus to the Operand 1 text box                             |   Tepper   *
        * ****************************************************************************************/

        private static decimal Calculate(decimal operand1, string operator1, decimal operand2)
        {
            // 4. if-else or switch if operand == '=', operator1 + operator2...etc.
            // 4C. Math.Round(value, decimal_places) to limit result to 4 decimal places

            decimal result = 0m;

            if (operator1 == "+")
            {
                result = Math.Round((operand1 + operand2), 4);
            }
            else if (operator1 == "-")
            {
                result = Math.Round((operand1 - operand2), 4);
            }
            else if (operator1 == "*")
            {
                result = Math.Round((operand1 * operand2), 4);
            }
            else if (operator1 == "/")
            {
                result = Math.Round((operand1 / operand2), 4);
            }
            else
            {
                MessageBox.Show("Please enter one of these operators: + - * / ");
            }

            return result;
        }

        /* **********************************************************************************
        * 5. Create an event handler for the Click event of the Exit button   |   McKee &   *
        *    that closes the form.                                            |   Tepper    *
        * **********************************************************************************/

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

/* ****************************************************************************
* 6. Create an event handler that clears the Result text box if  |   McKee &  *
*    the user changes that text in any of the other text boxes.  |   Tepper   *
* ****************************************************************************/
        private void ClearResult(object sender, EventArgs e)
        {
            txtResult.Text = "";
        }
    }
}
