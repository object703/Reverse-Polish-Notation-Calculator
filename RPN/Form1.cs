using System;
using System.Data;
using System.Windows.Forms;

namespace RPN
{
    public partial class Form1 : Form
    {
        private IStack<double> stack;
        private PolishNotationCalculator calculator;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Eval_Click(object sender, EventArgs e)
        {
            stack = new ArrayStack<double>();
            calculator = new PolishNotationCalculator(stack);
            lbl_Output.Text = calculator.Evaluate(txt_Input.Text).ToString();
        }
    }
}
