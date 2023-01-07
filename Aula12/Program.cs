using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace Aula12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Treinamento - Aula 12, Programação Orientação ao Objeto
            //Inserindo dados, tipo string float, double Datetime
            //Jonas Valereo - Técnico em Informática 

            //declarando , chamando a classe Pincel

            Pincel pincel = new Pincel();
          

            pincel.cor = "Azul";
            pincel.marca = "Bic";
            pincel.tamanho = 1.2f;
            pincel.valor = 2.0;

            //imprimir saida de dados no console, e método WhriteLine, concatenação

            Console.WriteLine("Cor do pincel: " + pincel.cor);
            Console.WriteLine("Marca do pincel: " + pincel.marca);
            Console.WriteLine("Tamanho do pincel: " + pincel.tamanho);
            Console.WriteLine("Valor do pincel: " + pincel.valor);
            Console.WriteLine(" ");
            Console.WriteLine("----------------------------");

            //imprimir saida de dados métodos

            pincel.Escreve();
            pincel.Pintar();
            pincel.Desenhar();
            pincel.MudarCor();
            pincel.TrocarValor();

            //saida do aplicativo console, método Readkey, Retorna o valor da tecla pressionada

            Console.ReadKey();

            //fim do programa
            
        }
    }
}
