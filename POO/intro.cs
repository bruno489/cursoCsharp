using System;

class Aula17
{
    static void Main(){
        
    }

    static void soma(params int[]n){
        
    }
    
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
        abstract:
 */