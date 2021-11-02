using PIM4.Modelo;
using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using PIM4.Classes;

namespace PIM4.Apresentacao.GestaoView.AdmModelo
{
    public partial class AdmFuncionario : Form
    {
        private Conexao conn;

        public AdmFuncionario()
        {
            InitializeComponent();
        }

        private void btnStaReserv_Click(object sender, EventArgs e)
        {
            conn = new Conexao();
        
            string strSql = "select * from TB_Reserva R left join TB_Check C on R.ID_Reserva = C.ID_Reserva";

            //cria o objeto command para executar a instruçao sql
            SqlCommand cmd = new SqlCommand(strSql, conn.conectar());


            //define o tipo do comando
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable reservas = new DataTable();

            da.Fill(reservas);

            dataGridViewAdm.DataSource = reservas;
        }

        private void btnListCli_Click(object sender, EventArgs e)
        {
            conn = new Conexao();

            string strSql = "select * from TB_Cliente";

            //cria o objeto command para executar a instruçao sql
            SqlCommand cmd = new SqlCommand(strSql, conn.conectar());


            //define o tipo do comando
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable reservas = new DataTable();

            da.Fill(reservas);

            dataGridViewAdm.DataSource = reservas;

        }

        private void btnListUser_Click(object sender, EventArgs e)
        {
            conn = new Conexao();

            string strSql = "select * from TB_Usuario";

            //cria o objeto command para executar a instruçao sql 
            SqlCommand cmd = new SqlCommand(strSql, conn.conectar());


            //define o tipo do comando
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable reservas = new DataTable();

            da.Fill(reservas);

            dataGridViewAdm.DataSource = reservas;
        }
    }
}
