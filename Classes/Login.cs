using PIM4.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM4.Classes
{
    class Login: AbsPropriedades
    {
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;
        public int id;

        public bool verificarlogin(string login, string senha)
        {
            //comandos SQL se existem no BD 
            cmd.CommandText = "select * from TB_Usuario where Ds_email = @login and Ds_Senha =@senha";
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

        public string cadastrar(string nome, string endereco,string email, string senha, string confsenha, long telefone, long cpf, string tabela)
        {
            Existe = false;

            //comandos para inserir no banco 
            if (senha.Equals(confsenha))
            {
                switch (tabela)
                {
                    case "TB_Cliente":
                        cmd.CommandText = "insert into TB_Cliente (Nm_Cliente,Ds_Endereco,Ds_email,Ds_Senha,Nm_telefone,Nm_Documento) values (@nome,@endereco,@email,@senha,@telefone,@cpf);";
                        break;
                    case "TB_Usuario":
                        cmd.CommandText = "insert into TB_Usuario (Nm_Usuario,Ds_Endereco,Ds_email,Ds_Senha,Nm_telefone,Nm_Documento) values (@nome,@endereco,@email,@senha,@telefone,@cpf);";
                        break;
                } 
                //cmd.CommandText = "insert into TB_Cliente (Nm_Cliente,Ds_Endereco,Ds_email,Ds_Senha,Nm_telefone,Nm_Documento) values (@nome,@endereco,@email,@senha,@telefone,@cpf);";
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
        public void buscaIdusuario(int id_cli, string tabela)
        {
            switch (tabela)
            {
                case "TB_Cliente":
                    cmd.CommandText = "select * from TB_Cliente where ID_Cliente = @id";
                    break;
                case "TB_Usuario":
                    cmd.CommandText = "select * from TB_Usuario where ID_Usuario = @id";
                    break;
            }
            //comandos SQL se existem no BD 
            cmd.Parameters.AddWithValue("@id", id_cli);

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
                    nome = dr.GetString(1);
                    endereco = dr.GetString(2);
                    email = dr.GetString(3);
                    fone = dr.GetDecimal(4);
                    doc = dr.GetDecimal(5);
                    senha = dr.GetString(6);

                }
                con.desconection();
                dr.Close();
            }
            catch (SqlException)
            {
                this.Mensagem = "Erro com o Banco de dados!!";
            }
        }
        public bool apagar(int id, string tabela)
        {
            switch (tabela)
            {
                case "TB_Cliente":
                    cmd.CommandText = "delete from TB_Cliente where ID_Cliente = @id";
                    break;
                case "TB_Usuario":
                    cmd.CommandText = "delete from TB_Usuario where ID_Usuario = @id";
                    break;
            }
            //comandos SQL se existem no BD 
            cmd.Parameters.AddWithValue("@id", id);

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
        public string atualizar(string nome, string endereco, string email, string senha, string confsenha, long telefone, long cpf, int id, string tabela)
        {
            Existe = false;

            //comandos para inserir no banco 
            if (senha.Equals(confsenha))
            {
                switch (tabela)
                {
                    case "TB_Cliente":
                        cmd.CommandText = "update TB_Cliente set Nm_Cliente = @nome ,Ds_Endereco = @endereco ,Nm_telefone = @telefone ,Ds_email = @email ,Nm_Documento = @cpf, Ds_Senha = @senha where ID_Cliente = @id";
                        break;
                    case "TB_Usuario":
                        cmd.CommandText = "update TB_Usuario set Nm_Usuario = @nome ,Ds_Endereco = @endereco ,Nm_telefone = @telefone ,Ds_email = @email ,Nm_Documento = @cpf, Ds_Senha = @senha where ID_Usuario = @id";
                        break;
                }
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@endereco", endereco);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@senha", senha);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                cmd.Parameters.AddWithValue("@cpf", cpf);
                cmd.Parameters.AddWithValue("@id", id);

                try
                {
                    cmd.Connection = con.conectar();
                    //ExecuteNonQuery() usado para quando se tem um insert
                    cmd.ExecuteNonQuery();
                    con.desconection();
                    this.Mensagem = "Dados atualizados com sucesso!!!";
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
