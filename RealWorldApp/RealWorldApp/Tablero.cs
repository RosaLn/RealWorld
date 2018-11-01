﻿using System;
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
        public Tablero()
        {
            InitializeComponent();
            Shown += new EventHandler(Form1_Shown);
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
            //backgroundWorker1.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker1_ProgressChanged);

            dgvTablero.Rows.Add();
            dgvTablero.Rows.Add();
            dgvTablero.Rows.Add();
            dgvTablero.Rows.Add();
            dgvTablero.Rows[4].Height = 90;
            matrix = new RealWorldApp.Matrix(5);
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
            do
            {
                if (time % 1 == 0)
                {
                    matrix.evaluatePercentages();
                    matrix.update(dgvTablero);
                }
                if (time % 2 == 0)
                {
                    matrix.actionSmith();
                    matrix.update(dgvTablero);
                }

                if (time % 5 == 0)
                {
                    matrix.neoAction();
                    matrix.update(dgvTablero);
                    matrix.swapNeo();
                    matrix.update(dgvTablero);
                }

                Thread.Sleep(1000);
                time += 1;

            } while (time <= max_time || matrix.isEnd());

        }

        private void Tablero_Load(object sender, EventArgs e)
        {

        }
    }
}
