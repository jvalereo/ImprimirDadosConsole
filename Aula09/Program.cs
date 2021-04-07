using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09
{
    class Program
    {
        static void Main(string[] args)
        {
            //Treinamento - Aula09, inserindo dados , tipo string, concatenação
            //Jonas Valereo - Técnico em informática

            //Declarando as variaveis tipo string

            string nome = "Rafael";
            string sobrenome = "rodrigues";
            string idade = "20";
            string peso = "50.0";
            string cidade = "São Paulo";
            string estado = "São Paulo";
            string cep = "08092-104";
            string pais = "Brasil";

            //imprimir saida de dados no console, e método WhriteLine, concatenação

            Console.WriteLine("Meu nome: " + nome);
            Console.WriteLine("Meu sobrenome: " + sobrenome);
            Console.WriteLine("Minha idade: " + idade);
            Console.WriteLine("Meu peso: " + peso);
            Console.WriteLine("Cidade que moro: " + cidade);
            Console.WriteLine("Estado que moro: " + estado);
            Console.WriteLine("Meu cep: " + cep);
            Console.WriteLine("Pais que moro: " + pais);


            // saida do aplicativo console, método Readkey, Retorna o valor da tecla pressionada

            Console.ReadKey();

            //Fim do programa
        }
    }
}
