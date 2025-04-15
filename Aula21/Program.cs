using System;
using static System.Console;

class Aula21 {
    static void Main() {
        Write("Digite um número para ver sua tabuada: ");
        int user = int.Parse(ReadLine());
        int i = 1;
    do {
        WriteLine($"{user} x {i} = {i*user}");
        i++;

    } while(i < 11);
    
    }
}
