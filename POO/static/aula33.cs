using System;

class Aula33
{
    static void Main(){
        Jogador.iniciar("Bruno");
        Jogador.vivo=false;
        //é assim que se altera um atributo de uma classe
        //para ser alterado, o mesmo tem que está public
        Jogador.info();
        //Se instancia pelo proprio nome da classe
    }
    
}

static class Jogador{

    static int energia;
    static public bool vivo;
    static string nome;

    static public void iniciar(string n){
        energia=100;
        vivo=true;
        nome=n;
    }

    static public void info(){
        Console.WriteLine("Nome jogador...: {0}",nome);
        Console.WriteLine("Energia........: {0}",energia);
        Console.WriteLine("Estado jogador.: {0}",vivo);
    }
    
}

/* 
    Static não permite instanciar objetos dessa classe (new nome da classe)
    Não podem ter construtores 
    Elas criam posições fixas na memoria.

    Toda classe static deve ter membros statics
    porem classes não static podem ter membros static
 */