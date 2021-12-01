using System;
using System.Collections.Generic;

class Aula36
{
    static void Main(){
        List<string> carros=new List<string>();
        //List<string> carros2=new List<string>();

        carros.Add("EcoSport");
        carros.Add("Uno");
        carros.Add("Fiorino");

        carros.Insert(1,"Cruze");
        //insere um elemento na posição determinada

        //carros.Capacity=15;
        //altera a capacidade da lista
        //int capacidade=carros.Capacity;
        //retorna a capacidade da lista
        //Console.WriteLine("Tem capacidade de : {0}",capacidade);

        //int tamanho=carros.Count;
        //count pega o tamanho da lista
        //Console.WriteLine(tamanho);

        //carros.Reverse();
        //reverte a lista

        carros.Sort();
        //ordena por ordem alfabetica a lista

        //int pos2=carros.LastIndexOf("Cruze");
        //retorna a posição do ultimo cruze na lista
        //Console.WriteLine("O cruze está na pos: {0}",pos2);

        //carros.Remove("Uno");
        //remove um elemento da lista

        //carros.RemoveAt(0);
        //remove o elemento que tá na posição 0

        foreach (string s in carros)
        {
            Console.WriteLine("Carro: {0}",s);
        }

    }
}

/* 
    
 */