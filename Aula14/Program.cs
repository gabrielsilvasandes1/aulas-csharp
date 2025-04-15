using System;
using static System.Console;

class Aula14 {

    static void Main() {
        int nota1, nota2;

        WriteLine("Digite a primeira nota: ");
        nota1 = int.Parse(ReadLine());

        WriteLine("Digite a segunda nota: ");
        nota2 = int.Parse(ReadLine());
        
        float media = (nota1 + nota2) / 2;
        
        if (media <= 4) {
            if (media == 0) {
                WriteLine("Reprovado com Péssimo Desempenho!");
            } else {
                WriteLine("Reprovado com Desempenho Insatisfatório!");
            }
        } else if (media > 4 && media <= 6) {
            if (media == 5) {
                WriteLine("Recuperação Obrigatória");
            } else {
                WriteLine("Recuperação Opcional");
            }
        } else {
            if (media >= 9) {
                WriteLine("Aprovado com Excelente Desempenho!");
            } else {
                WriteLine("Aprovado com Desempenho Satisfatório!");
            }
        }
    }
}
