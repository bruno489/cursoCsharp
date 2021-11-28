using System;

struct Carro
{
    public string marca;
    public string modelo;
    public string cor;

    public Carro(string marca,string modelo,string cor){
        this.marca=marca;
        this.modelo=modelo;
        this.cor=cor;
    }
}

class Aula36
{
    static void Main(){
        Carro c1;
        //Assim se instacia

        Carro c2=new Carro("Ford","EcoSport","Branco");

        c1.marca="Ford";
        c1.modelo="Fusion";
        c1.cor="Branco";
        Console.WriteLine("Modelo: {0}",c2.modelo);
    }
    
}

/* 
    struct é uma strutura que permite o armazenamento de 
    diferentes tipo de dados

    struct não é classe
 */