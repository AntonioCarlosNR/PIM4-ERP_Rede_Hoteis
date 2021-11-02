using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM4.Modelo
{
    public abstract class AbsPropriedades
    {
        public bool Existe { get; set; }
        public string Mensagem { get; set; }
        //Cadastro
        public int id_cliente { get; set; }
        public string nome { get; set; }
        public string endereco { get; set; }
        public string email { get; set; }
        public decimal fone { get; set; }
        public decimal doc { get; set; }
        public string senha { get; set; }
        //Reserva
        public int id_res { get; set; }
        public string nomeHospede { get; set; }
        public decimal qtdPessoas { get; set; }
        public decimal quarto { get; set; }
        public decimal valor { get; set; }
        public DateTime checkin { get; set; }
        public DateTime checkout { get; set; }
        public string checkin_str { get; set; }
        public string checkout_str { get; set; }
        public string statusReserva { get; set; }
        //AdmFunc 
     
        protected AbsPropriedades()
        {
            this.Buscar();
        }

        //construtor e metodo para iniciar em tela de chekin/out
        protected AbsPropriedades(int id_res)
        {
            this.id_res = id_res;
            this.Buscar();
        }

        protected AbsPropriedades(int id_res, string checkin_str)
        {
            this.id_res = id_res;
            if (checkin_str == "in")
            {
                this.checkin_str = checkin_str;
                this.Inserir();        
            }
            else
            {
                this.checkout_str = checkin_str;
                this.Atualizar();
            }
        }

        public virtual void Buscar() { }
        public virtual void Inserir() { }
        public virtual void Atualizar() { }

    }
    
}
