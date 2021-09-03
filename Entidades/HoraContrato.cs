using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratoTrabalhadores.Entidades
{
    class HoraContrato
    {
        public DateTime Data { get; set; }
        public double ValorHora { get; set; }
        public int Hora { get; set; }

        public HoraContrato()
        {
        }

        public HoraContrato(DateTime data, double valorHora, int hora)
        {
            Data = data;
            ValorHora = valorHora;
            Hora = hora;
        }

        public double TotalValor()
        {
            return Hora * ValorHora;
        }
    }
}
