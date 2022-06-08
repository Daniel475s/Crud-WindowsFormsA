using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (Validacampos(textBoxNome.Text,textBoxTel.Text))
            {
                lblnome.Text = textBoxNome.Text;
                lblTel.Text = textBoxTel.Text;
                lblSexo.Text = cbbSexo.Text;
                lbldatadeNascimento.Text = dtpNascimento.Text;
               
                lblIdade.Text = Convert.ToString( $" {CalculaIdade(dtpNascimento.Value)} anos");
                MessageBox.Show("Dados Salvos com Sucesso!");
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Dados de Nome e Telefone não informados!");
                MessageBox.Show("Tente Novamente.");
            }
            
        }

        private void LimparCampos()
        {
            textBoxNome.Text = string.Empty;
            textBoxTel.Text = string.Empty;
            cbbSexo.Text = cbbSexo.AccessibleDefaultActionDescription;
            dtpNascimento.Text = Convert.ToString(DateTime.Now);
        }

        private void btnCalcularIdade_Click(object sender, EventArgs e)
        {
            if (dtpNascimento.Value < DateTime.Now)
            {
                int resultado = CalculaIdade(dtpNascimento.Value);
                lblIdade.Text = $" {resultado} anos";
            }
            else
            {
                MessageBox.Show("Data Inválida");
            }
        }

        private  int CalculaIdade(DateTime dataNascimento)
        {
            int idade = DateTime.Now.Year - dataNascimento.Year;
            if (DateTime.Now.DayOfYear < dataNascimento.DayOfYear)
            {
                idade = idade - 1;
            }
            return idade;
        }

        public  bool Validacampos(string pnome, string ptelefone)
        {
            bool validacaoOk = true;

            if (pnome == "")
            {
                validacaoOk = false;
            }

            if (ptelefone == "")
            {
                validacaoOk = false;
            }

            return validacaoOk;
        }

    }
}
