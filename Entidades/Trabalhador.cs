using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContratoTrabalhadores.Entidades.Enums;
using System.Collections.Generic;

namespace ContratoTrabalhadores.Entidades
{
    class Trabalhador

    {
        public string Nome { get; set; }
        public NivelTrabalhador Nivel { get; set; }
        public double SalarioBase { get; set; }
        public Departamentos Departamentos { get; set; }
        public List<HoraContrato> Contratos { get; set; } = new List<HoraContrato>();

        public Trabalhador()
        {
        }

        public Trabalhador(string nome, NivelTrabalhador nivel, double salarioBase, Departamentos departamentos)
        {
            Nome = nome;
            Nivel = nivel;
            SalarioBase = salarioBase;
            Departamentos = departamentos;
        }

        public void AdicionarContrato(HoraContrato contrato)
        {
            Contratos.Add(contrato);
        }

        public void RemoveContrato(HoraContrato contrato)
        {
            Contratos.Add(contrato);
        }

        public double Ganho(int ano, int mes)
        {
            double soma = SalarioBase;
            foreach(HoraContrato contrato in Contratos)
            {
                if (contrato.Data.Year == ano && contrato.Data.Month == mes)
                {
                    soma += contrato.TotalValor();
                }
            }
            return soma;
        }
    }
}
