using System;

class Aula36
{
    static void Main(){
        int n1,n2,res;
        res=n1=n2=0;
        n1=10;
        n2=0;
        try
        {
            res=n1/n2;
            //Ele vai tentar a divisão, se gerar um erro
            //Cai no catch
            //nesse caso, se dividir por 0
            Console.WriteLine("{0}/{1}={2}",n1,n2,res);
        }
        catch(Exception e)
        {
            Console.WriteLine("ERRO: {0}",e.Message);
            //Exception e
            //Se eu não quiser definir o erro, o e receberá
            //a exceção "e" poderá ser imprimido
            //e.Message imprime a mensagem do erro
        }
        
        
    }
    
}

/* 

 */