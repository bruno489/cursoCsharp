using System;

class Aula17
{
    static void Main(){
        int tempo=0;
        char escolha;

        inicio:
        //defini um ponto goTo

        Console.Clear();
        //limpa o console

        Console.WriteLine("Belo horizonte/MG a Vitória/ES");
        Console.WriteLine("Escolha o transporte: [a]Avião | [c]Carro");

        escolha=char.Parse(Console.ReadLine());

        switch (escolha)
        {
            case 'a':
                tempo=50;
                Console.WriteLine("Tempo de Viagem: {0}",tempo);
                break;

            case 'c':
                tempo=100;
                Console.WriteLine("Tempo de Viagem: {0}",tempo);
                break;

            default:
                Console.WriteLine("Transporte indisponivel");
                break;
        }

        Console.WriteLine("Calcular outro transporte? [s/n]");
        escolha=char.Parse(Console.ReadLine());

        if(escolha=='s' || escolha=='S'){
            goto inicio;
        }else{
            Console.Clear();
            Console.WriteLine("Fim do programa");
        }
        
    }
}

/* 
    int n2=(int)n1;
    int n2=(tipo em que quero converter)n1 que é a variavel a ser convertida;

 */