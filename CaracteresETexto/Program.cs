using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 5 Caracteres e Textos");

        //o char é para carecteres e usa-se  a aspas simples como o exemplo abaixo 'a'
        char letra = 'a';
        Console.WriteLine("primeira variavel letra: " + letra);
        char secundaLetra = 'b';
        Console.WriteLine("secunda variável secundaLetra: " + secundaLetra);

        char terceiraLetra = 'c';
        Console.WriteLine("terceira variável terceiraLetra: " + terceiraLetra);

        //fazendo casting novamente
        letra = (char)75;

        //Pode fazer o casting dessa maneira tambem
        terceiraLetra = (char)(75 + 1);
        Console.WriteLine("variável terceiraLetra usando(char)(numeração): " + terceiraLetra);

        //Utilizando string vai guardar uma frase, nome ou um tipo
        string frase = "Aprendendo CSharp (C#) ";
        Console.WriteLine(frase +  2022);

        //Utilize o @ e onde tem as linguagens de programação jogue para esquerda como está abaixo vera que ficara cada curso em cada linha a esquerda
        string programacao = @"Linguagens de programação: 
-CSharp 
-JavaScript 
-PHP 
-Java";
        Console.WriteLine(programacao);

        Console.WriteLine("Aperte a tecla ENTER para fechar a janela!");
        Console.ReadLine();
    }
}