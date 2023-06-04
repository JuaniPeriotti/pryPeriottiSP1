namespace pryPeriottiSP1
{
    partial class frmBienvenido
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
            this.pbLogoAuto = new System.Windows.Forms.PictureBox();
            this.lblSintepart = new System.Windows.Forms.Label();
            this.lblBienvenido = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoAuto)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogoAuto
            // 
            this.pbLogoAuto.Image = global::pryPeriottiSP1.Properties.Resources.pngegg;
            this.pbLogoAuto.Location = new System.Drawing.Point(211, 12);
            this.pbLogoAuto.Name = "pbLogoAuto";
            this.pbLogoAuto.Size = new System.Drawing.Size(176, 162);
            this.pbLogoAuto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogoAuto.TabIndex = 2;
            this.pbLogoAuto.TabStop = false;
            // 
            // lblSintepart
            // 
            this.lblSintepart.AutoSize = true;
            this.lblSintepart.Font = new System.Drawing.Font("Nirmala UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSintepart.Location = new System.Drawing.Point(69, 177);
            this.lblSintepart.Name = "lblSintepart";
            this.lblSintepart.Size = new System.Drawing.Size(449, 86);
            this.lblSintepart.TabIndex = 3;
            this.lblSintepart.Text = "Sintepast-SRL";
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Nirmala UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.Location = new System.Drawing.Point(69, 297);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(448, 86);
            this.lblBienvenido.TabIndex = 4;
            this.lblBienvenido.Text = "BIENVENIDO!";
            // 
            // frmBienvenido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(582, 450);
            this.Controls.Add(this.lblBienvenido);
            this.Controls.Add(this.lblSintepart);
            this.Controls.Add(this.pbLogoAuto);
            this.Name = "frmBienvenido";
            this.Text = "frmBienvenido";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoAuto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogoAuto;
        private System.Windows.Forms.Label lblSintepart;
        private System.Windows.Forms.Label lblBienvenido;
    }
}