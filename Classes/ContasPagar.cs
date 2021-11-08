using PIM4.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM4.Classes
{
    class ContasPagar : AbsPropriedades
    {
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;
        public string inserirCp(double fornecedores, double impostos, double folhapg, double benficios, double alimentacao,
          double dividendos, double agua, double banco, double limpeza, double escritorio, double manut, double aquimoveis, double consultoria, double telefone)
        {
            cmd.CommandText = "insert into TB_Pagar (Fornecedores,Impostos, Folha_de_Pagamento, Beneficios, Alimentação, Dividendos, Água_Energia_Elétrica, Tarifas_Bancarias, Material_de_Limpeza, Material_de_Escritorio, Manutenção_e_Serviços, Aquisição_de_Bens_Moveis_e_Máq_e_Equip, Consultoria, Telefone_e_Internet) values (@fornecedores, @impostos, @folhapg, @benficios, @alimentacao, @dividendos, @agua, @banco, @limpeza, @escritorio, @manut, @aquimoveis, @consultoria, @telefone)";
            cmd.Parameters.AddWithValue("@fornecedores", fornecedores);
            cmd.Parameters.AddWithValue("@impostos", impostos);
            cmd.Parameters.AddWithValue("@folhapg", folhapg);
            cmd.Parameters.AddWithValue("@benficios", benficios);
            cmd.Parameters.AddWithValue("@alimentacao", alimentacao);
            cmd.Parameters.AddWithValue("@dividendos", dividendos);
            cmd.Parameters.AddWithValue("@agua", agua);
            cmd.Parameters.AddWithValue("@banco", banco);
            cmd.Parameters.AddWithValue("@limpeza", limpeza);
            cmd.Parameters.AddWithValue("@escritorio", escritorio);
            cmd.Parameters.AddWithValue("@manut", manut);
            cmd.Parameters.AddWithValue("@aquimoveis", aquimoveis);
            cmd.Parameters.AddWithValue("@consultoria", consultoria);
            cmd.Parameters.AddWithValue("@telefone", telefone);

            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
                con.desconection();
                this.Mensagem = "Valores registrados com sucesso";
            }
            catch (SqlException)
            {
                this.Mensagem = "Erro com banco de dados";
            }
            return this.Mensagem;
        }
        public string apagar()
        {
            cmd.CommandText = "delete from TB_Pagar";
            try
            {
                cmd.Connection = con.conectar();

                //ExecuteReader() usado quando tem retorno tipo select
                dr = cmd.ExecuteReader();
               
                this.Mensagem = "Tabela limpa com sucesso";
                con.desconection();
                dr.Close();
            }
            catch (SqlException)
            {
                this.Mensagem = "Erro com o Banco de dados!!";
            }
            return Mensagem;
        }
    }
}
