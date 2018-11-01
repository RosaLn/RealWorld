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
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewImageColumn();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.circularProgressBar1 = new RealWorldApp.CircularProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablero)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTablero
            // 
            this.dgvTablero.AllowUserToDeleteRows = false;
            this.dgvTablero.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTablero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablero.ColumnHeadersVisible = false;
            this.dgvTablero.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvTablero.Location = new System.Drawing.Point(12, 12);
            this.dgvTablero.Name = "dgvTablero";
            this.dgvTablero.ReadOnly = true;
            this.dgvTablero.RowHeadersVisible = false;
            this.dgvTablero.RowTemplate.Height = 90;
            this.dgvTablero.Size = new System.Drawing.Size(544, 453);
            this.dgvTablero.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(916, 487);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(822, 174);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(169, 226);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
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
            // circularProgressBar1
            // 
            this.circularProgressBar1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.circularProgressBar1.ForeColor = System.Drawing.Color.DimGray;
            this.circularProgressBar1.LineColor = System.Drawing.Color.Silver;
            this.circularProgressBar1.Location = new System.Drawing.Point(861, 12);
            this.circularProgressBar1.Maximum = ((long)(20));
            this.circularProgressBar1.MinimumSize = new System.Drawing.Size(100, 100);
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.ProgressColor1 = System.Drawing.Color.Orange;
            this.circularProgressBar1.ProgressColor2 = System.Drawing.Color.Orange;
            this.circularProgressBar1.ProgressShape = RealWorldApp.CircularProgressBar._ProgressShape.Flat;
            this.circularProgressBar1.Size = new System.Drawing.Size(130, 130);
            this.circularProgressBar1.TabIndex = 5;
            this.circularProgressBar1.Text = "circularProgressBar1";
            this.circularProgressBar1.Value = ((long)(20));
            this.circularProgressBar1.Click += new System.EventHandler(this.circularProgressBar1_Click);
            // 
            // Tablero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 522);
            this.Controls.Add(this.circularProgressBar1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvTablero);
            this.Name = "Tablero";
            this.Text = "Tablero";
            this.Load += new System.EventHandler(this.Tablero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablero)).EndInit();
            this.ResumeLayout(false);

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
    }
}