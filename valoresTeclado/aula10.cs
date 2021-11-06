using System;

class Aula09
{
    static void Main(){
        int v1,v2,soma;
        string nome;

        Console.Write("Digite o primeiro valor: ");
        v1=int.Parse(Console.ReadLine());
        Console.Write("Digite o segundo valor: ");
        v2=int.Parse(Console.ReadLine());
        soma=v1+v2;
        Console.WriteLine("Total: {0}",soma);
    }
}

/* 
    nome=Console.ReadLine();
    pega o valor e pula uma linha

    Console.Write("Digite Seu nome: ");
    nome=Console.ReadLine();
    Console.WriteLine("Nome digitado: {0}",nome);

    int.Parse(Console.ReadLine())
    converteu o que veio de string em inteiro
 */