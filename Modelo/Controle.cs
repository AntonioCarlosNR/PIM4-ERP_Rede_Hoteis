using PIM4.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM4.Modelo
{
    public class Controle: AbsPropriedades
    {

        public int id;

        private AbsPropriedades AbsProp;
        public Controle():base()
        {
            this.Mensagem = "";
        }
        //Login
        #region
        public bool acessar(string login, string senha)
        {
            this.Mensagem = ""; 
            Login login1 = new Login();
            Existe = login1.verificarlogin(login,senha);
            if (!Mensagem.Equals(""))
            {
                this.Mensagem = login1.Mensagem;
            }
            return Existe;
        }
        #endregion

        //Cadastrar Usuario
        #region
        public bool verificarCadastro(string login, string tabela)
        {
            Login login1 = new Login();

            Existe = login1.verificarCadastro(login, tabela);
            if (!Mensagem.Equals(""))
            {
                this.Mensagem = login1.Mensagem;
            }
            return Existe;
        }

        public string cadastrar(string nome, string endereco,string email, string senha, string confsenha, long telefone, long cpf, string tabela)
        {
            Login login1 = new Login();

            this.Mensagem = login1.cadastrar(nome, endereco,email,senha,confsenha,telefone,cpf,tabela);
            if (login1.Existe)
            {
                this.Existe = true;
            }
            return Mensagem;
        }
        public void IdCliente(int id_cli, string tabela)
        {

            Login login = new Login();
            login.buscaIdusuario(id_cli, tabela);
            id_cliente = login.id ;
            nome = login.nome;
            endereco = login.endereco;
            email = login.email;
            fone = login.fone;
            doc = login.doc;
            senha = login.senha;
            if (Mensagem.Equals(""))
            {
                this.Mensagem = login.Mensagem;
            }
        }
        public bool apagar(int id, string tabela)
        {
            this.Mensagem = "";
            Login login = new Login();
            Existe = login.apagar(id, tabela);
            if (!Mensagem.Equals(""))
            {
                this.Mensagem = login.Mensagem;
            }
            return Existe;
        }

        public string atualizar(string nome, string endereco, string email, string senha, string confsenha, long telefone, long cpf, int id, string tabela)
        {
            Login login = new Login();
            this.Mensagem = login.atualizar(nome, endereco, email, senha, confsenha, telefone, cpf, id, tabela);
            if (login.Existe)
            {
                this.Existe = true;
            }
            return Mensagem;
        }
        #endregion

        //Agendamento de quarto
        #region
        public int getIdCliente(string nome)
        {
            Reserva reserva = new Reserva();
            id = reserva.verificarUsuario(nome);
            
            return id;
        }
        public string agendar(string nome, int qtd, double valor, string checkin, string checkout, int quarto, int id)
        {
            DateTime ckout = Convert.ToDateTime(checkout);
            DateTime ckin = Convert.ToDateTime(checkin);
            DateTime now = DateTime.Now;

            if(ckout >= ckin && ckout >= now && ckin >= now)
            {
                Reserva reserva = new Reserva();
                this.Mensagem = reserva.agendar(nome, qtd, valor, checkin, checkout, quarto, id);
                if (reserva.Existe)
                {
                    this.Existe = true;
                }
            }
            else
            {
                this.Mensagem = "Datas invalidas";
            }            

            return Mensagem;
        }

        public void buscardados(int id_reserva)
        {
            Reserva reserva = new Reserva();
            reserva.buscaIdreserva(id_reserva);
            
            nomeHospede = reserva.nomeHospede;
            qtdPessoas = reserva.qtdPessoas;
            quarto = reserva.quarto;
            valor = reserva.valor;
            id = reserva.id;
            checkin = reserva.checkin;
            checkout = reserva.checkout;
            if (Mensagem.Equals(""))
            {
                this.Mensagem = reserva.Mensagem;
            }
        }
        public bool apagar(int id)
        {
            Reserva reserva = new Reserva();
            Existe = reserva.apagar(id);
            if (!reserva.Mensagem.Equals(""))
            {
                this.Mensagem = reserva.Mensagem;
            }
            return Existe;
        }

        public string atualizarReserva(string nome, int qtd, double valor, string checkin, string checkout, int quarto, int id, int id_reserva)
        {
            Reserva reserva = new Reserva();
            this.Mensagem = reserva.atualizar(nome, qtd, valor, checkin, checkout, quarto, id, id_reserva);
            if (reserva.Existe)
            {
                this.Existe = true;
            }
            return Mensagem;
        }
        #endregion

        //CheckIn CheckOut
        #region
        public Controle(int id_res) : base(id_res) { }
        public Controle(int id_res, string checkin_str) : base(id_res, checkin_str) { }
        public override void Buscar()
        {
            AbsProp = new Checks(this.id_res);
            if (AbsProp.Existe)
            {
                AbsProp.Mensagem = "Reserva existente favor realizar o ChekIn";
            }
            else
            {
                AbsProp.Mensagem = "Dados da Reserva não encontrados";
            }

            this.Mensagem = AbsProp.Mensagem;
        }

        public override void Inserir()
        {
            AbsProp = new Checks(id_res, checkin_str);

            if (AbsProp.Existe)
            {
                AbsProp.Mensagem = "ChekIn realizado com sucesso";
            }
            else
            {
                AbsProp.Mensagem = "Não foi possivel realizar o checkin";
            }

            this.Mensagem = AbsProp.Mensagem;
        }
        public override void Atualizar()
        {
            AbsProp = new Checks(id_res, checkout_str);

            if (AbsProp.Existe)
            {
                AbsProp.Mensagem = "ChekOut realizado com sucesso";
            }
            else
            {
                AbsProp.Mensagem = "Não foi possivel realizar o checkOut";
            }

            this.Mensagem = AbsProp.Mensagem;
        }
        #endregion

        //Conta a Receber
        #region
        public string BuscarContReceb(int id_res)
        {
            ContaReceber contaReceber = new ContaReceber();
            this.Mensagem = contaReceber.BuscaReserva(id_res);
            if(this.Mensagem != "")
            {
                this.Mensagem = contaReceber.confirmaPg(id_res);
            }
            else
            {
                this.Mensagem = "Erro com o Banco de dados!!";
            }
            return this.Mensagem; 
        }
        #endregion

        //Contas a Pagar
        #region
        public string inserirCp(double fornecedores, double impostos, double folhapg, double benficios, double alimentacao,
          double dividendos, double agua, double banco, double limpeza, double escritorio, double manut, double aquimoveis, double consultoria, double telefone)
        {
            ContasPagar contasPagar = new ContasPagar();
            this.Mensagem = contasPagar.inserirCp(fornecedores, impostos, folhapg, benficios, alimentacao, dividendos, agua, banco,
                limpeza, escritorio, manut, aquimoveis, consultoria, telefone);

            return this.Mensagem;
        }

        public string apagar()
        {
            ContasPagar contasPagar = new ContasPagar();
            this.Mensagem = contasPagar.apagar();

            return this.Mensagem;
        }

        //gerar PDF 
        public void GerarPDF()
        {
            CriaPDF pdf = new CriaPDF();
            pdf.GeraPDF();
            if (pdf.doc.Equals(""))
            {
                this.Mensagem = "Não foi possivel gerar o PDF";
            }
            else
            {
                this.Mensagem = "PDF Gerado com sucesso!!!";
            }
        }
        #endregion
    }
}
