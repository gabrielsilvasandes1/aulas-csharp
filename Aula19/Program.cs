using System;
using static System.Console;

class Aula19 {
    static void Main() {
        Write("Digite um número para ver sua tabuada: ");
        int num = int.Parse(ReadLine());

        for (int i = 0; i < 11; i++) {
            WriteLine($"{num} x {i} = {num*i}");
        }

        int[,] num2 = new int[2,2]{{10 , 20}, {30 , 40}};

        /* Matriz 1
         0  1  
       0 10 20
       1 30 40 
        */

        for (int linha = 0; linha < num2.GetLength(0); linha++) {
            for (int coluna = 0; coluna < num2.GetLength(1); coluna++) {
                WriteLine($"Na posição [{linha},{coluna}] temos o valor {num2[linha, coluna]}");
            }
        }
    } 
}

