using System;
using System.Collections.Generic;

class Aula36
{
    static void Main(){
        List<string> carros=new List<string>();
        //List<string> carros2=new List<string>();

        //string[] carros2=new string[6];
        //para usar no copyto

        carros.Add("EcoSport");
        carros.Add("Uno");
        carros.Add("Fiorino");


        //carros.CopyTo(carros2,2);
        //copiando carros para carros 2 array
        //apartir do segundo elemento

        //carros2.AddRange(carros);
        //adicionou os elementos de carros em carro2

        //carros.Clear();
        //remove todos os elementos de carros

        //carros.Contains("Uno");
        //verifica se há um elemento na lista
        //se contiver, retorna true

        foreach (string s in carros)
        {
            Console.WriteLine("Carro: {0}",s);
        }

        string ca="Uno";
        int pos=0;
        pos=carros.IndexOf(ca);
        //procura a posição da string na lista
        Console.WriteLine("Carro {0} está na pos {1}",ca,pos);

    }
}

/* 
    list é um array dinamico/tunado kkkk
 */