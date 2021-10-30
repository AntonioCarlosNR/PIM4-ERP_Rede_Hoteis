using PIM4.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM4.Classes
{
    class AdmFunc : AbsPropriedades
    {
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;
        public AdmFunc() : base()
        {
        }
        public override void Buscar()
        {
            //comandos SQL se existem no BD 
            cmd.CommandText = "select * from TB_Reserva R left join TB_Check C on R.ID_Reserva = C.ID_Reserva";
            //cmd.Parameters.AddWithValue("@id_reserva", id_res);

            try
            {
                cmd.Connection = con.conectar();
                //ExecuteReader() usado quando tem retorno tipo select
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    Existe = true;
                    id_res = dr.GetInt32(0);
                    nomeHospede = dr.GetString(1);
                    qtdPessoas = dr.GetDecimal(2);
                    valor = dr.GetDecimal(3);
                    checkin = dr.GetDateTime(4);
                    checkout = dr.GetDateTime(5);
                    quarto = dr.GetDecimal(6);
                    id_cliente = dr.GetInt32(7);
                    statusReserva = dr.GetString(8);
                }
                con.desconection();
                dr.Close();
            }
            catch (SqlException)
            {
                this.Mensagem = "Erro com o Banco de dados!!";
            }
        }
    }
}
