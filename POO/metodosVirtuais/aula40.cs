using System;

class Aula36
{
    static void Main(){
        Base Ref;
        Derivada1 derivada1= new Derivada1();
        Derivada2 derivada2= new Derivada2();
        
        Ref=derivada1;
        Ref.info();
    }
    
}

class Base{
    public Base(){
        Console.WriteLine("Construtor da classe Base");
    }

    virtual public void info(){
        Console.WriteLine("Base");
    }
}
class Derivada1:Base{
    public Derivada1(){
        Console.WriteLine("Construtor da Derivada1");
    }
    override public void info(){
        Console.WriteLine("Derivada 1");
    }
}

class Derivada2:Derivada1{
    public Derivada2(){
        Console.WriteLine("Construtor da Derivada2");
    }
    override public void info(){
        Console.WriteLine("Derivada 2");
    }
}

/* 
    Metodos virtuais são os que tem o mesmo 
    nome em classes diferentes

    Em outras palavras, permite que o metodo seja sobrescrito
    caso uma outra classe derivada crie um metodo com
    o mesmo nome

    no metodo que irá sobrescrever se deve colocar override
 */