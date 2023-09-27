using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Application_CRUD
{
    public partial class Frm_login : Form
    {
        FazerLogin entrada = new FazerLogin();
        public Frm_login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt__TextChanged(object sender, EventArgs e)
        {

        }

        private void bnt_entrar_Click(object sender, EventArgs e)
        {
            entrada.usuario = txt_usuario.Text;
            entrada.senha = txt_senha.Text;

            if (entrada.verificarLogin() == "aceito")
            {
                Frm_menu form = new Frm_menu();
                this.Hide();      //esconde o formulario de login
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuário ou Senha Inválidos", "Erro ao Entrar no Sistema");
            }
        }

    }
}
