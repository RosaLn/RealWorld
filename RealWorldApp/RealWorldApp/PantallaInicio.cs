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
    public partial class PantallaInicio : Form
    {
        private GifImage gifImage = null;
        private string filePath = @"C:\Users\b14-09m\Documents\Visual Studio 2015\Projects\matrix2.gif";
        public PantallaInicio()
        {
            InitializeComponent();
            gifImage = new GifImage(filePath);
            gifImage.ReverseAtEnd = false; //dont reverse at end
            pictureBox1.Image = gifImage.GetNextFrame();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
