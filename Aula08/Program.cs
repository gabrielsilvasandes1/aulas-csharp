using System;
using static System.Console;

class Aula08 {
    static void Main() {
        
        int num1, num2, res;
        Write("Digite um número: ");
        num1 = Convert.ToInt32(ReadLine());
        Write("Digite outro número: ");
        num2 = Convert.ToInt32(ReadLine());
        res = num1 + num2;
        WriteLine($"A soma de {num1} mais {num2} é igual a {res}");
    }
}
