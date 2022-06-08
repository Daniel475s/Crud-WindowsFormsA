
namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cbbSexo = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblinicio = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.lbldtnasci = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblmsgsexo = new System.Windows.Forms.Label();
            this.lbldados = new System.Windows.Forms.Label();
            this.lbldatadeNascimento = new System.Windows.Forms.Label();
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.lblIdade = new System.Windows.Forms.Label();
            this.lblcxnome = new System.Windows.Forms.Label();
            this.lblcxtel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbbSexo
            // 
            this.cbbSexo.AllowDrop = true;
            this.cbbSexo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cbbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSexo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbbSexo.FormattingEnabled = true;
            this.cbbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cbbSexo.Location = new System.Drawing.Point(118, 159);
            this.cbbSexo.Name = "cbbSexo";
            this.cbbSexo.Size = new System.Drawing.Size(100, 21);
            this.cbbSexo.TabIndex = 1;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Azure;
            this.btnSalvar.Location = new System.Drawing.Point(122, 302);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(84, 29);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblinicio
            // 
            this.lblinicio.AutoSize = true;
            this.lblinicio.BackColor = System.Drawing.Color.DarkCyan;
            this.lblinicio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblinicio.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblinicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinicio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblinicio.Location = new System.Drawing.Point(273, 9);
            this.lblinicio.Name = "lblinicio";
            this.lblinicio.Size = new System.Drawing.Size(399, 18);
            this.lblinicio.TabIndex = 3;
            this.lblinicio.Text = "Preencha seus Dados nos Respectivos Campos abaixo:";
            // 
            // textBoxNome
            // 
            this.textBoxNome.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.textBoxNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxNome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxNome.Location = new System.Drawing.Point(119, 55);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(100, 20);
            this.textBoxNome.TabIndex = 4;
            this.textBoxNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxTel
            // 
            this.textBoxTel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxTel.Location = new System.Drawing.Point(118, 108);
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(100, 20);
            this.textBoxTel.TabIndex = 5;
            this.textBoxTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbldtnasci
            // 
            this.lbldtnasci.AutoSize = true;
            this.lbldtnasci.Location = new System.Drawing.Point(115, 215);
            this.lbldtnasci.Name = "lbldtnasci";
            this.lbldtnasci.Size = new System.Drawing.Size(104, 13);
            this.lbldtnasci.TabIndex = 6;
            this.lbldtnasci.Text = "Data de Nascimento";
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.BackColor = System.Drawing.Color.Azure;
            this.lblnome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblnome.Location = new System.Drawing.Point(488, 155);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(37, 15);
            this.lblnome.TabIndex = 7;
            this.lblnome.Text = "Nome";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.BackColor = System.Drawing.Color.Azure;
            this.lblTel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTel.Location = new System.Drawing.Point(488, 184);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(51, 15);
            this.lblTel.TabIndex = 8;
            this.lblTel.Text = "Telefone";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.BackColor = System.Drawing.Color.Azure;
            this.lblSexo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSexo.Location = new System.Drawing.Point(488, 215);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(33, 15);
            this.lblSexo.TabIndex = 9;
            this.lblSexo.Text = "Sexo\r\n";
            // 
            // lblmsgsexo
            // 
            this.lblmsgsexo.AutoSize = true;
            this.lblmsgsexo.Location = new System.Drawing.Point(151, 143);
            this.lblmsgsexo.Name = "lblmsgsexo";
            this.lblmsgsexo.Size = new System.Drawing.Size(31, 13);
            this.lblmsgsexo.TabIndex = 11;
            this.lblmsgsexo.Text = "Sexo";
            this.lblmsgsexo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbldados
            // 
            this.lbldados.AutoSize = true;
            this.lbldados.BackColor = System.Drawing.Color.DarkCyan;
            this.lbldados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbldados.Location = new System.Drawing.Point(488, 125);
            this.lbldados.Name = "lbldados";
            this.lbldados.Size = new System.Drawing.Size(78, 15);
            this.lbldados.TabIndex = 12;
            this.lbldados.Text = "Dados Salvos:";
            // 
            // lbldatadeNascimento
            // 
            this.lbldatadeNascimento.AutoSize = true;
            this.lbldatadeNascimento.BackColor = System.Drawing.Color.Azure;
            this.lbldatadeNascimento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbldatadeNascimento.Location = new System.Drawing.Point(488, 241);
            this.lbldatadeNascimento.Name = "lbldatadeNascimento";
            this.lbldatadeNascimento.Size = new System.Drawing.Size(108, 15);
            this.lbldatadeNascimento.TabIndex = 13;
            this.lbldatadeNascimento.Text = "Data De Nascimento";
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNascimento.Location = new System.Drawing.Point(122, 231);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(97, 20);
            this.dtpNascimento.TabIndex = 14;
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.BackColor = System.Drawing.Color.DarkCyan;
            this.lblIdade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIdade.Location = new System.Drawing.Point(485, 271);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(36, 15);
            this.lblIdade.TabIndex = 16;
            this.lblIdade.Text = "Idade";
            // 
            // lblcxnome
            // 
            this.lblcxnome.AutoSize = true;
            this.lblcxnome.Location = new System.Drawing.Point(151, 39);
            this.lblcxnome.Name = "lblcxnome";
            this.lblcxnome.Size = new System.Drawing.Size(35, 13);
            this.lblcxnome.TabIndex = 17;
            this.lblcxnome.Text = "Nome";
            // 
            // lblcxtel
            // 
            this.lblcxtel.AutoSize = true;
            this.lblcxtel.Location = new System.Drawing.Point(151, 92);
            this.lblcxtel.Name = "lblcxtel";
            this.lblcxtel.Size = new System.Drawing.Size(49, 13);
            this.lblcxtel.TabIndex = 18;
            this.lblcxtel.Text = "Telefone";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(868, 364);
            this.Controls.Add(this.lblcxtel);
            this.Controls.Add(this.lblcxnome);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.dtpNascimento);
            this.Controls.Add(this.lbldatadeNascimento);
            this.Controls.Add(this.lbldados);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.lbldtnasci);
            this.Controls.Add(this.textBoxTel);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.lblinicio);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblmsgsexo);
            this.Controls.Add(this.cbbSexo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbbSexo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblinicio;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxTel;
        private System.Windows.Forms.Label lbldtnasci;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblmsgsexo;
        private System.Windows.Forms.Label lbldados;
        private System.Windows.Forms.Label lbldatadeNascimento;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label lblcxnome;
        private System.Windows.Forms.Label lblcxtel;
    }
}

