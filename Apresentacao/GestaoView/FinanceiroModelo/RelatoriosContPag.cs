using PIM4.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM4.Apresentacao.GestaoView.FinanceiroModelo
{
    public partial class RelatoriosContPag : Form
    {
        private Conexao conn;
        public RelatoriosContPag()
        {
            InitializeComponent();
        }

        private void btnTodosLancamentos_Click(object sender, EventArgs e)
        {
            conn = new Conexao();

            string strSql = "select * from TB_Pagar";

            //cria o objeto command para executar a instruçao sql
            SqlCommand cmd = new SqlCommand(strSql, conn.conectar());


            //define o tipo do comando
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable contareceb = new DataTable();

            da.Fill(contareceb);

            dataGridViewCP.DataSource = contareceb;
        }

        private void btnOutrosServi_Click(object sender, EventArgs e)
        {
            conn = new Conexao();

            string strSql = "select Fornecedores, Consultoria, Impostos, Dividendos from TB_Pagar";

            //cria o objeto command para executar a instruçao sql
            SqlCommand cmd = new SqlCommand(strSql, conn.conectar());


            //define o tipo do comando
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable contareceb = new DataTable();

            da.Fill(contareceb);

            dataGridViewCP.DataSource = contareceb;
        }

        private void btnTotalOutrosServic_Click(object sender, EventArgs e)
        {
            conn = new Conexao();

            string strSql = "select sum (Fornecedores) as Total_Fornecedores, sum (Consultoria) as Total_Consultoria, sum (Impostos) as Total_Impostos, sum (Dividendos) as Total_Dividendos  from TB_Pagar";

            //cria o objeto command para executar a instruçao sql
            SqlCommand cmd = new SqlCommand(strSql, conn.conectar());


            //define o tipo do comando
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable contareceb = new DataTable();

            da.Fill(contareceb);

            dataGridViewCP.DataSource = contareceb;
        }

        private void btnRh_Click(object sender, EventArgs e)
        {
            conn = new Conexao();

            string strSql = "select Folha_de_Pagamento, Beneficios from TB_Pagar";

            //cria o objeto command para executar a instruçao sql
            SqlCommand cmd = new SqlCommand(strSql, conn.conectar());


            //define o tipo do comando
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable contareceb = new DataTable();

            da.Fill(contareceb);

            dataGridViewCP.DataSource = contareceb;
        }

        private void btnGastosDiversos_Click(object sender, EventArgs e)
        {
            conn = new Conexao();

            string strSql = "select Alimentação, Tarifas_Bancarias, Material_de_Limpeza, Material_de_Escritorio, Telefone_e_Internet, Aquisição_de_Bens_Moveis_e_Máq_e_Equip  from TB_Pagar;";

            //cria o objeto command para executar a instruçao sql
            SqlCommand cmd = new SqlCommand(strSql, conn.conectar());


            //define o tipo do comando
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable contareceb = new DataTable();

            da.Fill(contareceb);

            dataGridViewCP.DataSource = contareceb;
        }

        private void btnTotalGastosDiversos_Click(object sender, EventArgs e)
        {
            conn = new Conexao();

            string strSql = "select sum (Alimentação) as Total_Alimentação, sum (Tarifas_Bancarias) as Total_Tarifas_Bancarias, sum (Material_de_Limpeza) as Total_Material_de_Limpeza, sum (Material_de_Escritorio) as Total_Material_de_Escritorio, sum (Telefone_e_Internet) as Total_Telefone_e_Internet, sum (Aquisição_de_Bens_Moveis_e_Máq_e_Equip) as Total_Aquisição_de_Bens_Moveis_e_Máq_e_Equip  from TB_Pagar;";

            //cria o objeto command para executar a instruçao sql
            SqlCommand cmd = new SqlCommand(strSql, conn.conectar());


            //define o tipo do comando
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable contareceb = new DataTable();

            da.Fill(contareceb);

            dataGridViewCP.DataSource = contareceb;
        }

        private void btnGastosFaciFixos_Click(object sender, EventArgs e)
        {
            conn = new Conexao();

            string strSql = "select Água_Energia_Elétrica, Manutenção_e_Serviços  from TB_Pagar";

            //cria o objeto command para executar a instruçao sql
            SqlCommand cmd = new SqlCommand(strSql, conn.conectar());


            //define o tipo do comando
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable contareceb = new DataTable();

            da.Fill(contareceb);

            dataGridViewCP.DataSource = contareceb;
        }

        private void btnTotalGastosFacilitiesfixos_Click(object sender, EventArgs e)
        {
            conn = new Conexao();

            string strSql = "select sum (Água_Energia_Elétrica) as Total_Água_Energia_Elétrica, sum (Manutenção_e_Serviços) as Total_Manutenção_e_Serviços from TB_Pagar;";

            //cria o objeto command para executar a instruçao sql
            SqlCommand cmd = new SqlCommand(strSql, conn.conectar());


            //define o tipo do comando
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable contareceb = new DataTable();

            da.Fill(contareceb);

            dataGridViewCP.DataSource = contareceb;
        }

        private void btnTotalRh_Click(object sender, EventArgs e)
        {
            conn = new Conexao();

            string strSql = "select sum (Folha_de_Pagamento) as Total_Folha_de_Pagamento, sum (Beneficios) as Total_Beneficios from TB_Pagar;";

            //cria o objeto command para executar a instruçao sql
            SqlCommand cmd = new SqlCommand(strSql, conn.conectar());


            //define o tipo do comando
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable contareceb = new DataTable();

            da.Fill(contareceb);

            dataGridViewCP.DataSource = contareceb;
        }
    }
}
