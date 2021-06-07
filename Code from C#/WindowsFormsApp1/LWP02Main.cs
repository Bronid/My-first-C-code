using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LWP02Main : Form
    {
        Boolean Operation1 = false;
        Boolean Operation2 = false;
        Boolean Operation3 = false;
        Boolean Operation4 = false;
        Boolean Clear = false;
        Double A, B, Result;
        Boolean Dot = false;

        public LWP02Main()
        {
            InitializeComponent();
        }

        private void B3_Click(object sender, EventArgs e)
        {
            if (Clear == true)
            {
                ResultBox.Clear();
                Clear = false;
                Dot = false;
            }
            if (Operation1 == false && Operation2 == false && Operation3 == false && Operation4 == false)
            {
                ResultBox.AppendText("3");
                A = Convert.ToDouble(ResultBox.Text.Replace(".", ","));
            }
            else
            {
                ResultBox.AppendText("3");
                B = Convert.ToDouble(ResultBox.Text.Replace(".", ","));
            }
        }

        private void B4_Click(object sender, EventArgs e)
        {
            if (Clear == true)
            {
                ResultBox.Clear();
                Clear = false;
                Dot = false;
            }
            if (Operation1 == false && Operation2 == false && Operation3 == false && Operation4 == false)
            {
                ResultBox.AppendText("4");
                A = Convert.ToDouble(ResultBox.Text.Replace(".", ","));
            }
            else
            {
                ResultBox.AppendText("4");
                B = Convert.ToDouble(ResultBox.Text.Replace(".", ","));
            }
        }

        private void B5_Click(object sender, EventArgs e)
        {
            if (Clear == true)
            {
                ResultBox.Clear();
                Clear = false;
                Dot = false;
            }
            if (Operation1 == false && Operation2 == false && Operation3 == false && Operation4 == false)
            {
                ResultBox.AppendText("5");
                A = Convert.ToDouble(ResultBox.Text.Replace(".", ","));
            }
            else
            {
                ResultBox.AppendText("5");
                B = Convert.ToDouble(ResultBox.Text.Replace(".", ","));
            }
        }

        private void B6_Click(object sender, EventArgs e)
        {
            if (Clear == true)
            {
                ResultBox.Clear();
                Clear = false;
                Dot = false;
            }
            if (Operation1 == false && Operation2 == false && Operation3 == false && Operation4 == false)
            {
                ResultBox.AppendText("6");
                A = Convert.ToDouble(ResultBox.Text.Replace(".", ","));
            }
            else
            {
                ResultBox.AppendText("6");
                B = Convert.ToDouble(ResultBox.Text.Replace(".", ","));
            }
        }

        private void B7_Click(object sender, EventArgs e)
        {
            if (Clear == true)
            {
                ResultBox.Clear();
                Clear = false;
                Dot = false;
            }
            if (Operation1 == false && Operation2 == false && Operation3 == false && Operation4 == false)
            {
                ResultBox.AppendText("7");
                A = Convert.ToDouble(ResultBox.Text.Replace(".", ","));
            }
            else
            {
                ResultBox.AppendText("7");
                B = Convert.ToDouble(ResultBox.Text.Replace(".", ","));
            }
        }

        private void B8_Click(object sender, EventArgs e)
        {
            if (Clear == true)
            {
                ResultBox.Clear();
                Clear = false;
                Dot = false;
            }
            if (Operation1 == false && Operation2 == false && Operation3 == false && Operation4 == false)
            {
                ResultBox.AppendText("8");
                A = Convert.ToDouble(ResultBox.Text.Replace(".", ","));
            }
            else
            {
                ResultBox.AppendText("8");
                B = Convert.ToDouble(ResultBox.Text.Replace(".", ","));
            }
        }

        private void B9_Click(object sender, EventArgs e)
        {
            if (Clear == true)
            {
                ResultBox.Clear();
                Clear = false;
                Dot = false;
            }
            if (Operation1 == false && Operation2 == false && Operation3 == false && Operation4 == false)
            {
                ResultBox.AppendText("9");
                A = Convert.ToDouble(ResultBox.Text.Replace(".", ","));
            }
            else
            {
                ResultBox.AppendText("9");
                B = Convert.ToDouble(ResultBox.Text.Replace(".", ","));
            }
        }

        private void B0_Click(object sender, EventArgs e)
        {
            if (Clear == true)
            {
                ResultBox.Clear();
                Clear = false;
                Dot = false;
            }
            if (Operation1 == false && Operation2 == false && Operation3 == false && Operation4 == false)
            {
                ResultBox.AppendText("0");
                A = Convert.ToDouble(ResultBox.Text.Replace(".", ","));
            }
            else
            {
                ResultBox.AppendText("0");
                B = Convert.ToDouble(ResultBox.Text.Replace(".", ","));
            }
        }

        private void BResult_Click(object sender, EventArgs e)
        {
            if (Operation1 == true)
            {
                Result = A + B;
            }
            if (Operation2 == true)
            {
                Result = A - B;
            }
            if (Operation3 == true)
            {
                Result = A * B;
            }
            if (Operation4 == true)
            {
                Result = A / B;
            }
            ResultBox.Text = Result.ToString();
            Operation1 = false;
            Operation2 = false;
            Operation3 = false;
            Operation4 = false;
            Clear = true;
        }

        private void BC_Click(object sender, EventArgs e)
        {
            ResultBox.Clear();
            Operation1 = false;
            Operation2 = false;
            Operation3 = false;
            Operation4 = false;
            Clear = false;
            A = 0;
            B = 0;
            Result = 0;
            Dot = false;
        }

        private void BOperation1_Click(object sender, EventArgs e)
        {
            Operation1 = true;
            Operation2 = false;
            Operation3 = false;
            Operation4 = false;
            Dot = true;
            ResultBox.Clear();
        }

        private void BOperation2_Click(object sender, EventArgs e)
        {
            Operation1 = false;
            Operation2 = true;
            Operation3 = false;
            Operation4 = false;
            Dot = true;
            ResultBox.Clear();
        }

        private void BOperation3_Click(object sender, EventArgs e)
        {
            Operation1 = false;
            Operation2 = false;
            Operation3 = true;
            Operation4 = false;
            Dot = true;
            ResultBox.Clear();
        }

        private void BOperation4_Click(object sender, EventArgs e)
        {
            Operation1 = false;
            Operation2 = false;
            Operation3 = false;
            Operation4 = true;
            Dot = true;
            ResultBox.Clear();
        }

        private void BD_Click(object sender, EventArgs e)
        {
            if (Clear == true)
            {
                ResultBox.Clear();
                Clear = false;
                Dot = false;
            }
            if (Operation1 == false && Operation2 == false && Operation3 == false && Operation4 == false)
            {
                if (Dot == false)
                {
                    ResultBox.AppendText(",");
                    Dot = true;
                }
            }
            else
            {
                if (Dot == true)
                {
                    ResultBox.AppendText(",");
                    Dot = false;
                }
            }

        }

        private void BSpecial_Click(object sender, EventArgs e)
        {
            SByte d = Convert.ToSByte(NumericSpecial.Value);
            ResultBox.Text = Convert.ToString(Math.Round(Result, d));
        }

        private void B2_Click(object sender, EventArgs e)
        {
            if (Clear == true)
            {
                ResultBox.Clear();
                Clear = false;
                Dot = false;
            }
            if (Operation1 == false && Operation2 == false && Operation3 == false && Operation4 == false)
            {
                ResultBox.AppendText("2");
                A = Convert.ToDouble(ResultBox.Text.Replace(".", ","));
            }
            else
            {
                ResultBox.AppendText("2");
                B = Convert.ToDouble(ResultBox.Text.Replace(".", ","));
            }
        }

        private void B1_Click(object sender, EventArgs e)
        {
            if (Clear == true)
            {
                ResultBox.Clear();
                Clear = false;
                Dot = false;
            }
            if (Operation1 == false && Operation2 == false && Operation3 == false && Operation4 == false)
            {
                ResultBox.AppendText("1");
                A = Convert.ToDouble(ResultBox.Text.Replace(".", ","));
            }
            else
            {
                ResultBox.AppendText("1");
                B = Convert.ToDouble(ResultBox.Text.Replace(".", ","));
            }
        }
    }
}
