using System;

class Aula17
{
    static void Main(){
        soma(6,5,6,2,7);
    }

    static void soma(params int[]n){
        int res=0;
        if(n.Length<1){
            Console.WriteLine("Sem valores para somar");
        }else if(n.Length<2){
            Console.WriteLine("Valores Insuficientes: {0}",n[0]);
        }else{
            for (int i=0;i<n.Length;i++)
            {
                res+=n[i];
            }
            Console.WriteLine("Total: {0}",res);
        }

    }
    
}

/* 
   params permite passar um array completo para uma função
 */