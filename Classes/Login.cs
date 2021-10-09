using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM4.Classes
{
    class Login
    {
        public bool Existe;
        public string Mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;
        public bool verificarlogin(string login, string senha)
        {
            //comandos SQL se existem no BD 
            cmd.CommandText = "select * from TB_Cliente where Ds_email = @login and Ds_Senha =@senha";
            cmd.Parameters.AddWithValue("@login",login);
            cmd.Parameters.AddWithValue("@senha", senha);

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
            return Existe;
        }

        public string cadastrar(string nome, string endereco,string email, string senha, string confsenha, long telefone, long cpf)
        {
            Existe = false;

            //comandos para inserir no banco 
            if (senha.Equals(confsenha))
            {
                cmd.CommandText = "insert into TB_Cliente (Nm_Cliente,Ds_Endereco,Ds_email,Ds_Senha,Nm_telefone,Nm_Documento) values (@nome,@endereco,@email,@senha,@telefone,@cpf);";
                cmd.Parameters.AddWithValue("@nome",nome);
                cmd.Parameters.AddWithValue("@endereco",endereco);
                cmd.Parameters.AddWithValue("@email",email);
                cmd.Parameters.AddWithValue("@senha", senha);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                cmd.Parameters.AddWithValue("@cpf", cpf);

                try
                {
                    cmd.Connection = con.conectar();
                    //ExecuteNonQuery() usado para quando se tem um insert
                    cmd.ExecuteNonQuery();
                    con.desconection();
                    this.Mensagem = "Cadastrado com sucesso!!!";
                    Existe = true;
                }
                catch (SqlException)
                {
                    this.Mensagem = "Erro com banco de dados";
                }
            }
            else
            {
                this.Mensagem = "Senhas não correspondentes";
            }
                
            return Mensagem;
        }
    }
}
