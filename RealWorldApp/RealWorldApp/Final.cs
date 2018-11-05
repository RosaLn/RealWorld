using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealWorldApp
{
    public partial class Final : Form
    {
        private GifImage gifImage = null;
        private string filePath = @"..\..\matrixGif.gif";
        public Final()
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.button1.BackColor = Color.Transparent;
            gifImage = new GifImage(filePath);
            gifImage.ReverseAtEnd = false;
            pictureBox1.Image = gifImage.GetNextFrame();

        }

        private void Final_Load(object sender, EventArgs e)
        {
            CenterToParent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Luis is going to pass this work", "Congratulations!",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We are going to get a 10", "Congratulations!",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            this.Close();
        }
    }
}
