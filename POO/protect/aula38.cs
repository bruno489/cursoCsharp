using System;

class Aula36
{
    static void Main(){
        Carro c1=new Carro("Celta",300);
        Console.WriteLine("Nome do carro.: {0}",c1.nome);
        Console.WriteLine("Estado........: {0}",c1.getLigado());
        Console.WriteLine("Velocidade max: {0}",c1.getVel());
    }
    
}

class Veiculo{
    public int velAtual;
    private int velMax;
    //So pode ser acessada pela classe
    protected bool ligado;
    //Permite o acesso aos membro pelas classe derivadas
    //Que herdam a classe veiculo

    public Veiculo(int velMax){
        velAtual=0;
        this.velMax=velMax;
        ligado=false;
    }

    public bool getLigado(){
        return ligado;
    }

    public int getVel(){
        return velMax;
    }
}

class Carro:Veiculo{ //derivada de veiculo
    public string nome;
    public Carro(string nome, int vm):base(vm){
        //o valor que eu passar quando chmar Carro em vm
        //será passado para o principal

        this.nome=nome;
        ligado=true;
    }
}

/* 
    
 */