﻿using System;
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
        private string filePath = @"..\..\matrix.gif";
        public PantallaInicio()
        {
            InitializeComponent();
            gifImage = new GifImage(filePath);
            gifImage.ReverseAtEnd = false; 
            pictureBox1.Image = gifImage.GetNextFrame();
            System.Media.SoundPlayer sp = new System.Media.SoundPlayer("..\\..\\Matrix-Cancion1.wav");
            sp.Play();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Tablero tablero = new RealWorldApp.Tablero();
            tablero.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PantallaInicio_Load(object sender, EventArgs e)
        {
            CenterToParent();
        }

        
    }
}
