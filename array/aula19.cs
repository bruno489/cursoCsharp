using System;

class Aula13
{
    static void Main(){
        int[] n= new int[5];
        //int num=new int[3]{55,77,99};

        int num={55,77,99};
        //outra forma de declarar o mesmo num acima

        n[0]=111;
        n[1]=22;

        Console.Write(n[1]);
    }
}

/* 
    tipo[] nome= new int[quantidade de elementos];

    n[0]=111;
    n[1]=22;
    para colocar nas posições

    Console.Write(n[1]);
    imprimindo o array

    int num=new int[3]{55,77,99};
    int num=new int[quantidade de elementos]{valores};

 */