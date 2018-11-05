using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealWorldApp
{
    public partial class Tablero : Form
    {
        private Matrix matrix;
        private GifImage gifImage = null;
        private string filePath = @"..\..\matrixGif.gif";
        private GifImage gifImage2 = null;
        private string filePath2 = @"..\..\generics.gif";
        public Tablero()
        {
            InitializeComponent();
            gifImage = new GifImage(filePath);
            gifImage.ReverseAtEnd = false;
            pictureBox6.Image = gifImage.GetNextFrame();
            gifImage2 = new GifImage(filePath2);
            gifImage2.ReverseAtEnd = false;
            pictureBox3.Image = gifImage2.GetNextFrame();
            Shown += new EventHandler(Form1_Shown);
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
            backgroundWorker1.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker1_ProgressChanged);

            lblRes.Parent = pictureBox6;
            lblMuertes.Parent = pictureBox6;
            label1.Parent = pictureBox6;
            label2.Parent = pictureBox6;
            label3.Parent = pictureBox6;
            label4.Parent = pictureBox6;
            

            dgvTablero.Rows.Add();
            dgvTablero.Rows.Add();
            dgvTablero.Rows.Add();
            dgvTablero.Rows.Add();
            dgvTablero.Rows[4].Height = 107;
            matrix = new RealWorldApp.Matrix(5);
            progressBar1.Value = 0;
        }


        void Form1_Shown(object sender, EventArgs e)
        {
            // Start the background worker
            backgroundWorker1.RunWorkerAsync();
        }

        void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            dgvTablero.ClearSelection();
            int max_time = 20;
            int time = 1;
            int cola = 0;
            do
            {
                if (time % 1 == 0)
                {
                    matrix.evaluatePercentages();
                    cola=matrix.update(dgvTablero);
                    CheckForIllegalCrossThreadCalls = false;
                    progressBar1.Value=200-cola;
                }
                if (time % 2 == 0)
                {
                    matrix.actionSmith(richTextBox1,lblMuertes);
                    cola=matrix.update(dgvTablero);
                    CheckForIllegalCrossThreadCalls = false;
                    progressBar1.Value = 200 - cola;
                }

                if (time % 5 == 0)
                {
                    matrix.neoAction(richTextBox1,lblRes);
                    cola=matrix.update(dgvTablero);
                    CheckForIllegalCrossThreadCalls = false;
                    progressBar1.Value = 200 - cola;
                    matrix.swapNeo(richTextBox1);
                    cola=matrix.update(dgvTablero);
                    progressBar1.Value = 200 - cola;
                }


                backgroundWorker1.ReportProgress(time);
                Thread.Sleep(1000);
                time += 1;

            } while (time <= max_time || matrix.isEnd());
            
            button1.Enabled = true;
            
        }

        void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // The progress percentage is a property of e
            circularProgressBar1.Value = e.ProgressPercentage;
        }

        private void Tablero_Load(object sender, EventArgs e)
        {
            CenterToParent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Final final = new RealWorldApp.Final();
            final.Show();
        }

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        

        private void backgroundWorker3_DoWork(object sender, DoWorkEventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}
