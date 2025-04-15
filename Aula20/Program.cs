using System;
using static System.Console;

class Aula20 {
    static void Main() {
        Write("Digite um número para ver sua tabuada: ");
        int user = int.Parse(ReadLine());
        int i = 1;
        while(i < 11) {
            WriteLine($"{user} x {i} = {i*user}");
            i++;
        }
    }
}
