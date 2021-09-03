using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratoTrabalhadores.Entidades
{
    class Departamentos
    {
        public string Nome { get; set; }

        public Departamentos()
        {
        }

        public Departamentos(string nome)
        {
            Nome = nome;
        }
    }
}
