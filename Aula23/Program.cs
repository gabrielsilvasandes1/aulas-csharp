using System;
using static System.Console;

class Aula22 {
    static void Main() {
        int[] vetor1 = new int[5];
        int[] vetor2 = new int[5];
        int[] vetor3 = new int[5];
        int[,] matriz = new int[2, 5] { {11, 22, 00, 44, 55}, {66, 77, 88, 99, 00} };

        Random random = new Random();
        for (int i = 0; i < vetor1.Length; i++) {
        vetor1[i] = random.Next(50);  // Preenche com números aleatórios de 0 a 49
    }

        foreach (int n in vetor1) {
        WriteLine(n);
        WriteLine("-------------------------------------------");
    }
        int procurado = 33;
        int pos = Array.BinarySearch(vetor1, procurado);
        WriteLine("Valor {0} está na posição {1}", procurado, pos);
        WriteLine("-------------------------------------------");

        Array.Copy(vetor1, vetor2, vetor1.Length);

        vetor1.CopyTo(vetor3, 0);

        long qtdeElementosVetor = vetor1.GetLongLength(0);
        WriteLine("Quantidade de elementos {0}", qtdeElementosVetor);
        WriteLine("-------------------------------------------");

        int MenorIndiceVetor = vetor1.GetLowerBound(0);
        int MaiorIndiceVetor = vetor1.GetUpperBound(0);

        int valor0 = Convert.ToInt32(vetor1.GetValue(3));
        WriteLine("Valor da posição 3 do vetor1: {0}", valor0);
        WriteLine("-------------------------------------------");

        int indice1 = Array.IndexOf(vetor1, 3);
        WriteLine("Indice do primeiro valor 3:{0}", indice1);
        WriteLine("-------------------------------------------");

        Array.Reverse(vetor1);
        foreach (int n in vetor1) {
        WriteLine(n);
        WriteLine("-------------------------------------------");
        }

        vetor2.SetValue(99, 0);

        Array.Sort(vetor1);
        Array.Sort(vetor2);
        Array.Sort(vetor3);

    }
}
