using System;
using System.Collections.Generic;

namespace Algorithms
{
    class E004
    {
        //Diagonal Difference
        //https://www.hackerrank.com/challenges/diagonal-difference/problem

        public static void Input()
        {
            Random rand = new Random();
            var tamanhoMatriz = rand.Next(2, 10);
            Console.WriteLine("tamanhoMatriz: " + tamanhoMatriz);

            int cont1 = 0;
            List<List<int>> linhaMatriz = new();

            while (cont1<tamanhoMatriz)
            {
                int cont2 = 0;
                List<int> colunaMatriz = new();
                while (cont2 < tamanhoMatriz)
                {
                    var itemMatriz = rand.Next(-100, 100);
                    colunaMatriz.Add(itemMatriz);
                    cont2++;
                }

                int linha = cont1 + 1;
                Console.WriteLine("Linha "+ linha +" matriz: " + string.Join(",  ", colunaMatriz));

                linhaMatriz.Add(colunaMatriz);
                cont1++;
            }

            DiagonalDifference(linhaMatriz);

        }


        public static int DiagonalDifference(List<List<int>> matriz)
        {
            var somaPrimeiraDiagonal = CalculaPrimeiraDiagonal(matriz);
            Console.WriteLine("Soma 1ª diagonal: " + string.Join(", ", somaPrimeiraDiagonal));
            var somaSegundaDiagonal = CalculaSegundaDiagonal(matriz);
            Console.WriteLine("Soma 2ª diagonal: " + string.Join(", ", somaSegundaDiagonal));
            int moduloDiferenca = Math.Abs(somaSegundaDiagonal - somaPrimeiraDiagonal);
            Console.WriteLine("Módulo da Diferenca: " + string.Join(", ", moduloDiferenca));
            return moduloDiferenca;
        }

        private static int CalculaPrimeiraDiagonal(List<List<int>> matriz)
        {
            int sum = 0;
            for (int i = 0; i < matriz.Count; i++)
            {
                sum += matriz[i][i];
            }
            return sum;
        }

        private static int CalculaSegundaDiagonal(List<List<int>> matriz)
        {
            int sum = 0;
            for (int i = 0; i < matriz.Count; i++)
            {
                sum += matriz[i][matriz.Count - 1 - i];
            }
            return sum;
        }
    }
}
