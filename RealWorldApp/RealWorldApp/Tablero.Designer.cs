namespace RealWorldApp
{
    partial class Tablero
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvTablero = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewImageColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.lblMuertes = new System.Windows.Forms.Label();
            this.lblRes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.circularProgressBar1 = new RealWorldApp.CircularProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTablero
            // 
            this.dgvTablero.AllowUserToDeleteRows = false;
            this.dgvTablero.AllowUserToResizeColumns = false;
            this.dgvTablero.AllowUserToResizeRows = false;
            this.dgvTablero.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvTablero.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTablero.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvTablero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablero.ColumnHeadersVisible = false;
            this.dgvTablero.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvTablero.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvTablero.Location = new System.Drawing.Point(12, 30);
            this.dgvTablero.MultiSelect = false;
            this.dgvTablero.Name = "dgvTablero";
            this.dgvTablero.ReadOnly = true;
            this.dgvTablero.RowHeadersVisible = false;
            this.dgvTablero.RowTemplate.Height = 107;
            this.dgvTablero.Size = new System.Drawing.Size(540, 540);
            this.dgvTablero.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Column1";
            this.Column1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(848, 586);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Final";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.richTextBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.richTextBox1.ForeColor = System.Drawing.Color.Lime;
            this.richTextBox1.Location = new System.Drawing.Point(788, 223);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(229, 193);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // lblMuertes
            // 
            this.lblMuertes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMuertes.AutoSize = true;
            this.lblMuertes.BackColor = System.Drawing.Color.Black;
            this.lblMuertes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMuertes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMuertes.ForeColor = System.Drawing.Color.Lime;
            this.lblMuertes.Location = new System.Drawing.Point(592, 69);
            this.lblMuertes.Name = "lblMuertes";
            this.lblMuertes.Padding = new System.Windows.Forms.Padding(15);
            this.lblMuertes.Size = new System.Drawing.Size(53, 56);
            this.lblMuertes.TabIndex = 6;
            this.lblMuertes.Text = "0";
            // 
            // lblRes
            // 
            this.lblRes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRes.AutoSize = true;
            this.lblRes.BackColor = System.Drawing.Color.Black;
            this.lblRes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRes.ForeColor = System.Drawing.Color.Lime;
            this.lblRes.Location = new System.Drawing.Point(729, 67);
            this.lblRes.Name = "lblRes";
            this.lblRes.Padding = new System.Windows.Forms.Padding(15);
            this.lblRes.Size = new System.Drawing.Size(53, 56);
            this.lblRes.TabIndex = 7;
            this.lblRes.Text = "0";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(589, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "SMITH \r\nKILLS:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(708, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 30);
            this.label2.TabIndex = 9;
            this.label2.Text = "     NEO \r\nRESURRECTIONS:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(630, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Neo";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(630, 465);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Smith";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.progressBar1.Location = new System.Drawing.Point(788, 460);
            this.progressBar1.Maximum = 200;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.progressBar1.Size = new System.Drawing.Size(229, 23);
            this.progressBar1.Step = 0;
            this.progressBar1.TabIndex = 15;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Lime;
            this.label6.Location = new System.Drawing.Point(794, 437);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "Queue:";
            // 
            // backgroundWorker3
            // 
            this.backgroundWorker3.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker3_DoWork);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Lime;
            this.button2.Location = new System.Drawing.Point(942, 586);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.Image = global::RealWorldApp.Properties.Resources.smith;
            this.pictureBox2.Location = new System.Drawing.Point(576, 437);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::RealWorldApp.Properties.Resources.neo2;
            this.pictureBox1.Location = new System.Drawing.Point(576, 368);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox6.Location = new System.Drawing.Point(0, 0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(1029, 617);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 22;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox3.Location = new System.Drawing.Point(576, 511);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(630, 541);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 18);
            this.label5.TabIndex = 25;
            this.label5.Text = "Generics";
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.circularProgressBar1.BackColor = System.Drawing.SystemColors.Desktop;
            this.circularProgressBar1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.circularProgressBar1.ForeColor = System.Drawing.Color.Lime;
            this.circularProgressBar1.LineColor = System.Drawing.Color.Silver;
            this.circularProgressBar1.Location = new System.Drawing.Point(848, 9);
            this.circularProgressBar1.Maximum = ((long)(20));
            this.circularProgressBar1.MinimumSize = new System.Drawing.Size(100, 100);
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.ProgressColor1 = System.Drawing.Color.Lime;
            this.circularProgressBar1.ProgressColor2 = System.Drawing.Color.Aqua;
            this.circularProgressBar1.ProgressShape = RealWorldApp.CircularProgressBar._ProgressShape.Flat;
            this.circularProgressBar1.Size = new System.Drawing.Size(169, 169);
            this.circularProgressBar1.TabIndex = 5;
            this.circularProgressBar1.Text = "circularProgressBar1";
            this.circularProgressBar1.Value = ((long)(20));
            this.circularProgressBar1.Click += new System.EventHandler(this.circularProgressBar1_Click);
            // 
            // Tablero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 617);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.lblMuertes);
            this.Controls.Add(this.circularProgressBar1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvTablero);
            this.Controls.Add(this.pictureBox6);
            this.Name = "Tablero";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Tablero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTablero;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewImageColumn Column2;
        private System.Windows.Forms.DataGridViewImageColumn Column3;
        private System.Windows.Forms.DataGridViewImageColumn Column4;
        private System.Windows.Forms.DataGridViewImageColumn Column5;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private CircularProgressBar circularProgressBar1;
        private System.Windows.Forms.Label lblMuertes;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label5;
    }
}