namespace pryPeriottiSP1
{
    partial class frmLogin
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
            this.mrcIniciarSesion = new System.Windows.Forms.GroupBox();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdIngresar = new System.Windows.Forms.Button();
            this.lstModulo = new System.Windows.Forms.ComboBox();
            this.lblModulo = new System.Windows.Forms.Label();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.mrcIniciarSesion.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcIniciarSesion
            // 
            this.mrcIniciarSesion.Controls.Add(this.cmdCancelar);
            this.mrcIniciarSesion.Controls.Add(this.cmdIngresar);
            this.mrcIniciarSesion.Controls.Add(this.lstModulo);
            this.mrcIniciarSesion.Controls.Add(this.lblModulo);
            this.mrcIniciarSesion.Controls.Add(this.txtContrasena);
            this.mrcIniciarSesion.Controls.Add(this.lblContrasena);
            this.mrcIniciarSesion.Controls.Add(this.txtUsuario);
            this.mrcIniciarSesion.Controls.Add(this.lblUsuario);
            this.mrcIniciarSesion.Location = new System.Drawing.Point(12, 12);
            this.mrcIniciarSesion.Name = "mrcIniciarSesion";
            this.mrcIniciarSesion.Size = new System.Drawing.Size(384, 278);
            this.mrcIniciarSesion.TabIndex = 0;
            this.mrcIniciarSesion.TabStop = false;
            this.mrcIniciarSesion.Text = "Iniciar Sesion";
            this.mrcIniciarSesion.Enter += new System.EventHandler(this.mrcIniciarSesion_Enter);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.Location = new System.Drawing.Point(225, 183);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(143, 77);
            this.cmdCancelar.TabIndex = 7;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            // 
            // cmdIngresar
            // 
            this.cmdIngresar.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdIngresar.Location = new System.Drawing.Point(13, 183);
            this.cmdIngresar.Name = "cmdIngresar";
            this.cmdIngresar.Size = new System.Drawing.Size(147, 77);
            this.cmdIngresar.TabIndex = 6;
            this.cmdIngresar.Text = "Ingresar";
            this.cmdIngresar.UseVisualStyleBackColor = true;
            this.cmdIngresar.Click += new System.EventHandler(this.cmdIngresar_Click);
            // 
            // lstModulo
            // 
            this.lstModulo.FormattingEnabled = true;
            this.lstModulo.Items.AddRange(new object[] {
            "ADM",
            "SIST",
            "COM",
            "VTA"});
            this.lstModulo.Location = new System.Drawing.Point(178, 139);
            this.lstModulo.Name = "lstModulo";
            this.lstModulo.Size = new System.Drawing.Size(190, 21);
            this.lstModulo.TabIndex = 5;
            this.lstModulo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblModulo
            // 
            this.lblModulo.AutoSize = true;
            this.lblModulo.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModulo.Location = new System.Drawing.Point(6, 121);
            this.lblModulo.Name = "lblModulo";
            this.lblModulo.Size = new System.Drawing.Size(123, 40);
            this.lblModulo.TabIndex = 4;
            this.lblModulo.Text = "Módulo:";
            // 
            // txtContrasena
            // 
            this.txtContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena.HideSelection = false;
            this.txtContrasena.Location = new System.Drawing.Point(178, 84);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '#';
            this.txtContrasena.Size = new System.Drawing.Size(190, 26);
            this.txtContrasena.TabIndex = 3;
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasena.Location = new System.Drawing.Point(6, 66);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(167, 40);
            this.lblContrasena.TabIndex = 2;
            this.lblContrasena.Text = "Contraseña:";
            this.lblContrasena.Click += new System.EventHandler(this.lblContrasena_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtUsuario.Location = new System.Drawing.Point(145, 35);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(223, 26);
            this.txtUsuario.TabIndex = 1;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(9, 22);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(120, 40);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario:";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 300);
            this.Controls.Add(this.mrcIniciarSesion);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.mrcIniciarSesion.ResumeLayout(false);
            this.mrcIniciarSesion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcIniciarSesion;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblModulo;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.ComboBox lstModulo;
        private System.Windows.Forms.Button cmdIngresar;
        private System.Windows.Forms.Button cmdCancelar;
    }
}