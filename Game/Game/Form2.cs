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
    public partial class Form2 : Form
    {
        Form1 frm1;
        public Form2(Form1 f1)
        {
            frm1 = f1;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.pictureBox1.BackColor = Color.Transparent;
            this.pictureBox1.Image = Properties.Resources.editapple;
            this.pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            this.label1.BackColor = Color.Transparent;
            this.label2.BackColor = Color.Transparent;
            this.button1.BackColor = Color.Green;
            this.button2.BackColor = Color.Red;
            this.button3.BackColor = Color.YellowGreen;
            this.label2.Visible = false;
            this.button6.Text = "Exit";
            this.button7.Visible = false;
            this.button8.Visible = false;
            this.button9.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frm1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.label2.Visible = true;
            label2.Text = "Correct Answer";
            this.label2.ForeColor = Color.Green;
            button3.Enabled = false;
            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.button1.BackColor = Color.WhiteSmoke;
            this.button1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.button3.BackColor = Color.WhiteSmoke;
            this.button3.Enabled = false;
        }
         
        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to play more games?","", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                frm1.Show();
            }
            else
            {
                Application.Exit();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.label2.Visible = false;
            this.pictureBox1.Image = Properties.Resources.banana;
            this.pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            this.label1.Text = "What is the Color of Bananas?";
            this.button7.BackColor = Color.Yellow;
            this.button8.BackColor = Color.GreenYellow;
            this.button9.BackColor = Color.Orange;
            this.button7.Visible = true;
            this.button8.Visible = true;
            this.button9.Visible = true;
            this.button1.Visible = false;
            this.button2.Visible = false;
            this.button3.Visible = false;
            this.button5.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.label2.Visible = true;
            button8.Enabled = false;
            button9.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.button8.BackColor = Color.WhiteSmoke;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.button9.BackColor = Color.WhiteSmoke;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
    }
}
