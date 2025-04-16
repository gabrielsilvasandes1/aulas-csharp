using System;
using System.Formats.Asn1;

class Aula26 {
    static void Main() {
        double area = CalcularRetangulo(5, 3, out double perimetro);
        Console.WriteLine($"Área: {area}");
        Console.WriteLine($"Perímetro: {perimetro}");
    }

    static double CalcularRetangulo(double largura, double altura, out double perimetro) {
        double area = largura * altura;
        perimetro = 2 * (largura + altura);
        return area;
    }
}
