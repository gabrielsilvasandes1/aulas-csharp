using System;
using static System.Console;

class Aula11 {

    static void Main() {
        float n1 = 10.5f;
        int n2 = (int) n1; // Operação de typecast - Conversão de Tipos
        Write(n2);
    }

    static void Secondary() {
        int num = 10;
        short num1 = (short) num; // Números Inteiros Menores do Que 'Int'
        Write(num1);
    }
}
