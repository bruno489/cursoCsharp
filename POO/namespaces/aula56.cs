using System;

namespace Calc1
{
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
}


class Aula36
{
    static void Main(){
        
        float area=0;
        try
        {
            area=Calc1.Area.Quad(10F,5F);
            //Agora tem que dizer qual namespace
            Console.WriteLine(area);
        }
        catch(Exception e)
        {
            Console.WriteLine("ERRO: {0}",e.Message);
            
        }
    }
    
}

/* 
    é apenas para classificar cada area por tipo
 */