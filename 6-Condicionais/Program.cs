using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 6 Trabalhando com Concidionais");

        int idadePedro = 16;
        int idadeAcompanhante = 18;

        if(idadePedro >= 18)
        {
            Console.WriteLine("Pode entrar.");
        }
        else
        {
            if(idadeAcompanhante >= 18)
            {
                Console.WriteLine("Ele está acompanhado.  Pode entrar");
            }
            else
            {
                Console.WriteLine("Não pode entrar!");
            }
        }

        Console.WriteLine("Aperte a tecla ENTER para fechar a janela!");
        Console.ReadLine();
    }
}