using System;

class Aula27 {
    static void Main() {
        soma(5.9, 5.1);
        soma(8.7, 9.1);
    }

    static void soma(params double[]array) {
        double resultado = 0;

        if (array.Length < 1) {
            Console.WriteLine("Não existem valores a serem somados");
        } else if (array.Length < 2) {
            Console.WriteLine($"Valores insuficientes para a soma: {array[0]}");
        } else {
            for(int i = 0; i < array.Length; i++) {
                resultado += array[i];
            }
            Console.WriteLine($"A soma dos valores é {resultado}");
            
        }
    }
}
