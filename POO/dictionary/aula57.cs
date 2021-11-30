using System;
using System.Collections.Generic;
//dictionary é uma coleção generica

class Aula36
{
    static void Main(){
        Dictionary <int,string> veiculos=new Dictionary<int, string>();
        //preciso indicar uma chave e um valor
        //podem ser mesmo tipo ou tipos diferentes
        //<tipo_chave,tipo_valor>

        veiculos.Add(10,"Carro");
        //adiciona ao dictionary
        //veiculos.Add(chave,valor);

        veiculos.Add(5,"Avião");
        veiculos.Add(0,"Navio");

        Dictionary <int,string>.ValueCollection valores=veiculos.Values;

        foreach (string s in valores)
        {
            Console.WriteLine(s);
        }
        //para imprimir

        /* foreach (KeyValuePair<int,string> s in veiculos)
        {
            Console.WriteLine(s.Value);
            //s.Key se quisesse a chave
        } */

        //veiculos[5]="Bicicleta";
        //alterou o elemento com a chave 5

        //veiculos.Remove(5);
        //remove o elemento pela chave

        //veiculos.ContainsKey(22);
        //Verifica se existe a chave na coleção, se não
        //retorna false, se sim retorna true

        //veiculos.ContainsValue("Carro");
        //mesma coisa que o key só que com valor

        //veiculos.Clear();
        //limpa o dictionary

        Console.WriteLine("Tamanho do dictionary: {0}",veiculos.Count);
        //veiculos.Count retorna um int
        //Count retorna o numeros de elementos de um dictionary
    }
    
}

/* 
    
 */