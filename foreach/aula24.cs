using System;

class Aula21
{
    static void Main(){

        int[] num = new int[3]{11,22,33};
        int i =0;

        foreach (var elemento in num)
        {
            Console.WriteLine(elemento);
            //Não se pode atribuir atraves do foreach
            // n=0; é proibido no foreach
        }

    }
}

/* 
    foreach (var elemento in variavelSendoPassada)
        {
            Console.WriteLine(elemento);
        }
 */