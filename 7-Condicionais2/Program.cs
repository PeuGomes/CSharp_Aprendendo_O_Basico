using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 7 Trabalhando com Concidionais parte 2");

        int idadePedro = 16;
        int idadeAcompanhante = 18;

        //poderia trabalhar com o bool que é um valor boleano de verdadeiro ou falso pode se usar operadores logicos || ou && dentro da condicional

        if (idadePedro >= 18 || idadeAcompanhante >=18)
        {
            Console.WriteLine("Pode entrar.");
        }
        else
        {
            Console.WriteLine("Ele não está acompanhado.  Pode entrar");

        }

        Console.WriteLine("Aperte a tecla ENTER para fechar a janela!");
        Console.ReadLine();
    }
}