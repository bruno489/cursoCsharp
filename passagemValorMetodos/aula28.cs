using System;

class Aula17
{
    static void Main(){
        int divid,divis,quoc,rest;
        divid=10;
        divis=3;
        quoc=divide(divid,divis,out rest);
        //com out automaticamente o rest está ligado ao metodo

        Console.WriteLine("{0}/{1} : Resultado={2} e resto={3}"
        ,divid,divis,quoc,rest);
    }

    static int divide(int dividendo, int divisor, out int resto){
        int quociente;
        quociente=dividendo/divisor;
        resto=dividendo%divisor;
        return quociente;
    }
    
}

/* 
   argumento out permite o retorno de mais de uma valor
 */