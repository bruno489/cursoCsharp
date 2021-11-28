using System;

abstract class Veiculo{
    protected int velMax;
    protected int velAtual;
    protected bool ligado;

    public Veiculo(){
        ligado=false;
        velAtual=0;
    }

    public void setLigado(bool lig){
        this.ligado=lig;
    }

    public int getVelAtual(){
        return this.velAtual;
    }
    public bool getLigado(){
        return this.ligado;
    }
    abstract public void aceleracao(int mult);
}

class Carro:Veiculo{
    public Carro(){
        velMax=120;
    }

    override public void aceleracao(int mult){
        velAtual+=10*mult;
    }
}

class Aula36
{
    static void Main(){
        Carro carro1=new Carro();
        carro1.aceleracao(2);
        Console.WriteLine(carro1.getVelAtual());
        carro1.setLigado(true);
        
        Console.WriteLine(carro1.getLigado());
    }
    
}

/* 
    classes derivadas de uma abstrata tem que implementar
    os metodos abstratos da classe origem

    Não se pode instanciar a classe abstrata
    Veiculo veiculo = new Veiculo();
 */