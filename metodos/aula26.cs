using System;

class Aula17
{
    static void Main(){
        Console.Write("Escreva o primeiro valor: ");
        int n1;
        n1=int.Parse(Console.ReadLine());

        Console.Write("Escreva o segundo valor: ");
        int n2;
        n2=int.Parse(Console.ReadLine());
        ola(n1,n2);
    }

    static int ola(int n1,int n2){
        int res=n1+n2;
        Console.WriteLine("Total:{0}",res);
    }
    
}

/* 
    static void Main(){
        ola();
    }

    static int ola(){
        //void significa que ele não retorna nada
        Console.WriteLine("Olá metodo");
    }
    //para que um metodo seja chamado, deve ser chamado
    //no main //ola();
    //static int ola() pq retornara um valor inteiro

    -----------------------------------------------------

    PASSANDO VALORES PELOS PARAMENTOS

    static int Main(){
        Console.Write("Escreva o primeiro valor: ");
        int n1;
        n1=int.Parse(Console.ReadLine());

        Console.Write("Escreva o segundo valor: ");
        int n2;
        n2=int.Parse(Console.ReadLine());
        ola(n1,n2);
    }

    static void ola(int n1,int n2){
        int res=n1+n2;
        Console.WriteLine("Total:{0}",res);
    }

 */