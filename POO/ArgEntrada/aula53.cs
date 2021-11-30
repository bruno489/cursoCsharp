using System;

class Aula36
{
    static void Main(string[] args){
        if (args.Length>0)
        {
            Console.WriteLine("Qtde de args: {0}",args.Length);
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("Arg {1}: {0}",args[i],i);
            }
        }else
        {
            Console.WriteLine("Sem argumentos");
        }
    }
    
}

/* 
    Main(string[] args)
    cria um array de entrada de argumentos chamado args

    ./aula53 maria joao duda
 */