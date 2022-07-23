using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 12 - Encadeando For e Utilizando o break");


        for (int contadorLinhas = 0; contadorLinhas < 10; contadorLinhas++)
        {
            for (int contadorColunas = 0; contadorColunas < 10; contadorColunas++)
            {
                Console.Write("=");
                if (contadorColunas >= contadorLinhas)
                    //Utilização do break
                    break;

            }
            Console.WriteLine();
        }

        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}