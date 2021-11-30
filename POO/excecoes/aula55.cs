using System;

class Area
{
    public static float Quad(float bas, float alt){
        if (bas==0 || alt==0)
        {
            throw new Exception("Base ou altura tem que ser > 0");
        }
        return bas*alt;
    }
}

class Aula36
{
    static void Main(){
        /* int n1,n2,res;
        res=n1=n2=0;
        n1=10;
        n2=0;
        try
        {
            res=n1/n2;
            Console.WriteLine("{0}/{1}={2}",n1,n2,res);
            throw new Exception("CFB Cursos"); 
            //gera um novo erro
        }
        catch(Exception e)
        {
            Console.WriteLine("ERRO: {0}",e.Message);
            
        }finally{
            //é executado independente de dá erro ou não
            Console.WriteLine("Fim do processo");
        } */
        
        float area=0;
        try
        {
            area=Area.Quad(10F,5F);
            //pode ser chamado assim por ser static
            Console.WriteLine(area);
        }
        catch(Exception e)
        {
            Console.WriteLine("ERRO: {0}",e.Message);
            
        }
    }
    
}

/* 

 */