using System;
using static System.Console;

class Aula17 {
    static void Main() {
        int[,] n = new int[3,5]; /* Declaração de uma Matriz 1 sem Atribuição */
        int[,] num = new int[2,2]{{10 , 20}, {30 , 40}}; /* Declaração de uma Matriz 2 com Atribuição */

        /* Matriz 1
         0  1  2  3  4
       0 10 20 30 40 50
       1 60 70 80 90 15
       2 25 35 45 55 65
        */

        /* Matriz 2
         0  1  
       0 10 20
       1 30 40 
        */

        /* Atribuição de valores da Matriz 1 */
        n[0,0] = 10; n[0,1] = 20; n[0,2] = 30; n[0,3] = 40; n[0,4] = 50;
        n[1,0] = 60; n[1,1] = 70; n[1,2] = 80; n[1,3] = 90; n[1,4] = 15;
        n[2,0] = 25; n[2,1] = 35; n[2,2] = 45; n[2,3] = 55; n[2,4] = 65;

        WriteLine($"Na Linha 2, Coluna 2 da Matriz 1 temos o número {n[2,2]}");
        WriteLine($"Na Linha 1, Coluna 1 da Matriz 2 temos o número {num[1,1]}");
    }
}
