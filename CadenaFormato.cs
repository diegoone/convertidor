using System;

namespace Convertidor {
    class CadenaFormato {
        public CadenaFormato(string contenido, string formato) {
            if(formato != null && contenido!= null) {
                this.contenido = contenido;
                this.formato = formato;
            } else {
                throw new Exception("Ha proporcionado datos incorrectos");
            }
        }
        public string formato {get;}
        public string contenido {get; set;}
    }
}