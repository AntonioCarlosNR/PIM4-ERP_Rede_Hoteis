using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM4.Classes
{
    class Reserva
    {
        public bool Existe;
        public string Mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;
        public int id = 0;

        public int verificarUsuario(string nome)
        {
            //comandos SQL se existem no BD 
            cmd.CommandText = "select * from TB_Cliente where Nm_Cliente = @nome";
            cmd.Parameters.AddWithValue("@nome", nome);

            try
            {
                cmd.Connection = con.conectar();
                //ExecuteReader() usado quando tem retorno tipo select
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    Existe = true;
                    dr.Read();
                    id = dr.GetInt32(0);
                }
                con.desconection();
                dr.Close();
            }
            catch (SqlException)
            {
                this.Mensagem = "Erro com o Banco de dados!!";
            }
            return id;
        }
        public string agendar(string nome, int qtd, double valor, string checkin, string checkout, int quarto, int id)
        {
            //Existe = false;
            
            cmd.CommandText = "insert into TB_Reserva (Nm_Cliente,Qt_QuantidadeHospede,Vl_Total,Ck_CheckIn,Ck_Checkout,Nm_Quarto,ID_Cliente) values (@nome,@qtd,@valor,@checkin,@checkout,@quarto,@id);";
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@qtd", qtd);
            cmd.Parameters.AddWithValue("@valor", valor);
            cmd.Parameters.AddWithValue("@checkin", checkin);
            cmd.Parameters.AddWithValue("@checkout", checkout);
            cmd.Parameters.AddWithValue("@quarto", quarto);
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                cmd.Connection = con.conectar();
                //ExecuteNonQuery() usado para quando se tem um insert
                cmd.ExecuteNonQuery();
                con.desconection();
                this.Mensagem = "Agendado com sucesso!!!";
                Existe = true;
            }
            catch (SqlException)
            {
                this.Mensagem = "Erro com banco de dados";
            }

            return Mensagem;
        }
    }
}
