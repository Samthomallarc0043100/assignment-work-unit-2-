using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assigment_work
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TabPage3_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void T_Click(object sender, EventArgs e)
        {
            

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                //read Height, Width and Length from textboxes
                double Length = double.Parse(textBox1.Text);
                double Height = double.Parse(textBox2.Text);
                double Width = double.Parse(textBox2.Text);
                //read Surface Area and Volume from labels 
                double SurfaceArea = 2.0 * (Length * Height + Length * Width + Height * Width);
                double Volume = Length * Height * Width;
                //run the code between these brackets 
                label1.Text = "Surface Area= " + SurfaceArea;
                label2.Text = "Volume= " + Volume;
            }
            catch
            {
                MessageBox.Show("error on input");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                //read radius from textboxes
                double radius = double.Parse(textBox1.Text);
                //read Surface Area and Volume from labels 
                double SurfaceArea = 4.0 * Math.PI * radius * radius;
                double Volume = 4.0 / 3.0 * Math.PI * radius * radius * radius;
                //run the code between these brackets 
                label1.Text = "Surface Area= " + SurfaceArea;
                label2.Text = "Volume= " + Volume;
            }
            catch
            {
                MessageBox.Show("error on input");
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                //read radius and hright from textboxes
                double radius = double.Parse(textBox1.Text);
                double height = double.Parse(textBox1.Text);
                //read Surface Area and Volume from labels 
                double SurfaceArea = Math.PI * radius * (radius + Math.Sqrt(height * height * radius * radius));
                double Volume = 1.0 / 3.0 * Math.PI * radius * radius * height;
                //run the code between these brackets 
                label1.Text = "Surface Area=" + SurfaceArea;
                label2.Text = "Volume= " + Volume;
            }
            catch
            {
                MessageBox.Show("error on input");
            }
        }

        private void TabPage_Click(object sender, EventArgs e)
        {

        }
    }
}
