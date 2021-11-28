using System;

class Carro{
    private int[] velMax=new int[5]{80,120,160,240,300};

    public int this[int i]{
        //int i é o indice do vetor
        //quando indicar o indice no objeto, será enviado por aqui
        get{
            return velMax[i];
        }
        set{
            if(value<0){
                velMax[i]=0;
            }else if(value>300){
                velMax[i]=300;
            }else{
                velMax[i]=value;
            }
        }
    }

    public Carro(){
        
    }
}

class Aula36
{
    static void Main(){
        Carro c1=new Carro();
        c1[4]=200;
        //na pisição 5 será colocado o valor 200
        Console.WriteLine("Velocidade: {0}",c1[4]);
        //será lido o valor da posição 5
    }
    
}

/* 
    indexador permite um objeto ser manipulado como um array
 */