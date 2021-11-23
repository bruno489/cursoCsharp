using System;

class Aula33
{
    static void Main(){
        Calculos cal=new Calculos(10,20);
        cal.info();
        
    }
    
}

class Calculos{

    public int v1;
    ////esse v1 do objeto calculos
    public int v2;

    public Calculos(int v1,int v2){
        this.v1=v1;
        ////esse v1 com o this é
        this.v2=v2;
    }

    public int somar(){
        return v1+v2;
    }

    public void info(){
        Console.WriteLine("Total: {0}",somar());
        
    }
    
}

/* 
    
 */