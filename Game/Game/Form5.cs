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
    public partial class Form5 : Form
    {
        //PictureBox pendingimage1 = null;
        //PictureBox pendingimage2 = null;
        Form1 frm1;
        public Form5(Form1 f1)
        {
            frm1 = f1;
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            this.label1.Text = "Match Shapes";
            this.label1.ForeColor = Color.DeepSkyBlue;
            this.ControlBox = false;
            this.pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            this.BackColor = Color.DarkSlateBlue;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.pictureBox1.Image = Properties.Resources.bcover;
            this.pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            this.pictureBox2.Image = Properties.Resources.bcover;
            this.pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            this.pictureBox3.Image = Properties.Resources.bcover;
            this.pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            this.pictureBox4.Image = Properties.Resources.bcover;
            this.pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            this.pictureBox5.Image = Properties.Resources.bcover;
            this.pictureBox5.SizeMode = PictureBoxSizeMode.CenterImage;
            this.pictureBox6.Image = Properties.Resources.bcover;
            this.pictureBox6.SizeMode = PictureBoxSizeMode.CenterImage;
            this.pictureBox7.Image = Properties.Resources.bcover;
            this.pictureBox7.SizeMode = PictureBoxSizeMode.CenterImage;
            this.pictureBox8.Image = Properties.Resources.bcover;
            this.pictureBox8.SizeMode = PictureBoxSizeMode.CenterImage;
            this.pictureBox9.Image = Properties.Resources.bcover;
            this.pictureBox9.SizeMode = PictureBoxSizeMode.CenterImage;
            this.label2.Visible = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Image = Properties.Resources.Custom_Icon_Design_Pretty_Office_9_Square;
            this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            //if (pendingimage1 == null)
            //{
            //    pendingimage1.Image = pictureBox1.Image;
            //}
            //else if (pendingimage1 != null && pendingimage2 == null)
            //{
            //    pendingimage2.Image = pictureBox1.Image;
            //}
            //if (pendingimage1 != null && pendingimage2 != null)
            //{
            //    if (pendingimage1.Tag == pendingimage2.Tag)
            //    {
            //        this.label2.Visible = true;
            //        this.label2.Text = "You Match Square";
            //    }
            //    else
            //    {
            //        pendingimage1.Image = Properties.Resources.bcover;
            //        pendingimage2.Image = Properties.Resources.bcover;
            //    }
            //    pendingimage1 = null;
            //    pendingimage2 = null;
            //}
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            this.pictureBox5.Image = Properties.Resources.Custom_Icon_Design_Pretty_Office_9_Square;
            this.pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.pictureBox9.Image = Properties.Resources.Custom_Icon_Design_Pretty_Office_9_Square;
            this.pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.pictureBox2.Image = Properties.Resources.Custom_Icon_Design_Flatastic_6_Triangle;
            this.pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.pictureBox4.Image = Properties.Resources.Custom_Icon_Design_Flatastic_6_Triangle;
            this.pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.pictureBox3.Image = Properties.Resources.Custom_Icon_Design_Flatastic_6_Triangle;
            this.pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.pictureBox6.Image = Properties.Resources.Custom_Icon_Design_Flatastic_6_Circle;
            this.pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.pictureBox8.Image = Properties.Resources.Custom_Icon_Design_Flatastic_6_Circle;
            this.pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.pictureBox7.Image = Properties.Resources.Custom_Icon_Design_Flatastic_6_Circle;
            this.pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to play more games?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                frm1.Show();
            }
            else
            {
                Application.Exit();
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
