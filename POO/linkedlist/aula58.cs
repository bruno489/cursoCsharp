using System;
using System.Collections.Generic;

class Aula36
{
    static void Main(){
        LinkedList<string> transp=new LinkedList<string>();

        transp.AddFirst("Carro");
        transp.AddFirst("Moto");
        //Adiciona no inicio da lista

        transp.AddLast("Bicicleta");
        //adiciona no fim da lista

        LinkedListNode<string> nome;
        nome=transp.FindLast("Moto").Next;//next aponta para o proximo elemento apos o moto
        //transp.FindLast("Moto").Value;//retorna o valor do proprio nó que estou apontando
        transp.AddAfter(nome,"Patinete");
        //adiciona o patinete apos o moto
        //AddBefore(); adiciona antes do elemento determinado

        //transp.Clear();
        //Remove todos os elementos

        //transp.Find("Carro");
        //se o valor estiver presente, retorna true
        //se não estiver, retorna false

        //transp.Remove("Bicicleta");
        //remove um determinado elemento

        //transp.RemoveFirst();//remove o primeiro elemento
        //transp.RemoveLast();//remove o ultimo elemento

        foreach (string t in transp)
        {
            Console.WriteLine("Transporte: {0}",t);
        }
    }
    
}

/* 
    linkedList são lista duplamente cadeadas que cada chave
    tem um nó posterior e anterior

    linkedList<tipo da lista> nome_da_lista=new linkedList<tipo_da_lista>()


 */