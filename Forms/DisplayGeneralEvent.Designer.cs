﻿namespace ICT365_Assignment1.Forms
{
    partial class DisplayGeneralEvent
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
            this.SuspendLayout();
            // 
            // CreateEventButton
            // 
            this.CreateEventButton.Click += new System.EventHandler(this.CreateEventButton_Click);
            // 
            // DisplayGeneralEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(256, 331);
            this.Name = "DisplayGeneralEvent";
            this.Load += new System.EventHandler(this.DisplayGeneralEvent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
