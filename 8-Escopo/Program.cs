using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 8 Escopo");

        int idadePedro = 16;
        int idadeAcompanhante = 18;

        bool acompanhado = idadeAcompanhante >= 18;

        string textoAdicional;

        if(acompanhado == true)
        {
            textoAdicional = "Pedro está acompanhado";
        }
        else
        {
            textoAdicional = "Pedro não está acompanhado";
        }


        if (idadePedro >= 18 || acompanhado)
        {
            Console.WriteLine(textoAdicional);
            Console.WriteLine("Pode entrar.");
        }
        else
            Console.WriteLine("Ele não está acompanhado.  Pode entrar");


        Console.WriteLine("Aperte a tecla ENTER para fechar a janela!");
        Console.ReadLine();
    }
}