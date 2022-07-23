using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 4 Conversões e outros tipos!");

        double salario = 2850.34;

        //Variavel do tipo inteiro armazena ate 32 bits e o que foi feito foi um casting
        int salarioInteiro = (int)salario;

        //Variável do tipo long armazena ate 64 bits
        long x = 200000000;

        //Variável do tipo short armazena ate 16 bits
        short y = 13000;

        float peso = 75.76f;

        Console.WriteLine("Salario utilizando double: " + salario);
        Console.WriteLine("Salario utilizando inteiro: " + salarioInteiro);
        Console.WriteLine("Utilizando-se a Variável do tipo long: " + x);
        Console.WriteLine("Utilizando-se a Variável do tipo short: " + y);
        Console.WriteLine("Utilizando-se a Variavel do tipo float: " + peso);

        Console.WriteLine("Aperte a tecla ENTER para fechar a janela!");
        Console.ReadLine();
    }
}