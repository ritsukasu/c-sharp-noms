using System;
using System.Windows.Forms;
using CalculatorPrivateAssembly;

namespace BasicCalculator
{
    public partial class FrmBasicCalculator : Form
    {
        public FrmBasicCalculator()
        {
            InitializeComponent();
        }

        private void FrmBasicCalculator_Load(object sender, EventArgs e)
        {
            cboOperator.SelectedIndex = 0;
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            float firstNumber;
            float secondNumber;

            if (!float.TryParse(txtFirstNumber.Text, out firstNumber) ||
                !float.TryParse(txtSecondNumber.Text, out secondNumber))
            {
                MessageBox.Show("Please enter valid numbers.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            float result = 0;

            switch (cboOperator.Text)
            {
                case "+":
                    result = BasicComputation.Addition(firstNumber, secondNumber);
                    break;
                case "-":
                    result = BasicComputation.Subtraction(firstNumber, secondNumber);
                    break;
                case "*":
                    result = BasicComputation.Multiplication(firstNumber, secondNumber);
                    break;
                case "/":
                    if (secondNumber == 0)
                    {
                        MessageBox.Show("Cannot divide by zero.", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    result = BasicComputation.Division(firstNumber, secondNumber);
                    break;
            }

            lblTotal.Text = result.ToString();
        }
    }
}
