using System;

class Aula08
{
    static void Main(){
        double valorCompra=5.50;
        double valorVenda;
        double lucro=0.1;
        string produto="Pastel";
        valorVenda=valorCompra+(valorCompra*lucro);

        Console.WriteLine("Produto........:{0,15}",produto);
        Console.WriteLine("Val.Compra.....:{0,15:c}",valorCompra);
        Console.WriteLine("Lucro..........:{0,15:p}",lucro);
        Console.WriteLine("Val.Venda......:{0,15:c}",valorVenda);
        //c retorna em valor monertário
        //p retorna em porcentagem

    }
}

/* 
int n1,n2,n3;
n1=10;n2=30;n3=40;

Console.Write("n1={0}, n2={1}, n3={2}",n1,n2,n3);
Console.Write("n1={0}, n2={1}, n3={2}",posição 0,posição 1,posição 2);
 */