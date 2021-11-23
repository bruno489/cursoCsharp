using System;

class Aula33
{
    static void Main(){
        Inimigo i1 = new Inimigo("Doidão");
        Inimigo i2 = new Inimigo("Surtado");
        Inimigo i3 = new Inimigo("Angelica");

        Inimigo.alerta=true;
        /* Como o alerta é static, todos os alertas foram
        alterados */

        i1.info();
        i2.info();
        i3.info();
    }
    
}

class Inimigo{

    static public bool alerta;
    public string nome;

    public Inimigo(string n){
        alerta=false;
        nome=n;
    }

    public void info(){
        Console.WriteLine("Nome Inimigo...: {0}",nome);
        Console.WriteLine("Alerta.........: {0}",alerta);
        Console.WriteLine("---------------------------",alerta);
    }
    
}

/* 
    
 */