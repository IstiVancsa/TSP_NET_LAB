using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        private double? lastNumber { get; set; } = -1;
        private string lastOperator { get; set; }
        public Form1()
        {
            InitializeComponent();
            resultTextBox.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resultTextBox.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            resultTextBox.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            resultTextBox.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            resultTextBox.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            resultTextBox.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            resultTextBox.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            resultTextBox.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            resultTextBox.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            resultTextBox.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (resultTextBox.Text.Count() > 0)
                resultTextBox.Text += "0";
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            char[] ops = "+-*/".ToCharArray();
            var numbers = resultTextBox.Text.Split(ops);
            if (resultTextBox.Text.Count() > 0)
                if (!numbers[numbers.Count() - 1].Contains("."))
                    resultTextBox.Text += ".";
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            char[] ops = "+-*/".ToCharArray();
            if (resultTextBox.Text.Contains("+") || resultTextBox.Text.Contains("-") || resultTextBox.Text.Contains("*") || resultTextBox.Text.Contains("/"))
                if (ops.Contains(resultTextBox.Text[resultTextBox.Text.Count() - 1]))
                {
                    var numb = Convert.ToDouble(resultTextBox.Text.Split(ops)[0]);
                    resultTextBox.Text = ApplyOperator(this.lastOperator, numb, this.lastNumber).ToString();
                }
                else
                {
                    if ("+-".Contains(resultTextBox.Text[0]))
                    {
                        string op = resultTextBox.Text.Reverse().FirstOrDefault(x => ops.Contains(x)).ToString();
                        ManageOperation(op, true);
                    }
                    else
                    {
                        string op = resultTextBox.Text.FirstOrDefault(x => ops.Contains(x)).ToString();
                        ManageOperation(op, true);
                    }
                }
            else
                if (this.lastNumber != -1)
            {
                var numb = Convert.ToDouble(resultTextBox.Text);
                resultTextBox.Text = ApplyOperator(this.lastOperator, numb, this.lastNumber).ToString();
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (resultTextBox.Text.Count() == 0)
                resultTextBox.Text += "+";
            else
            {
                if (resultTextBox.Text[resultTextBox.Text.Count() - 1] == '.')
                    resultTextBox.Text = resultTextBox.Text.Substring(0, resultTextBox.Text.Count() - 1);
                ManageOperation("+");
            }

        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (resultTextBox.Text.Count() == 0)
                resultTextBox.Text += "-";
            else
                ManageOperation("-");
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            ManageOperation("*");
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            ManageOperation("/");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ManageOperation(string myOperator, bool equalPressed = false)
        {
            if (resultTextBox.Text.Count() > 0)
            {
                double? numb1, numb2;
                char[] ops = "+-*/".ToCharArray();
                string op;
                if (!ops.Contains(resultTextBox.Text[resultTextBox.Text.Count() - 1]))
                {

                    var components = GetComponents(resultTextBox.Text);
                    numb1 = components.Item1;

                    numb2 = components.Item2;
                    op = components.Item3;
                    if (numb1 == null)
                    {
                        resultTextBox.Text += myOperator;
                        resultTextBox.SelectionStart = resultTextBox.Text.Length;
                        resultTextBox.SelectionLength = 0;
                    }
                    else
                        if (!(op == "/" && numb2 == 0))
                    {
                        resultTextBox.Text = ApplyOperator(op, numb1, numb2).ToString() + (equalPressed ? "" : myOperator);
                        resultTextBox.SelectionStart = resultTextBox.Text.Length;
                        resultTextBox.SelectionLength = 0;
                    }
                    else
                    {
                        resultTextBox.Text = "";
                        MessageBox.Show("You can't divide with 0", "Error Detected in Input", MessageBoxButtons.OK);
                    }
                }
                else
                    if ("+-".Contains(myOperator) && !ops.Contains(resultTextBox.Text[resultTextBox.Text.Count() - 2]))
                {
                    resultTextBox.Text += myOperator;
                    resultTextBox.SelectionStart = resultTextBox.Text.Length;
                    resultTextBox.SelectionLength = 0;
                }
            }
            else
            {
                resultTextBox.Text += myOperator;
            }
        }

        private double? ApplyOperator(string op, double? numb1, double? numb2)
        {
            double? result = 0;
            switch (op)
            {
                case ("+"):
                    result = numb1 + numb2;
                    break;
                case ("-"):
                    result = numb1 - numb2;
                    break;
                case ("*"):
                    result = numb1 * numb2;
                    break;
                case ("/"):
                    result = numb1 / numb2;
                    break;
            }
            this.lastNumber = numb2;
            this.lastOperator = op;
            return result;
        }

        private Tuple<double?, double?, string> GetComponents(string text)
        {
            char[] ops = "+-*/".ToCharArray();
            var result = Enumerable.Range(0, text.Count())
             .Where(i => ops.Contains(text[i]))
             .ToList();
            switch (result.Count)
            {
                case (3):
                    return new Tuple<double?, double?, string>(Convert.ToDouble(text[result[0]].ToString() + text.Split(ops)[1]), Convert.ToDouble(text[result[2]].ToString() + text.Split(ops)[3]), text[result[1]].ToString());
                case (2):
                    if ("+-".Contains(text[0]))
                        return new Tuple<double?, double?, string>(Convert.ToDouble(text[result[0]].ToString() + text.Split(ops)[1]), Convert.ToDouble(text.Split(ops)[2]), text[result[1]].ToString());
                    else
                        return new Tuple<double?, double?, string>(Convert.ToDouble(text.Split(ops)[0]), Convert.ToDouble(text[result[1]].ToString() + text.Split(ops)[2]), text[result[0]].ToString());
                case (1):
                    if (!"+-".Contains(text[0]))
                        return new Tuple<double?, double?, string>(Convert.ToDouble(text.Split(ops)[0]), Convert.ToDouble(text.Split(ops)[1]), text[result[0]].ToString());
                    else
                        return new Tuple<double?, double?, string>(null, null, null);
                default:
                    return new Tuple<double?, double?, string>(null, null, null);
            }
        }

        private void resultTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char[] ops = "+-*/".ToCharArray();
            if (!"0123456789+-*/.\b=\r".Contains(e.KeyChar))
                e.KeyChar = '\0';
            if (resultTextBox.Text.Count() == 0 && e.KeyChar == '0')
                e.KeyChar = '\0';

            if (ops.Contains(e.KeyChar))
            {
                if (resultTextBox.Text.Count() > 0)
                {
                    double? numb1, numb2;
                    string op;
                    if (!ops.Contains(resultTextBox.Text[resultTextBox.Text.Count() - 1]))
                    {

                        var components = GetComponents(resultTextBox.Text);
                        numb1 = components.Item1;

                        numb2 = components.Item2;
                        op = components.Item3;
                        if (numb1 != null)
                            if (!(op == "/" && numb2 == 0))
                            {
                                resultTextBox.Text = ApplyOperator(op, numb1, numb2).ToString() + e.KeyChar;
                                e.KeyChar = '\0';
                                resultTextBox.SelectionStart = resultTextBox.Text.Length;
                                resultTextBox.SelectionLength = 0;
                            }
                            else
                            {
                                resultTextBox.Text = "";
                                e.KeyChar = '\0';
                                MessageBox.Show("You can't divide with 0", "Error Detected in Input", MessageBoxButtons.OK);
                            }
                    }
                    else
                        if (!("+-".Contains(e.KeyChar) && !ops.Contains(resultTextBox.Text[resultTextBox.Text.Count() - 2])))
                    {
                        e.KeyChar = '\0';
                        resultTextBox.SelectionStart = resultTextBox.Text.Length;
                        resultTextBox.SelectionLength = 0;
                    }
                }
                else
                {
                    e.KeyChar = '\0';
                }
            }
            if (e.KeyChar == '=' || e.KeyChar == '\r')
            {
                if (resultTextBox.Text.Contains("+") || resultTextBox.Text.Contains("-") || resultTextBox.Text.Contains("*") || resultTextBox.Text.Contains("/"))
                    if (ops.Contains(resultTextBox.Text[resultTextBox.Text.Count() - 1]))
                    {
                        var numb = Convert.ToDouble(resultTextBox.Text.Split(ops)[0]);
                        resultTextBox.Text = ApplyOperator(this.lastOperator, numb, this.lastNumber).ToString();
                        resultTextBox.SelectionStart = resultTextBox.Text.Length;
                        resultTextBox.SelectionLength = 0;
                        e.KeyChar = '\0';
                    }
                    else
                    {
                        if ("+-".Contains(resultTextBox.Text[0]))
                        {
                            string op = resultTextBox.Text.Reverse().FirstOrDefault(x => ops.Contains(x)).ToString();
                            ManageOperation(op, true);
                            resultTextBox.SelectionStart = resultTextBox.Text.Length;
                            resultTextBox.SelectionLength = 0;
                            e.KeyChar = '\0';
                        }
                        else
                        {
                            string op = resultTextBox.Text.FirstOrDefault(x => ops.Contains(x)).ToString();
                            ManageOperation(op, true);
                            resultTextBox.SelectionStart = resultTextBox.Text.Length;
                            resultTextBox.SelectionLength = 0;
                            e.KeyChar = '\0';
                        }
                    }
                else
                if (this.lastNumber != -1)
                {
                    var numb = Convert.ToDouble(resultTextBox.Text);
                    resultTextBox.Text = ApplyOperator(this.lastOperator, numb, this.lastNumber).ToString();
                    resultTextBox.SelectionStart = resultTextBox.Text.Length;
                    resultTextBox.SelectionLength = 0;
                    e.KeyChar = '\0';
                }
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            this.lastNumber = -1;
            this.lastOperator = "";
            resultTextBox.Text = "";
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = resultTextBox.Text.Substring(0, resultTextBox.Text.Count() - 1);
            if (resultTextBox.Text.Count() > 0)
                if (resultTextBox.Text[resultTextBox.Text.Count() - 1] == '.')
                    resultTextBox.Text = resultTextBox.Text.Substring(0, resultTextBox.Text.Count() - 1);
        }
    }
}
