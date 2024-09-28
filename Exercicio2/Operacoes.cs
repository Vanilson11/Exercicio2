namespace Exercicio2;
public class Operacoes
{
    static public void Adicao(double numero1, double numero2)
    {
        var resultado = numero1 + numero2;
        Console.WriteLine(resultado);
    }

    static public void Subtracao(double numero1, double numero2)
    {
        var resultado = numero1 - numero2;
        Console.WriteLine(resultado);
    }

    static public void Multiplicacao(double numero1, double numero2)
    {
        var resultado = numero1 * numero2;
        Console.WriteLine(resultado);
    }

    static public void Divisao(double numero1, double numero2) {
        if (numero2 == 0) {
            Console.WriteLine("Não é possível divisão por zero!");
            return;
        }
        var resultado = numero1 / numero2;
        Console.WriteLine(resultado);
    }

    static public void Media(double numero1, double numero2) { 
        var media = (numero1 + numero2) / 2;
        Console.WriteLine(media);
    }
}
