using System;

class Aula36
{
    static void Main(){
        Carro c1=new Carro("Ford","Branco");
        Console.WriteLine(c1.getRodas());
    }
    
}

class Veiculo{

    private int rodas;
    public int velMax;
    private bool ligado;

    public void ligar(){
        ligado=true;
    }
    public void desligar(){
        ligado=false;
    }
    public Veiculo(int rodas){
        this.rodas=rodas;
    }
    public int getRodas(){
        return rodas;
    }
}

class Carro:Veiculo{
    public string nome;
    public string cor;

    public Carro(string nome, string cor):base(4){
        //:base() chama o construtor da classe base
        desligar();
        velMax=120;
        this.nome=nome;
        this.cor=cor;
    }
}

/* 
    return(ligado?"sim":"Não");
    retorno de operação ternaria
 */