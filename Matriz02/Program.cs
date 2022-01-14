using System;

namespace Matriz02
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] a = new double[4, 4];
            double soma = 0, media;
            Console.WriteLine("Cálculos - Matriz\n\n");

            for (int linha = 0; linha < 4; linha++)
            {
                for (int coluna = 0; coluna < 4; coluna++)
                {
                    Console.WriteLine("Digite o elemento [{0},{1}] da matriz.", linha.ToString(), coluna.ToString());
                    a[linha, coluna] = Convert.ToDouble(Console.ReadLine());
                }
            }
            for (int coluna = 0; coluna < 4; coluna++)
            {
                soma += a[0, coluna];

            }
            Console.WriteLine("Soma da linha 0: {0}", soma.ToString());

            //média linha1
            soma = 0;
            for (int coluna = 0; coluna < 4; coluna++ )
            {
                soma += a[1, coluna];
            }
            media = soma / 4;

            Console.WriteLine("Média da linha 1: {0}", media.ToString());

            //multiplicação

            Console.WriteLine("Multiplicação das linhas 2 e 3 pelos elementos da mesma coluna");
            for (int coluna = 0; coluna < 4; coluna++)
            {
                double multip;
                multip = a[2, coluna] * a[3, coluna];
                Console.WriteLine("Multiplicação da coluna[{0}]={1}", coluna.ToString(), multip.ToString());

            }
            
            
        }




    }
}
