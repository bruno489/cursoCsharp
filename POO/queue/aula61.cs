using System;
using System.Collections.Generic;

class Aula36
{
    static void Main(){
        
        Queue<string> veiculos=new Queue<string>();

        veiculos.Enqueue("Carro");
        //Para adicionar no queue
        veiculos.Enqueue("Moto");
        veiculos.Enqueue("Avião");

        //veiculos.Peek();
        //retorna o primeiro elemento mas não o remove da fila

        //veiculos.Dequeue();
        //pega o primeiro elementos, retorna ele e elimina ele
        //da fila

        //veiculos.Clear();

        //veiculos.Contains("Moto")
        //Se existir um moto, ele retorna true

        //veiculos.Count
        //Retorna quantos elementos há na fila

        foreach (string v in veiculos)
        {
            Console.WriteLine("Veiculo: {0}", v);
        }

    }
}

/* 
    queue são filas onde o primeiro elemento 
    a ser adicionado é o primeiro a sair

    Queue<string> veiculos=new Queue<string>(v);
    se voce quises colocar elementos dentro de uma queue é
    só colocar a variavel/array dentro dos parenteses
    nesse caso, representado pelo v
 */