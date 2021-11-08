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
    }
}
