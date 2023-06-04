namespace pryPeriottiSP1
{
    partial class frmPrincipal
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
            this.lblSintepart = new System.Windows.Forms.Label();
            this.pbLogoAuto = new System.Windows.Forms.PictureBox();
            this.cmdLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoAuto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSintepart
            // 
            this.lblSintepart.AutoSize = true;
            this.lblSintepart.Font = new System.Drawing.Font("Nirmala UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSintepart.Location = new System.Drawing.Point(12, 168);
            this.lblSintepart.Name = "lblSintepart";
            this.lblSintepart.Size = new System.Drawing.Size(449, 86);
            this.lblSintepart.TabIndex = 0;
            this.lblSintepart.Text = "Sintepast-SRL";
            // 
            // pbLogoAuto
            // 
            this.pbLogoAuto.Image = global::pryPeriottiSP1.Properties.Resources.pngegg;
            this.pbLogoAuto.Location = new System.Drawing.Point(141, 12);
            this.pbLogoAuto.Name = "pbLogoAuto";
            this.pbLogoAuto.Size = new System.Drawing.Size(176, 162);
            this.pbLogoAuto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogoAuto.TabIndex = 1;
            this.pbLogoAuto.TabStop = false;
            // 
            // cmdLogin
            // 
            this.cmdLogin.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLogin.Location = new System.Drawing.Point(151, 257);
            this.cmdLogin.Name = "cmdLogin";
            this.cmdLogin.Size = new System.Drawing.Size(157, 65);
            this.cmdLogin.TabIndex = 2;
            this.cmdLogin.Text = "Login";
            this.cmdLogin.UseVisualStyleBackColor = true;
            this.cmdLogin.Click += new System.EventHandler(this.cmdLogin_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(473, 346);
            this.Controls.Add(this.cmdLogin);
            this.Controls.Add(this.pbLogoAuto);
            this.Controls.Add(this.lblSintepart);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoAuto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSintepart;
        private System.Windows.Forms.PictureBox pbLogoAuto;
        private System.Windows.Forms.Button cmdLogin;
    }
}