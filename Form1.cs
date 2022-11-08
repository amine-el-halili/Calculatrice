namespace Calculatrice
{
    public partial class MyCalculater : Form
    {
        private Boolean isNewInput = true;
        private Boolean isOperation = false;
        private Char operator1;
        private String operand1 = "";
        private String operand2;
        private int result;

        private void next(char op)
        {
            operand2 = lblInput.Text;
            result = calcul(operand1, operand2, operator1);
            operator1 = op;
            operand1 = result.ToString();
        }

        private int calcul(String a, String b, Char op)
        {
            switch (op)
            {
                case '+':
                    return int.Parse(a) + int.Parse(b);
                case '-':
                    return int.Parse(a) - int.Parse(b);
                case '*':
                    return int.Parse(a) * int.Parse(b);
                case '/':
                    return int.Parse(a) / int.Parse(b);
                default:
                    return 0;
            }
        }
        public MyCalculater()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblInput_Click(object sender, EventArgs e)
        {

        }

        private void lblOperation_Click(object sender, EventArgs e)
        {

        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (!isNewInput)
            {
                lblInput.Text += "0";
            } else
            {
                isNewInput = false;
                lblInput.Text = "0";
            }
        }

        private void btnComma_Click(object sender, EventArgs e)
        {
            if (isNewInput)
            {
                lblInput.Text = ".";
                isNewInput = false;
            }
            else
            {
                lblInput.Text += ".";
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
 
            isNewInput = true;
            if (operator1 == '\0')
            {
                operand1 = lblInput.Text;
                operator1 = '+';
            }
            else next('+');


            lblOperation.Text = operand1 + " + ";
            lblInput.Text = operand1;
        }

        private void btnDeleteLast_Click(object sender, EventArgs e)
        {
            if (!isNewInput)
            {
                lblInput.Text = lblInput.Text.Remove(lblInput.Text.Length - 1, 1);
            }

            if (lblInput.Text.Length == 0)
            {
                lblInput.Text = "0";
                isNewInput = true;
            }
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            if (isNewInput)
            {
                lblInput.Text = "1";
                isNewInput = false;
            }
            else
            {
                lblInput.Text += "1";
            }
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (isNewInput)
            {
                lblInput.Text = "2";
                isNewInput = false;
            }
            else
            {
                lblInput.Text += "2";
            }
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            if (isNewInput)
            {
                lblInput.Text = "3";
                isNewInput = false;
            }
            else
            {
                lblInput.Text += "3";
            }
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (isNewInput)
            {
                lblInput.Text = "4";
                isNewInput = false;
            }
            else
            {
                lblInput.Text += "4";
            }
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (isNewInput)
            {
                lblInput.Text = "5";
                isNewInput = false;
            }
            else
            {
                lblInput.Text += "5";
            }
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (isNewInput)
            {
                lblInput.Text = "6";
                isNewInput = false;
            }
            else
            {
                lblInput.Text += "6";
            }
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (isNewInput)
            {
                lblInput.Text = "7";
                isNewInput = false;
            }
            else
            {
                lblInput.Text += "7";
            }
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (isNewInput)
            {
                lblInput.Text = "8";
                isNewInput = false;
            }
            else
            {
                lblInput.Text += "8";
            }
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (isNewInput)
            {
                lblInput.Text = "9";
                isNewInput = false;
            }
            else
            {
                lblInput.Text += "9";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            operator1 = '\0';
            lblInput.Text = "0";
            lblOperation.Text = "";
            operand1 = "";
            isNewInput = true;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            isNewInput = true;
            if (operator1 == '\0')
            {
                operand1 = lblInput.Text;
                operator1 = '-';
            }
            else next('-');


            lblOperation.Text = operand1 + " - ";
            lblInput.Text = operand1;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            isNewInput = true;
            if (operator1 == '\0')
            {
                operand1 = lblInput.Text;
                operator1 = '*';
            }
            else next('*');

            lblOperation.Text = operand1 + " * ";
            lblInput.Text = operand1;
        }

        private void btnDivise_Click(object sender, EventArgs e)
        {
            isNewInput = true;
            if (operator1 == '\0')
            {
                operand1 = lblInput.Text;
                operator1 = '/';
            }
            else next('/');


            lblOperation.Text = operand1 + " / ";
            lblInput.Text = operand1;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if(operator1 == '\0')
            {
                lblOperation.Text = " = ";
            } else
            {
                operand2 = lblInput.Text;
                result = calcul(operand1, operand2, operator1);
                lblOperation.Text = operand1 + operator1 + operand2 + " = ";
                lblInput.Text = result.ToString();

                operand1 = operand2 = "";
                isNewInput = true;
                operator1 = '\0';
            }
        }
    }
}