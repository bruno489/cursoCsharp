using System;

class Aula33
{
    static void Main(){
        Jogador j1=new Jogador("Bruno");
        j1.setEnergia(200);
        Console.WriteLine("Novo modelo: {0}",j1.getNome());
        Console.WriteLine("Nova energia: {0}",j1.getEnergia());
    }
    
}

class Jogador{

    private int energia;
    private string nome;
    
    public Jogador(string n){
        this.nome=n;
        this.energia=100;
    }

    public int getEnergia(){
        return energia;
    }

    public string getNome(){
        return nome;
    }

    public void setEnergia(int e){
        this.energia=e;
    }
}

/* 
    Quando se define um private só pode ser acessado por
    dentro da propria classe, isso dá um nivel de proteção maior

    Com o private, se deve ser obtido os valores atraves de getter
    os metodos podem ter quaisquer nomes, mas por boa pratica se
    coloca get alguma coisa
 */