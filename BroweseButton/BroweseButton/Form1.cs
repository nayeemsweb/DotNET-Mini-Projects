using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BroweseButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFD.InitialDirectory = "C:/Users/USER/Downloads";
            openFD.Title = "Insert an image";
            openFD.FileName = "";
            openFD.Filter = "JPG |*.jpg|JPEG|*.jpeg|PNG |*.png";

            if(openFD.ShowDialog() == DialogResult.Cancel)
            {
                MessageBox.Show("Operation Cancelled");
            }
            else
            {
                pictureBox1.Image = Image.FromFile(openFD.FileName);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
