﻿namespace Herramientas
{
    partial class Lapiz
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLapiz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLapiz
            // 
            this.btnLapiz.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLapiz.BackColor = System.Drawing.Color.Transparent;
            this.btnLapiz.BackgroundImage = global::Herramientas.Properties.Resources.pencil;
            this.btnLapiz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLapiz.FlatAppearance.BorderSize = 0;
            this.btnLapiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLapiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.btnLapiz.ForeColor = System.Drawing.Color.White;
            this.btnLapiz.Location = new System.Drawing.Point(0, 0);
            this.btnLapiz.Name = "btnLapiz";
            this.btnLapiz.Size = new System.Drawing.Size(50, 50);
            this.btnLapiz.TabIndex = 2;
            this.btnLapiz.UseVisualStyleBackColor = false;
            this.btnLapiz.Click += new System.EventHandler(this.btnLapiz_Click);
            // 
            // Lapiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Controls.Add(this.btnLapiz);
            this.Name = "Lapiz";
            this.Size = new System.Drawing.Size(50, 50);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLapiz;
    }
}
