using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class pharma : Form
    {
        public pharma()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void pharma_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;

            pictureBox3.BackColor = System.Drawing.Color.Red;
            pictureBox6.BackColor = System.Drawing.Color.White;
            pictureBox5.BackColor = System.Drawing.Color.White;
            pictureBox4.BackColor = System.Drawing.Color.White;
            pictureBox7.BackColor = System.Drawing.Color.White;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;

            pictureBox3.BackColor = System.Drawing.Color.White;
            pictureBox6.BackColor = System.Drawing.Color.Red;
            pictureBox5.BackColor = System.Drawing.Color.White;
            pictureBox4.BackColor = System.Drawing.Color.White;
            pictureBox7.BackColor = System.Drawing.Color.White;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
            panel4.Visible = false;
            panel5.Visible = false;

            pictureBox3.BackColor = System.Drawing.Color.White;
            pictureBox6.BackColor = System.Drawing.Color.White;
            pictureBox5.BackColor = System.Drawing.Color.Red;
            pictureBox4.BackColor = System.Drawing.Color.White;
            pictureBox7.BackColor = System.Drawing.Color.White;

        }
        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = true;
            panel5.Visible = false;

            pictureBox3.BackColor = System.Drawing.Color.White;
            pictureBox6.BackColor = System.Drawing.Color.White;
            pictureBox5.BackColor = System.Drawing.Color.White;
            pictureBox4.BackColor = System.Drawing.Color.Red;
            pictureBox7.BackColor = System.Drawing.Color.White;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = true;

            pictureBox3.BackColor = System.Drawing.Color.White;
            pictureBox6.BackColor = System.Drawing.Color.White;
            pictureBox5.BackColor = System.Drawing.Color.White;
            pictureBox4.BackColor = System.Drawing.Color.White;
            pictureBox7.BackColor = System.Drawing.Color.Red;

        }
    }
}
