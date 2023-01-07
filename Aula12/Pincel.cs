using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace Aula12
{
   class Pincel
    {

        //declarando os atributos, campos,variaveis da class pincel

       public string cor;
       public float tamanho;
       public double valor;
       public string marca;
      

        //declarando os métodos da classe do pincel

        public void Escreve()
        {
            Console.WriteLine("Pincel escrever");
        }

        public void Pintar()
        {
            Console.WriteLine("Pincel Pintando");
        }

        public void Desenhar()
        {

            Console.WriteLine("Pincel desenhando");
        }

        public void MudarCor()
        {
            Console.WriteLine("Pincel Mundando a cor");
        }

        public void TrocarValor()
        {
            Console.WriteLine("Pincel troncado o valor");
        }

        //fim da classe pincel 

    }
}
