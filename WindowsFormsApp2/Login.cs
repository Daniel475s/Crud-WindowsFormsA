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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {

            if (txtusuario.Text == "ADMIN" && txtsenha.Text == "ADMIN")
            {
                Form1 f1 = new Form1();
                f1.Show();
            }

            else
            {
                MessageBox.Show("Dados de Login inválidos, Tente novamente!");
            }
            
        }
    }
}
