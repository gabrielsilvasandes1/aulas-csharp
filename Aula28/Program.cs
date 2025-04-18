using System;

public class Jogador {
    public int energy = 100;
    public bool life = true;
}

class Aula28 {
    static void Main() {
        Jogador playerOne = new Jogador();
        Jogador playerTwo = new Jogador();
        Jogador playerThree = new Jogador();

        playerOne.energy = 50;

        Console.WriteLine($"Energia do Jogador 1 : {playerOne.energy}");
        Console.WriteLine($"Energia do Jogador 2 : {playerTwo.energy}");
    }
}
