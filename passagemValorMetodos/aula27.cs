using System;

class Aula17
{
    static void Main(){
        int num=10;
        dobrar(ref num);
        Console.WriteLine(num);
    }

    static void dobrar(ref int valor){
        valor*=2;
    }
    
}

/* 
   ref
   é a passagem por referencia, passando o valor de num direto para
   o metodo seguinte, como se o metodo estivesse dentro de
   Main. Alterando assim, num 
 */