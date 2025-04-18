using System;

public class Jogador {
    public int energy;
    public bool life;
    public string name;

    public Jogador(string nome) {
        energy = 100;
        life = true;
        name = nome;
        this.name = nome;
    }

    ~Jogador() {
        Console.WriteLine($"Jogador {name} foi destruído");
    }
}


class Aula29 {

    static void Main() {   

        Console.Write("Digite o nome do Jogador 1: ");
        string PlayerUser = Console.ReadLine();

        Jogador playerOne = new Jogador(PlayerUser);
        Jogador playerTwo = new Jogador("Felipe");

        Console.WriteLine($"Jogador(a) 1 (Usuário): {PlayerUser} - Energia: {playerOne.energy}");
        Console.WriteLine($"Jogador(a) 2 (Sistema): {playerTwo.name} - Energia: {playerTwo.energy}");
    }
}
