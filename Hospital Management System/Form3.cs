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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            pictureBox3.BackColor = System.Drawing.Color.Red;
            pictureBox5.BackColor = System.Drawing.Color.White;
            pictureBox4.BackColor = System.Drawing.Color.White;
            pictureBox6.BackColor = System.Drawing.Color.White;

            panel2.Visible = false;
            panel1.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
  
            pictureBox5.BackColor = System.Drawing.Color.Red;
            pictureBox3.BackColor = System.Drawing.Color.White;
            pictureBox4.BackColor = System.Drawing.Color.White;
            pictureBox6.BackColor = System.Drawing.Color.White;

            panel2.Visible = true;
            panel1.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
        }

        private void btnAllot_Click(object sender, EventArgs e)
        {
   
            pictureBox4.BackColor = System.Drawing.Color.Red;
            pictureBox5.BackColor = System.Drawing.Color.White;
            pictureBox3.BackColor = System.Drawing.Color.White;
            pictureBox6.BackColor = System.Drawing.Color.White;
            
            panel2.Visible = false;
            panel1.Visible = false;
            panel3.Visible = true;
            panel4.Visible = false;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            pictureBox6.BackColor = System.Drawing.Color.Red;
            pictureBox3.BackColor = System.Drawing.Color.White;
            pictureBox5.BackColor = System.Drawing.Color.White;
            pictureBox4.BackColor = System.Drawing.Color.White;

            panel2.Visible = false;
            panel1.Visible = false;
            panel3.Visible = false;
            panel4.Visible = true;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
