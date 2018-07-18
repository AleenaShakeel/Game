using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form3 : Form
    {
        Form1 frm1;
        public Form3(Form1 f1)
        {
            frm1 = f1;
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.label1.BackColor = Color.Transparent;
            this.label1.ForeColor = Color.White;
            this.label2.BackColor = Color.Transparent;
            this.label3.BackColor = Color.Transparent;
            this.label4.BackColor = Color.Transparent;
            this.label5.BackColor = Color.Transparent;
            this.label4.ForeColor = Color.White;
            this.textBox1.TextAlign = HorizontalAlignment.Center;
            this.textBox2.TextAlign = HorizontalAlignment.Center;
            this.textBox3.TextAlign = HorizontalAlignment.Center;
            this.button1.Text = "Click";
            this.button2.Text = "Click";
            this.label1.Text = "=";
            this.button3.Text = "Check";
            this.button5.Text = "Try Again";
            //this.label1.ForeColor = Color.WhiteSmoke;
            //this.label2.ForeColor = Color.WhiteSmoke;
            //this.label3.ForeColor = Color.WhiteSmoke;
            //this.label4.ForeColor = Color.WhiteSmoke;
            this.label2.Visible = false;
            string[] opt = { "+", "-", "*", "/" };
            comboBox1.Items.AddRange(opt);
            this.label3.TextAlign = ContentAlignment.MiddleCenter;
            this.label3.Visible = false;
            this.label4.Visible = false;
            this.comboBox1.Enabled = false;
            this.textBox2.Enabled = false;
            this.textBox3.Enabled = false;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.ControlBox = false;
            this.label5.Visible = false;
            this.button6.Text = "Exit";
            this.button5.Visible = false;
            this.button4.BackColor = Color.Green;
            this.button6.BackColor = Color.Green;
            this.button4.ForeColor = Color.WhiteSmoke;
            this.button6.ForeColor = Color.WhiteSmoke;
            this.textBox1.ReadOnly = true;
            this.textBox2.ReadOnly = true;
            this.label1.TextAlign = ContentAlignment.MiddleCenter;
            this.textBox1.Cursor = Cursors.No;
            this.textBox2.Cursor = Cursors.No;
            this.button3.Enabled = false;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int random;
            Random r = new Random();
            random = r.Next(0, 10);
            textBox1.Text = random.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "+")
            {
                this.label3.Visible = true;
                this.label4.Visible = true;
                this.label4.Text = "You Select";
                this.label3.Text = "Addition";
            }
            if (comboBox1.Text == "-")
            {
                this.label3.Visible = true;
                this.label4.Visible = true;
                this.label4.Text = "You Select";
                this.label3.Text = "Subtraction";
            }
            if (comboBox1.Text == "*")
            {
                this.label3.Visible = true;
                this.label4.Visible = true;
                this.label4.Text = "You Select";
                this.label3.Text = "Multiplication";
            }
            if (comboBox1.Text == "/")
            {
                this.label3.Visible = true;
                this.label4.Visible = true;
                this.label4.Text = "You Select";
                this.label3.Text = "Division";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "")
            {
                this.comboBox1.Enabled = false;
            }
            else
            {
                this.textBox2.Enabled = true;
                this.comboBox1.Enabled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.textBox3.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int random;
            Random r = new Random();
            random = r.Next(0, 10);
            textBox2.Text = random.ToString();
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {
            if (this.textBox3.Text == "")
            {
                this.button3.Enabled = false;
            }
            else
            {
                this.button3.Enabled = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt16(textBox1.Text);
            b = Convert.ToInt16(textBox2.Text);
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Select an operation", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (textBox3.Text == "")
            {
                MessageBox.Show("Enter Your Answer", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //this.button3.Enabled = false;

                if (comboBox1.Text == "+")
                {
                    c = a + b;
                    if (textBox3.Text == c.ToString())
                    {
                        this.label2.Visible = true;
                        this.label2.Text = "Correct Answer";
                        this.button5.Visible = true;
                    }
                    else
                    {
                        this.label2.Visible = false;
                        this.label5.Visible = true;
                        this.label5.Text = "Wrong Answer, correct answer = " + c.ToString();
                        this.button5.Visible = true;
                    }
                }
                if (comboBox1.Text == "-")
                {
                    c = a - b;
                    if (textBox3.Text == c.ToString())
                    {
                        this.label2.Visible = true;
                        this.label2.Text = "Correct Answer";
                        this.button5.Visible = true;
                    }
                    else
                    {
                        this.label2.Visible = false;
                        this.label5.Visible = true;
                        this.label5.Text = "Wrong Answer, correct answer = " + c.ToString();
                        this.button5.Visible = true;
                    }
                }
                if (comboBox1.Text == "*")
                {
                    c = a * b;
                    if (textBox3.Text == c.ToString())
                    {
                        this.label2.Visible = true;
                        this.label2.Text = "Correct Answer";
                        this.button5.Visible = true;
                    }
                    else
                    {
                        this.label2.Visible = false;
                        this.label5.Visible = true;
                        this.label5.Text = "Wrong Answer, correct answer = " + c.ToString();
                        this.button5.Visible = true;
                    }
                }
                if (comboBox1.Text == "/")
                {
                    c = a / b;
                    if (textBox3.Text == c.ToString())
                    {
                        this.label2.Visible = true;
                        this.label2.Text = "Correct Answer";
                        this.button5.Visible = true;
                    }
                    else
                    {
                        this.label2.Visible = false;
                        this.label5.Visible = true;
                        this.label5.Text = "Wrong Answer, correct answer = " + c.ToString();
                        this.button5.Visible = true;
                    }
                }
                if (textBox3.Text.Length > 0)
                {
                    this.button3.Enabled = false;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            frm1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to play more games?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
                frm1.Show();
            }
            else
            {
                Application.Exit();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            this.label2.Visible = false;
            this.label3.TextAlign = ContentAlignment.MiddleCenter;
            this.label3.Visible = false;
            this.label4.Visible = false;
            this.label5.Visible = false;
            this.comboBox1.Enabled = false;
            this.textBox2.Enabled = false;
            this.textBox3.Enabled = false;
            this.button3.Enabled = true;
            this.button5.Visible = false;
            this.button3.Enabled = false;
        }
    }
}
