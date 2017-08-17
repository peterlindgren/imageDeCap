﻿namespace imageDeCap
{
    partial class GifEditor
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
            this.components = new System.ComponentModel.Container();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.frameTimer = new System.Windows.Forms.Timer(this.components);
            this.startTrack = new System.Windows.Forms.TrackBar();
            this.endTrack = new System.Windows.Forms.TrackBar();
            this.toolsBox = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.sizeText = new System.Windows.Forms.Label();
            this.calcSizeButton = new System.Windows.Forms.Button();
            this.uploadButton = new System.Windows.Forms.Button();
            this.BackgroundTrack = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endTrack)).BeginInit();
            this.toolsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(12, 12);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(100, 50);
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            // 
            // frameTimer
            // 
            this.frameTimer.Enabled = true;
            this.frameTimer.Tick += new System.EventHandler(this.frameTimer_Tick);
            // 
            // startTrack
            // 
            this.startTrack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startTrack.AutoSize = false;
            this.startTrack.BackColor = System.Drawing.SystemColors.ControlDark;
            this.startTrack.Location = new System.Drawing.Point(12, 52);
            this.startTrack.Name = "startTrack";
            this.startTrack.Size = new System.Drawing.Size(658, 29);
            this.startTrack.TabIndex = 1;
            this.startTrack.ValueChanged += new System.EventHandler(this.startTrack_ValueChanged);
            this.startTrack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.startTrack_MouseDown);
            this.startTrack.MouseUp += new System.Windows.Forms.MouseEventHandler(this.startTrack_MouseUp);
            // 
            // endTrack
            // 
            this.endTrack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.endTrack.AutoSize = false;
            this.endTrack.BackColor = System.Drawing.SystemColors.ControlDark;
            this.endTrack.Location = new System.Drawing.Point(12, 52);
            this.endTrack.Name = "endTrack";
            this.endTrack.Size = new System.Drawing.Size(658, 29);
            this.endTrack.TabIndex = 2;
            this.endTrack.Value = 10;
            this.endTrack.ValueChanged += new System.EventHandler(this.endTrack_ValueChanged);
            this.endTrack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.endTrack_MouseDown);
            this.endTrack.MouseUp += new System.Windows.Forms.MouseEventHandler(this.endTrack_MouseUp);
            // 
            // toolsBox
            // 
            this.toolsBox.Controls.Add(this.label9);
            this.toolsBox.Controls.Add(this.numericUpDown1);
            this.toolsBox.Controls.Add(this.sizeText);
            this.toolsBox.Controls.Add(this.calcSizeButton);
            this.toolsBox.Controls.Add(this.uploadButton);
            this.toolsBox.Controls.Add(this.endTrack);
            this.toolsBox.Controls.Add(this.startTrack);
            this.toolsBox.Controls.Add(this.BackgroundTrack);
            this.toolsBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolsBox.Location = new System.Drawing.Point(0, 214);
            this.toolsBox.Name = "toolsBox";
            this.toolsBox.Size = new System.Drawing.Size(682, 93);
            this.toolsBox.TabIndex = 3;
            this.toolsBox.TabStop = false;
            this.toolsBox.Text = "Tools";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(502, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "GIF Recording frame-rate:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(505, 28);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 36;
            // 
            // sizeText
            // 
            this.sizeText.AutoSize = true;
            this.sizeText.Location = new System.Drawing.Point(215, 28);
            this.sizeText.Name = "sizeText";
            this.sizeText.Size = new System.Drawing.Size(52, 13);
            this.sizeText.TabIndex = 7;
            this.sizeText.Text = "File-Size: ";
            // 
            // calcSizeButton
            // 
            this.calcSizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.calcSizeButton.Location = new System.Drawing.Point(93, 23);
            this.calcSizeButton.Name = "calcSizeButton";
            this.calcSizeButton.Size = new System.Drawing.Size(116, 23);
            this.calcSizeButton.TabIndex = 6;
            this.calcSizeButton.Text = "Calculate File-Size";
            this.calcSizeButton.UseVisualStyleBackColor = true;
            this.calcSizeButton.Click += new System.EventHandler(this.calcSizeButton_Click);
            // 
            // uploadButton
            // 
            this.uploadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.uploadButton.Location = new System.Drawing.Point(12, 23);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(75, 23);
            this.uploadButton.TabIndex = 5;
            this.uploadButton.Text = "Upload";
            this.uploadButton.UseVisualStyleBackColor = true;
            this.uploadButton.Click += new System.EventHandler(this.uploadButton_Click);
            // 
            // BackgroundTrack
            // 
            this.BackgroundTrack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BackgroundTrack.AutoSize = false;
            this.BackgroundTrack.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundTrack.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.BackgroundTrack.Enabled = false;
            this.BackgroundTrack.Location = new System.Drawing.Point(12, 52);
            this.BackgroundTrack.Name = "BackgroundTrack";
            this.BackgroundTrack.Size = new System.Drawing.Size(658, 29);
            this.BackgroundTrack.TabIndex = 4;
            // 
            // GifEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 307);
            this.Controls.Add(this.toolsBox);
            this.Controls.Add(this.PictureBox);
            this.KeyPreview = true;
            this.Name = "GifEditor";
            this.Text = "GifEditor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GifEditor_FormClosing);
            this.Load += new System.EventHandler(this.GifEditor_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GifEditor_KeyDown);
            this.Resize += new System.EventHandler(this.GifEditor_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endTrack)).EndInit();
            this.toolsBox.ResumeLayout(false);
            this.toolsBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundTrack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Timer frameTimer;
        private System.Windows.Forms.TrackBar startTrack;
        private System.Windows.Forms.TrackBar endTrack;
        private System.Windows.Forms.GroupBox toolsBox;
        private System.Windows.Forms.TrackBar BackgroundTrack;
        private System.Windows.Forms.Button uploadButton;
        private System.Windows.Forms.Button calcSizeButton;
        private System.Windows.Forms.Label sizeText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}