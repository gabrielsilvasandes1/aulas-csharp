using System;
using System.Data;
using static System.Console;

class Aula06 {
    static void Main() {

        double valorCompra = 5.50;
        double valorVenda;
        double lucro = 0.1;
        string produto = "Pastel";

        valorVenda = valorCompra + (valorCompra * lucro);

        WriteLine("Produto.......:{0,10}", produto);
        WriteLine("Compra........:{0,10:c}",valorCompra);
        WriteLine("Lucro.........:{0,10:p}",lucro);
        WriteLine("Venda.........:{0,10:p}",valorVenda);
    }
}
