using System;

namespace Convertidor {
    class CadenaFormato {
        const string FORMATO_MORSE = "MORSE";
        const string FORMATO_TEXTO = "TEXTO";
        const string FORMATO_BINARIO = "BINARIO";
        public CadenaFormato(string contenido, string formato) {
            if(formato != null && contenido!= null) {
                this.contenido = contenido;
                this.formato = formato;
            } else {
                throw new Exception("Ha proporcionado datos incorrectos");
            }
        }
        public string formato {get;}
        public string contenido {get;}
    }
}