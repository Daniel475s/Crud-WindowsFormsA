
namespace WindowsFormsApp2
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.lbluser = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtusuario
            // 
            this.txtusuario.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtusuario.Location = new System.Drawing.Point(331, 124);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(100, 20);
            this.txtusuario.TabIndex = 0;
            // 
            // txtsenha
            // 
            this.txtsenha.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtsenha.Location = new System.Drawing.Point(331, 176);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.PasswordChar = '*';
            this.txtsenha.Size = new System.Drawing.Size(100, 20);
            this.txtsenha.TabIndex = 1;
            // 
            // btnlogin
            // 
            this.btnlogin.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnlogin.Location = new System.Drawing.Point(341, 236);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(75, 23);
            this.btnlogin.TabIndex = 2;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.BackColor = System.Drawing.SystemColors.Info;
            this.lbluser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbluser.Location = new System.Drawing.Point(365, 108);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(31, 15);
            this.lbluser.TabIndex = 3;
            this.lbluser.Text = "User";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.BackColor = System.Drawing.SystemColors.Info;
            this.lblpassword.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblpassword.Location = new System.Drawing.Point(354, 160);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(55, 15);
            this.lblpassword.TabIndex = 4;
            this.lblpassword.Text = "Password";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lbluser);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.txtusuario);
            this.ForeColor = System.Drawing.Color.Coral;
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.Label lblpassword;
    }
}