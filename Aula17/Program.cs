using System;
using static System.Console;

class Aula17 {
    static void Main() {

        // Aqui o new não é obrigatório
        int[] n = new int[5] {11, 22, 33, 44, 55}; // Aqui declaramos e inicializamos o Array

        int[] num; // Aqui declaramos o Array
        // Aqui o new é obrigatório
        num = new int[3]; // Aqui inicializamos o Array

        num[0] = 14;
        num[1] = 15;
        num[2] = 16;

        WriteLine($"Array 1: {n[4]}");
        WriteLine($"Array 2: {num[2]}");
    }
}
