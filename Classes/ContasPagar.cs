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
        public string BuscarPlanilha()
        {
            cmd.CommandText = "select sum (Fornecedores) as Total_Fornecedores, sum (Consultoria) as Total_Consultoria, sum (Impostos) as Total_Impostos, sum (Dividendos) as Total_Dividendos,sum(Folha_de_Pagamento) as Total_Folha_de_Pagamento, sum(Beneficios) as Total_Beneficios,sum(Alimentação) as Total_Alimentação, sum(Tarifas_Bancarias) as Total_Tarifas_Bancarias, sum(Material_de_Limpeza) as Total_Material_de_Limpeza, sum(Material_de_Escritorio) as Total_Material_de_Escritorio,sum(Água_Energia_Elétrica) as Total_Água_Energia_Elétrica, sum(Manutenção_e_Serviços) as Total_Manutenção_e_Serviços, sum(Telefone_e_Internet) as Total_Telefone_e_Internet, sum(Aquisição_de_Bens_Moveis_e_Máq_e_Equip) as Total_Aquisição_de_Bens_Moveis_e_Máq_e_Equip from TB_Pagar";
            try
            {
                cmd.Connection = con.conectar();

                //ExecuteReader() usado quando tem retorno tipo select
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    Existe = true;
                    dr.Read();
                    Fornecedores = dr.GetDecimal(0);
                    Impostos = dr.GetDecimal(2);
                    Folha_de_Pagamento = dr.GetDecimal(4);
                    Beneficios = dr.GetDecimal(5);
                    Alimentacao = dr.GetDecimal(6);
                    Dividendos = dr.GetDecimal(3);
                    Agua_Energia_Eletrica = dr.GetDecimal(10);
                    Tarifas_Bancarias = dr.GetDecimal(7);
                    Material_de_Limpeza = dr.GetDecimal(8);
                    Material_de_Escritorio = dr.GetDecimal(9);
                    Manutencao_e_Servicos = dr.GetDecimal(11);
                    Aquisicao_de_Bens_Moveis_e_Maq_e_Equip = dr.GetDecimal(13);
                    Consultoria = dr.GetDecimal(1);
                    Telefone_e_Internet = dr.GetDecimal(12);

                }
                this.Mensagem = "Dados encontrados com sucesso";
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
