namespace Herramientas
{
    partial class Bosquejo
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
            this.pbBosquejo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBosquejo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBosquejo
            // 
            this.pbBosquejo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbBosquejo.Location = new System.Drawing.Point(0, 0);
            this.pbBosquejo.Name = "pbBosquejo";
            this.pbBosquejo.Size = new System.Drawing.Size(77, 59);
            this.pbBosquejo.TabIndex = 0;
            this.pbBosquejo.TabStop = false;
            this.pbBosquejo.Click += new System.EventHandler(this.pbBosquejo_Click);
            // 
            // Bosquejo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Controls.Add(this.pbBosquejo);
            this.Name = "Bosquejo";
            this.Size = new System.Drawing.Size(77, 59);
            ((System.ComponentModel.ISupportInitialize)(this.pbBosquejo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBosquejo;
    }
}
