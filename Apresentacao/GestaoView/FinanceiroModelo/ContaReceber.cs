using PIM4.Classes;
using PIM4.Modelo;
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
    public partial class ContaReceber : Form
    {
        private Conexao conn;
        public ContaReceber()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.BuscarContReceb(Convert.ToInt32(txtId_res.Text));
            lblStatus.Text = controle.Mensagem;
        }

        private void btnListReserva_Click(object sender, EventArgs e)
        {
            conn = new Conexao();

            string strSql = "select R.ID_Reserva, R.Nm_Cliente, R.Vl_Total, C.St_Status, B.St_Pagamento from TB_Reserva R left join TB_Check C on R.ID_Reserva = C.ID_Reserva left join TB_Receber B on B.ID_Reserva = R.ID_Reserva";

            //cria o objeto command para executar a instruçao sql
            SqlCommand cmd = new SqlCommand(strSql, conn.conectar());


            //define o tipo do comando
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable contareceb = new DataTable();

            da.Fill(contareceb);

            dataGridViewContReceb.DataSource = contareceb;

        }

        private void btnListPagos_Click(object sender, EventArgs e)
        {
            conn = new Conexao();

            string strSql = "select R.ID_Reserva, R.Nm_Cliente, R.Vl_Total, C.St_Status, B.St_Pagamento from TB_Reserva R left join TB_Check C on R.ID_Reserva = C.ID_Reserva left join TB_Receber B on B.ID_Reserva = R.ID_Reserva where B.St_Pagamento = 'Pago'";

            //cria o objeto command para executar a instruçao sql
            SqlCommand cmd = new SqlCommand(strSql, conn.conectar());


            //define o tipo do comando
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable contareceb = new DataTable();

            da.Fill(contareceb);

            dataGridViewContReceb.DataSource = contareceb;
        }

        private void btnListaDevedores_Click(object sender, EventArgs e)
        {
            conn = new Conexao();

            string strSql = "select R.ID_Reserva, R.Nm_Cliente, R.Vl_Total, C.St_Status, B.St_Pagamento from TB_Reserva R left join TB_Check C on R.ID_Reserva = C.ID_Reserva left join TB_Receber B on B.ID_Reserva = R.ID_Reserva where B.St_Pagamento is NULL";

            //cria o objeto command para executar a instruçao sql
            SqlCommand cmd = new SqlCommand(strSql, conn.conectar());


            //define o tipo do comando
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable contareceb = new DataTable();

            da.Fill(contareceb);

            dataGridViewContReceb.DataSource = contareceb;
        }

        private void btnTotPago_Click(object sender, EventArgs e)
        {
            conn = new Conexao();

            string strSql = "select sum (Vl_Total) as Valor_total_Pago from TB_Reserva R left join TB_Check C on R.ID_Reserva = C.ID_Reserva left join TB_Receber B on B.ID_Reserva = R.ID_Reserva where B.St_Pagamento = 'Pago'";

            //cria o objeto command para executar a instruçao sql
            SqlCommand cmd = new SqlCommand(strSql, conn.conectar());


            //define o tipo do comando
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable contareceb = new DataTable();

            da.Fill(contareceb);

            dataGridViewContReceb.DataSource = contareceb;
        }

        private void btnEmAberto_Click(object sender, EventArgs e)
        {
            conn = new Conexao();

            string strSql = "select sum (Vl_Total) as Valor_total_em_Aberto from TB_Reserva R left join TB_Check C on R.ID_Reserva = C.ID_Reserva left join TB_Receber B on B.ID_Reserva = R.ID_Reserva where B.St_Pagamento is NULL";

            //cria o objeto command para executar a instruçao sql
            SqlCommand cmd = new SqlCommand(strSql, conn.conectar());


            //define o tipo do comando
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable contareceb = new DataTable();

            da.Fill(contareceb);

            dataGridViewContReceb.DataSource = contareceb;
        }
    }
}
