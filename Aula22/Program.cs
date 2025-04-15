using System;
using static System.Console;

class Aula22 {
    static void Main() {
        Write("Digite um número para ver sua tabuada: ");
        int user = int.Parse(ReadLine());
        
        int[] multiplicadores = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

        foreach(int v in multiplicadores) {
            WriteLine($"{user} x {v} = {user*v}");
        } 
    }
}
