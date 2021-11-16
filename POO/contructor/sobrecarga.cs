using System;

class Aula31
{
    static void Main(){
        Jogador J1=new Jogador("Bruno");
        J1.nome=Console.ReadLine();
        Console.WriteLine("Nome: {0}",J1.nome);
        Console.WriteLine("Energia: {0}",J1.energia);
    }
    
}

class Jogador{

    public int energia;
    public bool vivo;
    public string nome;
    
    public Jogador(string n){
        //metodo construtor é so colocar o nome(){}
        //ele que inicializa as variaveis
        energia=100;
        vivo=true;
        nome=n;
    }

    ~Jogador(){
        //metodo destrutor é antecedido pelo ~
        Console.WriteLine("Jogador foi destruido");
    }
    
}

/* 
   
 */