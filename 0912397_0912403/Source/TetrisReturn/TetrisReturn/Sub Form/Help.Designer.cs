﻿namespace TetrisReturn
{
    partial class Help
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
            this.showInformation2 = new TetrisReturn.ShowInformation();
            this.showInformation1 = new TetrisReturn.ShowInformation();
            this.SuspendLayout();
            // 
            // showInformation2
            // 
            this.showInformation2.BackColor = System.Drawing.Color.Transparent;
            this.showInformation2.CInfo = System.Drawing.Color.White;
            this.showInformation2.CStroke = System.Drawing.Color.Black;
            this.showInformation2.CText = System.Drawing.Color.White;
            this.showInformation2.FInfo = new System.Drawing.Font("Arial", 15F);
            this.showInformation2.FTitle = new System.Drawing.Font("Arial", 15F);
            this.showInformation2.ImgBack = null;
            this.showInformation2.IWidth = 2;
            this.showInformation2.Location = new System.Drawing.Point(33, 128);
            this.showInformation2.Name = "showInformation2";
            this.showInformation2.SInfo = null;
            this.showInformation2.Size = new System.Drawing.Size(725, 314);
            this.showInformation2.STitle = null;
            this.showInformation2.TabIndex = 1;
            // 
            // showInformation1
            // 
            this.showInformation1.BackColor = System.Drawing.Color.Transparent;
            this.showInformation1.CInfo = System.Drawing.Color.White;
            this.showInformation1.CStroke = System.Drawing.Color.Black;
            this.showInformation1.CText = System.Drawing.Color.White;
            this.showInformation1.FInfo = new System.Drawing.Font("Arial", 15F);
            this.showInformation1.FTitle = new System.Drawing.Font("Arial", 15F);
            this.showInformation1.ImgBack = null;
            this.showInformation1.IWidth = 2;
            this.showInformation1.Location = new System.Drawing.Point(134, 12);
            this.showInformation1.Name = "showInformation1";
            this.showInformation1.SInfo = null;
            this.showInformation1.Size = new System.Drawing.Size(455, 82);
            this.showInformation1.STitle = "Help";
            this.showInformation1.TabIndex = 0;
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.showInformation2);
            this.Controls.Add(this.showInformation1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Help";
            this.ShowInTaskbar = false;
            this.Text = "Help";
            this.Shown += new System.EventHandler(this.Help_Shown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Help_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Help_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private ShowInformation showInformation1;
        private ShowInformation showInformation2;
    }
}