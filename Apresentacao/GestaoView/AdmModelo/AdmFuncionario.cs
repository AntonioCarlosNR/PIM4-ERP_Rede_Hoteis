using PIM4.Modelo;
using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PIM4.Apresentacao.GestaoView.AdmModelo
{
    public partial class AdmFuncionario : Form
    {
        
        public AdmFuncionario()
        {
            InitializeComponent();
        }

        private void btnStaReserv_Click(object sender, EventArgs e)
        {
          //corrigir isso urgenteeeeeee!!!!!!!!!!!
          // usar MVC nesse DataGridView
            string strProvider = @"Data Source=.\SQLEXPRESS;Initial Catalog=PIM;Integrated Security=True";
        
            string strSql = "select * from TB_Reserva R left join TB_Check C on R.ID_Reserva = C.ID_Reserva";

            //cria a conexão com o banco de dados
            SqlConnection conn = new SqlConnection(strProvider);

            //cria o objeto command para executar a instruçao sql
            SqlCommand cmd = new SqlCommand(strSql, conn);

            conn.Open();

            //define o tipo do comando
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable clientes = new DataTable();

            da.Fill(clientes);

            dataGridViewAdm.DataSource = clientes;
        }
    }
}
