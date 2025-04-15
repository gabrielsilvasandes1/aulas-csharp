using System;

class Aula03 {
    static void Main() {
        
        int num1, num2, res;
        Console.Write("Digite um número: ");
        num1 = int.Parse(Console.ReadLine());
        Console.Write("Digite outro número: ");
        num2 = int.Parse(Console.ReadLine());
        res = num1 * num2;
        Console.WriteLine($"A soma de {num1} vezes {num2} é igual a {res}");
    }
}
