using System;
using static System.Console;

class Aula12 {

    static void Main() {
        int nota1, nota2;

        WriteLine("Digite a primeira nota: ");
        nota1 = int.Parse(ReadLine());

        WriteLine("Digite a segunda nota: ");
        nota2 = int.Parse(ReadLine());
        
        float media = (nota1 + nota2) / 2;
        if (media <= 4) {
            WriteLine("Reprovado");
        } else if (media > 4 && media <= 6) {
            WriteLine("Recuperação");
        } else {
            WriteLine("Aprovado!");
        }
    }
}
