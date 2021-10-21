using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM4.Modelo
{
    public abstract class AbsPropriedades
    {
        //Reserva
        public int id_res { get; set; }
        public string nomeHospede { get; set; }
        public decimal qtdPessoas { get; set; }
        public decimal quarto { get; set; }
        public decimal valor { get; set; }
        public DateTime checkin { get; set; }
        public DateTime checkout { get; set; }
    }
}
