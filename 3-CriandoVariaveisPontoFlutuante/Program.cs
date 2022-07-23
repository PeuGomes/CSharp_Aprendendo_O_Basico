using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 3 Variáveis com Ponto Flutuante!");

        double salario;

        salario = 2750.20;

        double idade;
        idade = 7.0 / 5;

        Console.WriteLine("Salario utilizando o double ou seja ponto flutuante R$: " + salario);
        Console.WriteLine("idade utilizando o double: " + idade);
        Console.WriteLine("Aperte ENTER ou qualquer tecla para sair da janela");

        Console.ReadLine();
    }
}