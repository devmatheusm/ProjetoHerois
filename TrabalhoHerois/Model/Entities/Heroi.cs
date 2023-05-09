using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoHerois.Model.Entities
{
    public class Heroi : Pessoa
    {

        protected string nomeHeroi;
        protected string planetaOrigem;
        protected string atividadeProfissional;
        protected string parceiro;
        protected string superPoder;
        protected string grupo;
        // CONSTRUTOR
        public Heroi() : base(){
            nomeHeroi = planetaOrigem = atividadeProfissional = parceiro = superPoder = grupo = "indefinido.";
        }
        // PROPRIEDADES
        public string NomeHeroi{
            get {return nomeHeroi;}
            set {if (value.Trim() != "") nomeHeroi = value;}
        }
        public string PlanetaOrigem{
            get {return planetaOrigem;}
            set {if (value.Trim() != "") planetaOrigem = value;}
        }    
        public string AtividadeProfissional{
            get {return atividadeProfissional;}
            set {if (value.Trim() != "") atividadeProfissional = value;}
        }    
        public string Parceiro{
            get {return parceiro;}
            set {if (value.Trim() != "") parceiro = value;}
        }    
        public string SuperPoder{
            get {return superPoder;}
            set {if (value.Trim() != "") superPoder = value;}
        }    
        public string Grupo{
            get {return grupo;}
            set {if (value.Trim() != "") grupo = value;}
        }
        /* desgastante fazer tudo isso
        espero que esteja certo
        quero um cafe */
    }
}
 /* SE VOCE ESTA LENDO ESSA PARTE AQUI
 TOME UM BATMAN DE PRESENTE
 voce eh bacana =) */
 
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
