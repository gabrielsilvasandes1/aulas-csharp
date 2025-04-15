using System;
using static System.Console;

class Aula15 {

    static void Main() {

        inicio:

        Console.Clear();

        WriteLine("\u2708  Iremos de Belo Horizonte [MG] até Vitória [ES]");
        WriteLine("Escolha o Transporte: ");

        string texto = @"
[A] Avião
[C] Carro 
[O] Ônibus";

        WriteLine(texto);
        Write("Sua opção: ");

        char escolha = char.Parse(ReadLine());

        int tempo = 0;

        switch (escolha) {
            case 'A':
            case 'a':
                tempo = 50;
                break;
            case 'C':
            case 'c':
                tempo = 480;
                break;
            case 'O':
            case 'o':
                tempo = 660;
                break;
            default:
                tempo = -1;
                break;
        }

        if (tempo < 0) {
            WriteLine("Opção inválida \u274C");
            WriteLine("Pressione qualquer tecla para tentar novamente...");
            ReadKey();
            goto inicio;
        }

        WriteLine($"Transporte escolhido com Sucesso! \u2705 Tempo médio de {tempo} minutos");
    }
}
