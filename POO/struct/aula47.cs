using System;

struct Carro
{
    public string modelo;
    public string cor;

    public void info(){
        Console.WriteLine("Modelo..: {0}",this.modelo);
        Console.WriteLine("Cor.....: {0}",this.cor);
        Console.WriteLine("---------------------");
    }
}

class Aula36
{
    static void Main(){

        int[] numeros=new int[10];
        Carro[] carros1=new Carro[3];
        
        carros1[0].modelo="HR-V";
        carros1[0].cor="Prata";
        
        carros1[1].modelo="Fusion";
        carros1[1].cor="Branco";

        carros1[2].modelo="Ka";
        carros1[2].cor="Vermelho";

        for (int i = 0; i < carros1.Length; i++)
        {
            carros1[i].info();
        }
        
    }
    
}

/* 
    arrays em struct
 */