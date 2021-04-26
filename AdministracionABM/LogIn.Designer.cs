namespace AdministracionABM
{
    partial class LogIn
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Entrarbtn = new System.Windows.Forms.Button();
            this.registrarbtn = new System.Windows.Forms.Button();
            this.rememberckbx = new System.Windows.Forms.CheckBox();
            this.usuariotxt = new System.Windows.Forms.TextBox();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // Entrarbtn
            // 
            this.Entrarbtn.AccessibleName = "";
            this.Entrarbtn.Location = new System.Drawing.Point(95, 86);
            this.Entrarbtn.Name = "Entrarbtn";
            this.Entrarbtn.Size = new System.Drawing.Size(75, 23);
            this.Entrarbtn.TabIndex = 2;
            this.Entrarbtn.Text = "Entrar";
            this.Entrarbtn.UseVisualStyleBackColor = true;
            this.Entrarbtn.Click += new System.EventHandler(this.Entrarbtn_Click);
            // 
            // registrarbtn
            // 
            this.registrarbtn.Location = new System.Drawing.Point(176, 86);
            this.registrarbtn.Name = "registrarbtn";
            this.registrarbtn.Size = new System.Drawing.Size(75, 23);
            this.registrarbtn.TabIndex = 3;
            this.registrarbtn.Text = "Registrarse";
            this.registrarbtn.UseVisualStyleBackColor = true;
            this.registrarbtn.Click += new System.EventHandler(this.registrarbtn_Click);
            // 
            // rememberckbx
            // 
            this.rememberckbx.AutoSize = true;
            this.rememberckbx.Location = new System.Drawing.Point(66, 63);
            this.rememberckbx.Name = "rememberckbx";
            this.rememberckbx.Size = new System.Drawing.Size(94, 17);
            this.rememberckbx.TabIndex = 4;
            this.rememberckbx.Text = "Remember me";
            this.rememberckbx.UseVisualStyleBackColor = true;
            // 
            // usuariotxt
            // 
            this.usuariotxt.Location = new System.Drawing.Point(66, 9);
            this.usuariotxt.Name = "usuariotxt";
            this.usuariotxt.Size = new System.Drawing.Size(185, 20);
            this.usuariotxt.TabIndex = 5;
            // 
            // passwordtxt
            // 
            this.passwordtxt.Location = new System.Drawing.Point(66, 37);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.Size = new System.Drawing.Size(185, 20);
            this.passwordtxt.TabIndex = 6;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 119);
            this.Controls.Add(this.passwordtxt);
            this.Controls.Add(this.usuariotxt);
            this.Controls.Add(this.rememberckbx);
            this.Controls.Add(this.registrarbtn);
            this.Controls.Add(this.Entrarbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LogIn";
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Entrarbtn;
        private System.Windows.Forms.Button registrarbtn;
        private System.Windows.Forms.CheckBox rememberckbx;
        private System.Windows.Forms.TextBox usuariotxt;
        private System.Windows.Forms.TextBox passwordtxt;
    }
}

