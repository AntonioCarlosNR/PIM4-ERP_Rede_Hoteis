using PIM4.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM4.Classes
{
    class ContaReceber : AbsPropriedades
    {
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;

        public string BuscaReserva(int id_res)
        {
            //comandos SQL se existem no BD 
            cmd.CommandText = "select * from TB_Reserva where ID_Reserva = @id_reserva";
            cmd.Parameters.AddWithValue("@id_reserva", id_res);

            try
            {
                cmd.Connection = con.conectar();
                //ExecuteReader() usado quando tem retorno tipo select
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    this.Mensagem = "Reserva encontrada!!";
                }
                con.desconection();
                dr.Close();
            }
            catch (SqlException)
            {
                //this.Mensagem = "Erro com o Banco de dados!!";
            }
            return this.Mensagem;
        }

        public string confirmaPg(int id_res)
        {
            cmd.CommandText = "insert into TB_Receber (ID_Reserva, St_Pagamento) values (@id_res, 'Pago');";
            cmd.Parameters.AddWithValue("@id_res", id_res);
            //cmd.Parameters.AddWithValue("@St_Status", this.checkin_str);

            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
                con.desconection();
                this.Mensagem = "Pagamento registrado com sucesso";
            }
            catch (SqlException)
            {
                this.Mensagem = "Erro com banco de dados";
            }
            return this.Mensagem;
        }

    }
}
