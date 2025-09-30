namespace Herramientas
{
    partial class Fondos
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
            this.btnFondos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFondos
            // 
            this.btnFondos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFondos.BackColor = System.Drawing.Color.Transparent;
            this.btnFondos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFondos.FlatAppearance.BorderSize = 0;
            this.btnFondos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFondos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.btnFondos.ForeColor = System.Drawing.Color.White;
            this.btnFondos.Location = new System.Drawing.Point(0, 0);
            this.btnFondos.Name = "btnFondos";
            this.btnFondos.Size = new System.Drawing.Size(32, 40);
            this.btnFondos.TabIndex = 3;
            this.btnFondos.UseVisualStyleBackColor = false;
            this.btnFondos.Click += new System.EventHandler(this.btnFondos_Click);
            // 
            // Fondos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Controls.Add(this.btnFondos);
            this.Name = "Fondos";
            this.Size = new System.Drawing.Size(32, 40);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFondos;
    }
}
