using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_CRUD
{
    internal class FazerLogin
    {
        public string usuario { get; set; }
        public string senha { get; set; }

        public ConexaoBanco banco = new ConexaoBanco();

        public string verificarLogin()
        {
            this.banco.conectar();
            try
            {
                MySqlDataReader reader = this.banco.Query("SELECT * FROM login WHERE usuario='" + this.usuario + "' AND senha='" + this.senha + "'");

                if (reader.Read())
                {
                    return "aceito";
                }
                else
                {
                    return "negado";
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("ERRO ao fazer a verificação na base da dados");
            }
            this.banco.close();
            return "negado";
        }
    }
}
