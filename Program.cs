using System;
using System.Globalization;
using ContratoTrabalhadores.Entidades.Enums;
using ContratoTrabalhadores.Entidades;

namespace ContratoTrabalhadores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome do departamento: ");
            string nomeDepartaento = Console.ReadLine();
            Console.WriteLine("Digite os dados do trabalhador");
            Console.Write("Nome: ");
            string nomeTrabalhador = Console.ReadLine();
            Console.Write("Nível (Junior / Medio / Senior): ");
            NivelTrabalhador nivel = Enum.Parse<NivelTrabalhador>(Console.ReadLine());
            Console.Write("Salário Base: ");
            double salarioBase = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Departamentos departamento = new Departamentos(nomeDepartaento);

            Trabalhador trabalhador = new Trabalhador(nomeTrabalhador, nivel, salarioBase, departamento);

            Console.Write("Quantos contratos para esse trabalhador: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                Console.Write($"Entre com os dados do contrato  {i} ");
                Console.Write("Data (DD/MM/AAAA): ");
                DateTime data = DateTime.Parse(Console.ReadLine());
                Console.Write("Valor por hora: ");
                double valorHora = double.Parse(Console.ReadLine());
                Console.Write("Quantas horas tem o contrato: ");
                int horasConrtrato = int.Parse(Console.ReadLine());

                HoraContrato contrato = new HoraContrato(data, valorHora, horasConrtrato);

                trabalhador.AdicionarContrato(contrato);

            }
                Console.WriteLine();
                Console.Write("Entre com mês e ano para calcular os ganhos (MM/AAAA): ");
                string mesAno = Console.ReadLine();
                int mes = int.Parse(mesAno.Substring(0, 2));
                int ano = int.Parse(mesAno.Substring(3));

                Console.WriteLine("Name" + trabalhador.Nome);
                Console.WriteLine("Departamento: " + trabalhador.Departamentos);
                Console.WriteLine("Ganhos em " + mesAno + ": " + trabalhador.Ganho(ano, mes));


            
        }
    }
}
