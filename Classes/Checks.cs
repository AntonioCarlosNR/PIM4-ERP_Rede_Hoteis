using PIM4.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM4.Classes
{
    class Checks : AbsPropriedades
    {
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;
        public Checks(int id_res) : base(id_res)
        {
        }
        public Checks(int id_res, string checkin_str) : base(id_res, checkin_str)
        {
        }

        public override void Buscar()
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
                    Existe = true;
                }
                con.desconection();
                dr.Close();
            }
            catch (SqlException)
            {
                this.Mensagem = "Erro com o Banco de dados!!";
            }
        }

        public override void Inserir()
        {
            cmd.CommandText = "insert into TB_Check (ID_Reserva, St_Status) values (@id_res, 'in');";
            cmd.Parameters.AddWithValue("@id_res", this.id_res);
            //cmd.Parameters.AddWithValue("@St_Status", this.checkin_str);

            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
                con.desconection();
                this.Mensagem = "Dados inseridos com sucesso";
                this.Existe = true;
            }
            catch (SqlException)
            {
                this.Mensagem = "Erro com banco de dados";
            }
        }

        public override void Atualizar()
        {
            //corrigir o checkout
            cmd.CommandText = "update TB_Check set St_Status = 'out' where ID_Reserva = @id_res;";
            cmd.Parameters.AddWithValue("@id_res", this.id_res);
            //cmd.Parameters.AddWithValue("@St_Status", this.checkin_str);

            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
                con.desconection();
                this.Mensagem = "Dados atualizados com sucesso";
                this.Existe = true;
            }
            catch (SqlException)
            {
                this.Mensagem = "Erro com banco de dados";
            }
        }
    }
}
