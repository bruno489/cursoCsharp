using System;

class Carro{
    private int velMax;

    public int vm{
        get{
            return velMax;
        }
        set{
            if(value<0){
                //value já é uma propriedade intricica do set
                //é o valor passado
                velMax=0;
            }else if(value>300){
                velMax=300;
            }else{
                velMax=value;
            }
        }
    }

    public Carro(){
        vm=120;
    }
}

class Aula36
{
    static void Main(){
        Carro c1=new Carro();
        c1.vm=200;
        //alterando a velocidade
        Console.WriteLine("Velocidade: {0}",c1.vm);
    }
    
}

/* 
    
 */