using System;

class Aula10
{
    static void Main(){
        Jogador j1=new Jogador();
        //o new reserva a memoria e retorna os valores contruidos
        j1.energia=200;
        //Um novo objeto da classe Jogador
        //Jogador nome=new Jogador();

        Console.WriteLine("Energia: {0}",j1.energia);
    }

}

class Jogador{
    //nome de classe com letra maiuscula por boa pratica
    //se não usa modificador, é uma classe publica

    public int energia=100;
    bool vivo=true;
    //se não usado o especificador, é public

    
}

/* 
   [ModificadorClasse] class NOME_DA_CLASSE{
       //variaveis são chamadas de propriedades
       [EspecificadorAcesso] tipo NOME_PROPRIEDADE;

       //Metodos
       [EspecificadorAcesso] retorno NOME_METODO(arg1,...){
           //corpo do metodo
       }
   }

   //ModificadorClasse:Define a visibilidade da classe
        public: Pública, sem restrições de visualização
        abstract:Classe-base para outras classes, não podem
                //instanciados objjetos nesta classe
        sealed: Selado, Classe não pode ser herdada.
        static: Classe não permite a instanciação de objetos
                //e seus membros devem ser static.

    //EspecificadorAcesso: Onde um membro da classe pode ser acessado
        public: Sem restrições de acesso.
        private: So podem ser acessados pela propria classe
        protect: Podem ser acessados pela propria classe e nas
                //classes derivadas.
        abstract:os metodos não tem implementação somente os cabeçalhos
        sealed: O metodo não pode ser redefinido
        virtual: o metodo pode ser redifinido em uma classe derivada
        static:o metodo pode ser chamado mesmo sem uma instaciação de
                //um objeto
 */