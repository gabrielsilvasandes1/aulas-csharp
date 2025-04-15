using System;

class Aula04 {

    static int num = 12; // Exemplo de Variável Global

    static void Main() {
        int n1 = 10; // Exemplo de Variável Local
        Console.WriteLine(n1);
        Console.WriteLine(num);
    }

    static void Secondary () {
        Console.WriteLine(num);
    }
}
