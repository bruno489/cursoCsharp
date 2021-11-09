using System;

class Aula21
{
    static void Main(){

        int[] vetor1 = new int[5];
        int[] vetor2 = new int[5];
        int[] vetor3 = new int[5];
        int[,] matriz = new int[2,5]{{11,22,33,44,55},{66,77,88,99,00}};

        Random random=new Random();
        for (int i = 0; i < vetor1.Length; i++)
        {
            vetor1[i]=random.Next(50);
            //Next(50);
            //quando colocado um parametro, esse é o valor maximo
            //ou seja, aleatorio de 0 a 49

            //Next()
            //Um numero qualquer

            //Next(50,100)
            //aleatorio entre 51 a 99
        }
        
        //public static int BinarySearch(array,valor);
        //pesquisa o valor dentro do array e se não existir
        // retornará -1
        int retorno=Array.BinarySearch(vetor1,11);
        Console.WriteLine("BinarySearch");
        Console.WriteLine("Valor retornado: {0}",retorno);
        Console.WriteLine("----------------------");

        //public static void Copy(Ar_origem,Ar_destino,qtde_elementos);
        Array.Copy(vetor1,vetor2,vetor1.Length);
        //Copia de um array para o outro
        Console.WriteLine("Copy");
        foreach (var n in vetor2)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine("----------------------");

        //public void CopyTo(Ar_destino,a_partir_desta_pos);
        //mesma coisa que o copy, so muda a sintax
        vetor1.CopyTo(vetor3,0);
        Console.WriteLine("CopyTo");
        foreach (var n in vetor3)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine("----------------------");

        //public int GetUpperBound(dimensão);
        //Retorna o maior indice
        int MaiorIndiceVetor1=vetor1.GetUpperBound(0);
        Console.WriteLine("GetUpperBound");
        Console.WriteLine("Maior indice do vetor1: {0}",MaiorIndiceVetor1);
        Console.WriteLine("-------------------------------");

        //public int GetLowerBound(dimensão);
        //retorna o menor indice
        int MenorIndiceVetor1=vetor1.GetLowerBound(0);
        Console.WriteLine("GetLowerBound");
        Console.WriteLine("Menor indice do vetor1: {0}",MenorIndiceVetor1);
        Console.WriteLine("-------------------------------");

        //public object GetValue(long Indice);
        //Retorna um valor a partir de um indice;
        int valor1=Convert.ToInt32(vetor1.GetValue(3));
        //int valor2=int.Parse(nomeMatriz.GetValue(3,1));
        Console.WriteLine("GetValue");
        Console.WriteLine("Valor na posição 3 do vetor 1: {0}",valor1);
        Console.WriteLine("-------------------------------");

        //public static int indexOf(array,valor);
        //retorna a posição do valor pesquisado no array
        int indice1=Array.IndexOf(vetor1,3);
        Console.WriteLine("indexOf");
        Console.WriteLine("Valor na posição 3 do vetor 1: {0}",indice1);
        Console.WriteLine("-------------------------------");

        //public static int LastIndexOf(array,valor);
        //retorna a posição do ultimo valor pesquisado no array
        int indice2=Array.LastIndexOf(vetor1,3);
        Console.WriteLine("LastIndexOf");
        Console.WriteLine("Valor na posição 3 do vetor 1: {0}",indice2);
        Console.WriteLine("-------------------------------");

        //public static void Reverse(array)
        //Inverte a ordem dos valores do array
        Array.Reverse(vetor1);
        Console.WriteLine("Reverse");
        foreach (var n in vetor1)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine("----------------------");

        //publlic void SetValue(object valor, long pos);
        //Acrescenta um valor em um vetor em uma determinada posição
        vetor2.SetValue(99,0);
        for (int i=0;i<vetor2.Length;i++)
        {
            vetor2.SetValue(0,i);
        }
        Console.WriteLine("SetValue");
        foreach(int n in vetor2){
            Console.WriteLine(n);
        }

        //public static void Sort(Array).
        //Ordena em ordem crescente os elementos de um array
        Array.Sort(vetor1);
        Console.WriteLine("Sort");
        foreach(int n in vetor1){
            Console.WriteLine(n);
        }

    }
}

/* 
    
 */