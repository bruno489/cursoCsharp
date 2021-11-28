using System;

class Galinha
{
    private string nomeGalinha;
    private int numOvos;
    
    public Galinha(string nome){
        this.nomeGalinha=nome;
        numOvos=0;
    }

    public Ovo botar(){
        //acesso objeto nome_do_metodo(){}
        return new Ovo();
        //Aqui ele vai chamar um outro metodo
        // ou construtor de uma outra classe
    }
}

class Ovo{
    public Ovo(){
        //esse é o construtor chamado
        Console.WriteLine("Ovo Criado");
    }
}

class Aula36
{
    static void Main(){

        Galinha g1= new Galinha("Gildete");
        Galinha g2= new Galinha("Bernadete");
        Galinha g3= new Galinha("Carminha");

        g1.botar();
        
    }
    
}

/* 
    arrays em struct
 */