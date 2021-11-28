using System;

public interface Veiculo{
    //Só aceita metodos, nunca 
    void ligar();
    void desligar();
    void info();
}

public interface Combate{
    void disparar();
}

class Carro:Veiculo,Combate{
    //Estou herdando de combate e de veiculo
    public bool ligado;

    public Carro(){}

    public void disparar(){}
    //Se não implementado o metodo, dá erro.

    public void ligar(){
        this.ligado=true;
    }
    public void desligar(){
        this.ligado=false;
    }
    public void info(){}
}

class Aula36
{
    static void Main(){
        Carro c1=new Carro();
    }
    
}

/* 
    interface é basicamente como abstrat, quem herda tem
    que iniciar os metodos e podem ser hedados por mais de um
 */