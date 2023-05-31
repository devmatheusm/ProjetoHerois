namespace TrabalhoHerois.Model.Entities
{
    public class Heroi : Pessoa
    {
        //VARIAVEIS DO HEROI
        protected string nomeHeroi;
        protected string grupo;
        protected string parceiro;
        protected string planetaOrigem;
        protected string superPoder;
        protected string pontoFraco;

        // CONSTRUTOR DO HEROI
        public Heroi() : base()
        {
            nomeHeroi = grupo = parceiro = planetaOrigem = superPoder = pontoFraco = "";
        }
        // PROPRIEDADES DO HEROI
        public string NomeHeroi
        {
            get { return nomeHeroi; }
            set { nomeHeroi = value; }
        }

        public string Grupo
        {
            get { return grupo; }
            set { grupo = value; }
        }
        public string Parceiro
        {
            get { return parceiro; }
            set { parceiro = value; }
        }
        public string PlanetaOrigem
        {
            get { return planetaOrigem; }
            set { planetaOrigem = value; }
        }
        public string SuperPoder
        {
            get { return superPoder; }
            set { superPoder = value; }
        }
        public string PontoFraco
        {
            get { return pontoFraco; }
            set { pontoFraco = value; }
        }
    }
}






/* SE VOCE ESTA LENDO ESSA PARTE AQUI
TOME UM BATMAN DE PRESENTE*/

//
//                          ,*.                   .*,                            
//                        ,((#*                   *#((,                          
//                      .*(&%#*                   *#%&(*.                        
//                     ./%%&%#*                   *#%&%%/.                       
//                    ,/#&&&%#*                   *#%&&&#/,                      
//                   ./&&&&&%#*..,**///(((///**,..*#%&&&&&/.                     
//                  ,*#&&&&&&&%#%&&&&@@@@@@@&&&&%#%&&&&&&&#*,                    
//                  *%%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%%*                    
//                 .(@&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&@(.                   
//                .*#@&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&@#*.                  
//                ,/#&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&#/,                  
//                ,(%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%(,                  
//                *#%&&&&&&@&&&&&&&&&&&&&&&&&&&&&&&&&@&&&&&&%#*                  
//                *#%&&&@@%(//#%%%&&&&&&&&&&&&&%%%#/((%@@&&&%#*                  
//                ,/#&&&&@%/*...,*/(#%%&&&%%#(/*,,..*/%@&&&&#/,                  
//                .,#@&&&&&&&%##(/**/(%@@@%(/**/(##%&&&&&&&@#,.                  
//                  /&&&&&&&&&&&&&@@@@&&&&&@@@@&&&&&&&&&&&&&/                    
//                  ,/#&&&&&%#%&%%%&&&&&&&&&&&%%%&%#%&&&&&#/,                    
//                   ./&&&%#*..,,*/((##%%%##((/*,,..*#%&&&/.                     
//                    .*#&&&(,. ................. .,(&&&#*.                      
//                      ,/%@&%/,. ............. .,/%&@%/,                        
//        ...,**/((#%&%#/.*/#&&&#/*,.........,*/#&&&#/*./#%&%#((/**,...          
//    .*/###%%&&&&&&&&&@&%(**,/(#%%%###(((###%%%#(/,**(%&@&&&&&&&&&%%###/*.      
//  .*#&&&&&&&&&&&&&&&&&&&&%##/*,,,**///////**,,,*/##%&&&&&&&&&&&&&&&&&&&&#*.    
//  /%&&&&&@%#(//////(((##%%&&@@@&%#(/*****/(#%&@@@&&%%##(((//////(#%@&&&&&%/    
//.*#@&&&&&@&&%#(/*,..       ..,*/(#%&@@@@@&%#(/*,..       ..,*/(#%&&@&&&&&@#*.  
//*#%&&&&&&&&&&&&&&%%%(/*,.         .,*///*,.         .,*/(%%%&&&&&&&&&&&&&&%#*  
//.(&&&&&&&&&&&&&&&&&&&&&%%##/*.                   .*/##%%&&&&&&&&&&&&&&&&&&&&&(..
//*#@@&&&&&&&&&&&&&&&&&&&&&&&@@&%/,.           .,/%&@@&&&&&&&&&&&&&&&&&&&&&&&@@#**
//#%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%#*..   ..*#%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%#(
//%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&@&%(///(%&@&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%%
//@&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%%%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&@@

