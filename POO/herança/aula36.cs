using System;

class Aula36
{
    static void Main(){
        Carro c1=new Carro("Ford","Branco");
        Console.WriteLine(c1.cor);
    }
    
}

class Veiculo{

    public int rodas;
    public int velMax;
    private bool ligado;

    public void ligar(){
        ligado=true;
    }
    public void desligar(){
        ligado=false;
    }
    
}

class Carro:Veiculo{
    public string nome;
    public string cor;

    public Carro(string nome, string cor){
        desligar();
        rodas=4;
        velMax=120;
        this.nome=nome;
        this.cor=cor;
    }
}

/* 
    : é o simbolo da herança
 */