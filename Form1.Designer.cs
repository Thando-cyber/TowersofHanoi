﻿namespace TowersWindows
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        
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
            this.DiskCount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSolve = new System.Windows.Forms.Button();
            this.listMoves = new System.Windows.Forms.ListBox();
            this.lblMoves = new System.Windows.Forms.Label();
            this.lblCounter = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DiskCount)).BeginInit();
            this.SuspendLayout();
            // 
            // DiskCount
            // 
            this.DiskCount.Location = new System.Drawing.Point(114, 12);
            this.DiskCount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.DiskCount.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.DiskCount.Name = "DiskCount";
            this.DiskCount.Size = new System.Drawing.Size(52, 20);
            this.DiskCount.TabIndex = 0;
            this.DiskCount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.DiskCount.ValueChanged += new System.EventHandler(this.DiskCount_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of disks";
            // 
            // btnSolve
            // 
            this.btnSolve.Location = new System.Drawing.Point(185, 9);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(100, 23);
            this.btnSolve.TabIndex = 2;
            this.btnSolve.Text = "Solve";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.BtnSolve_Click);
            // 
            // listMoves
            // 
            this.listMoves.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listMoves.FormattingEnabled = true;
            this.listMoves.Location = new System.Drawing.Point(821, 41);
            this.listMoves.Name = "listMoves";
            this.listMoves.Size = new System.Drawing.Size(231, 407);
            this.listMoves.TabIndex = 4;
            // 
            // lblMoves
            // 
            this.lblMoves.AutoSize = true;
            this.lblMoves.Location = new System.Drawing.Point(818, 12);
            this.lblMoves.Name = "lblMoves";
            this.lblMoves.Size = new System.Drawing.Size(39, 13);
            this.lblMoves.TabIndex = 5;
            this.lblMoves.Text = "Moves";
            // 
            // lblCounter
            // 
            this.lblCounter.AutoSize = true;
            this.lblCounter.Location = new System.Drawing.Point(291, 14);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(153, 13);
            this.lblCounter.TabIndex = 6;
            this.lblCounter.Text = "Info: Best solution in {7} moves";
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(15, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 410);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 458);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.lblMoves);
            this.Controls.Add(this.listMoves);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DiskCount);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DiskCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown DiskCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.ListBox listMoves;
        private System.Windows.Forms.Label lblMoves;
        private System.Windows.Forms.Label lblCounter;
        private System.Windows.Forms.Panel panel1;
    }
}

