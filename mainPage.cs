using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
namespace DSFinalProject
{
    public partial class mainPage : KryptonForm
    {

        private bool isFirstNumber = true;
        private long num1;
        private long num2;
        private string qValue;
        public mainPage()
        {
            InitializeComponent();
            textBox1.Enabled = false;
            

        }

        private void Display_Proving(long fNumber, long sNumber)
        {
            lbl_proving.Text = Euclidean_Algorithm(fNumber, sNumber).ToString();
        }
        private void Proof_Text(long a, long b)
        {
            lbl_proof_title.Text = $"Proof of Algorithm";
            string proof_Initial = $"If a = bq + r" + Environment.NewLine + "then, gcd(a , b) = gcd (b, r)" + Environment.NewLine +
                "a = bq + r" + Environment.NewLine + "gcd(a , b) = d IFF gcd(b, r) = d";
            lbl_proof_initial.Text = proof_Initial;
            string ass1_Text = $"d|a and d|b" + Environment.NewLine + "d|(a - qb)" + Environment.NewLine + "a = bq + r, rewrite to r = a - bq" +
                Environment.NewLine + "if r = a - bq is the same as d|(a - qb)" + Environment.NewLine + "then, d|r";
            lbl_ass1_text.Text = ass1_Text;
            string ass2_Text = $"d|b and d|r" + Environment.NewLine + "d|(bq + r)" + Environment.NewLine + "d|a";
            lbl_ass2_text.Text = ass2_Text;
            lbl_proof_ass1.Text = $"Assumption 1";
            lbl_proof_ass2.Text = $"Assumption 1";

            // TO BE MODIFIED
            string labelValue = lbl_proving.Text;
            long r = a % b;

            string ass1_Proof = Environment.NewLine + $"if d|a and d|b" + Environment.NewLine + $"{labelValue} | ({a} - ({qValue} * {b}))" + Environment.NewLine +
                $"a = bq + r, rewrite to r = a - bq" + Environment.NewLine + $"then, {labelValue} | r" + Environment.NewLine + $"{labelValue} | {r}";
            lbl_ass1_proof.Text = ass1_Proof;

            string ass2_Proof = Environment.NewLine + "if d|b and d|r" + Environment.NewLine + $"{labelValue} | ({b} * {qValue} - {r})" + Environment.NewLine +
                $"{labelValue} | {a}";
            lbl_ass2_proof.Text = ass2_Proof;

        }
        private void BTN0_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "0";
        }

        private void BTN1_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "1";
        }

        private void BTN2_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "2";
        }

        private void BTN3_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "3";
        }

        private void BTN4_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "4";
        }

        private void BTN5_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "5";
        }

        private void BTN6_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "6";
        }

        private void BTN7_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "7";
        }

        private void BTN8_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "8";
        }

        private void BTN9_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "9";
        }

        private void mainPage_Load(object sender, EventArgs e)
        {
            label1.Hide();
           
            
        }

        private void BTNENTER_Click(object sender, EventArgs e)
        {
            string input = txtTotal.Text;

            if (input == string.Empty)
            {
                MessageBox.Show("No input. Please click the CLEAR button.");
                txtTotal.Enabled = false;
                Disable_BTNS();
                return;
            }

            if (isFirstNumber)
            {
                //if (long.TryParse(fNumber, out long num1));
                num1 = Input_Validation(input);
                isFirstNumber = false;
            }
            else
            {
                num2 = Input_Validation(input);
            }
            currentNumber.Text = txtTotal.Text;
            // Clear the text box after pressing enter
            txtTotal.Text = string.Empty;
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNCLEAR_Click(object sender, EventArgs e)
        {
            isFirstNumber = true;
            txtTotal.Text = string.Empty;
            lbl_proving.Text = string.Empty;
            //label3_firstStep.Text = string.Empty;
            lbl_steps.Text = string.Empty;
            currentNumber.Text = "0000";
            txtTotal.Enabled = true;
            BTNENTER.Enabled = true;
            BTNCALCULATE.Enabled = true;
            BTN1.Enabled = true;
            BTN2.Enabled = true;
            BTN3.Enabled = true;
            BTN4.Enabled = true;
            BTN5.Enabled = true;
            BTN6.Enabled = true;
            BTN7.Enabled = true;
            BTN8.Enabled = true;
            BTN9.Enabled = true;
            BTN0.Enabled = true;
            lbl_proof_title.Text = string.Empty;
            lbl_proof_initial.Text = string.Empty;
            lbl_proof_ass1.Text = string.Empty;
            lbl_proof_ass2.Text = string.Empty;
            lbl_ass1_text.Text = string.Empty;
            lbl_ass2_text.Text = string.Empty;
            lbl_ass1_proof.Text = string.Empty;
            lbl_ass2_proof.Text = string.Empty;
            label1.Hide();
        }

        private void BTNCALCULATE_Click(object sender, EventArgs e)
        {
           
            panel1.Hide();
            panel2.Hide();
           

            try
            {
                label1.Show();
                Display_Proving(num1, num2);
                txtTotal.Enabled = false;
                Disable_BTNS();
                Proof_Text(num1, num2);
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Error: Invalid input.");
            }
           

        }

       


        private long Euclidean_Algorithm(long a, long b)
        {
            long q = 1, r;

            r = a % b;
            if (r == 0)
                return b;
            else
            {
                string firstStep = $"GCD({a}, {b})";
                lbl_steps.Text += firstStep + Environment.NewLine;
                string step1 = $"a = bq + r";
                lbl_steps.Text += step1 + Environment.NewLine;
                while (true)
                {
                    if (a > (b * q))
                    {
                        q++;
                    }

                    if (a < (b * q))
                    {
                        qValue = q.ToString();
                        q -= 1;
                        break;
                    }
                }

                r = a - (b * q);
                string step2 = $"{a} = {b} * {q} + {r}";
                lbl_steps.Text += step2 + Environment.NewLine;
                string step3 = $"replace a with the value of b and replace b with the value of r";
                lbl_steps.Text += step3 + Environment.NewLine + Environment.NewLine;
                a = b;
                b = r;
                return Euclidean_Algorithm(a, b);
            }
        }

        private long Input_Validation(string input)
        {
            if (long.TryParse(input, out long num))
            {
                return num;
            }
            else
            {
                // Invalid input(s)
                txtTotal.Text = string.Empty;
                MessageBox.Show("Please enter valid integer values.");
                return 0;
            }
        }

        private void Disable_BTNS()
        {
            BTNENTER.Enabled = false;
            BTNCALCULATE.Enabled = false;
            BTN1.Enabled = false;
            BTN2.Enabled = false;
            BTN3.Enabled = false;
            BTN4.Enabled = false;
            BTN5.Enabled = false;
            BTN6.Enabled = false;
            BTN7.Enabled = false;
            BTN8.Enabled = false;
            BTN9.Enabled = false;
            BTN0.Enabled = false;
        }

       

        private void currentNumber_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void stepsBtn_Click(object sender, EventArgs e)
        {
           panel2.Hide();
            panel1.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Show();

        }
    }




}
