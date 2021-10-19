﻿using PIM4.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM4.Modelo
{
    public class Controle
    {
        public bool Existe;
        public int id;
        public string Mensagem ="";
        public int id_cliente;
        public string nome;
        public string endereco;
        public string email;
        public decimal fone;
        public decimal doc;
        public bool acessar(string login, string senha)
        {
            Login login1 = new Login();
            Existe = login1.verificarlogin(login,senha);
            if (!login1.Mensagem.Equals(""))
            {
                this.Mensagem = login1.Mensagem;
            }
            return Existe;
        }
        
        //Cadastrar Usuario
        public string cadastrar(string nome, string endereco,string email, string senha, string confsenha, long telefone, long cpf)
        {
            Login login1 = new Login();
            this.Mensagem = login1.cadastrar(nome, endereco,email,senha,confsenha,telefone,cpf);
            if (login1.Existe)
            {
                this.Existe = true;
            }
            return Mensagem;
        }
        public void IdCliente(int id_cli)
        {
            Login login = new Login();
            login.buscaIdusuario(id_cli);
            id_cliente = login.id ;
            nome = login.nome;
            endereco = login.endereco;
            email = login.email;
            fone = login.fone;
            doc = login.doc;
            if (login.Mensagem.Equals(""))
            {
                this.Mensagem = login.Mensagem;
            }
        }

        //Agendamento de quarto
        public int getIdCliente(string nome)
        {
            Reserva reserva = new Reserva();
            id = reserva.verificarUsuario(nome);
            if (reserva.Mensagem.Equals(""))
            {
                this.Mensagem = reserva.Mensagem;
            }
            return id;
        }
        public string agendar(string nome, int qtd, double valor, string checkin, string checkout, int quarto, int id)
        {
            Reserva reserva = new Reserva();
            this.Mensagem = reserva.agendar(nome, qtd, valor, checkin, checkout, quarto, id);
            if (reserva.Existe)
            {
                this.Existe = true;
            }

            return Mensagem;
        }

    }
}
