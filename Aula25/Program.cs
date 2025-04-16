using System;
using static System.Console;

class Aula25 {
    static void Main() {
        int num = 10;
        dobrar(ref num);
        Write(num);
    }

    static void dobrar(ref int valor) { /* Passagem por referência (Altera o valor) */
        valor *= 2;
    }

    static void dobrar2(int valor) { /* Passagem por valor (Não altera o valor) */
        valor *= 2;
    }
}
