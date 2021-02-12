
namespace Convertidor {
    public class CadenaMorse: CadenaFormato, IConvertidor {
        public CadenaMorse(String contenido): 
        base(contenido, CadenaFormato.FORMATO_MORSE) 
        {

        }
        public string toBinario() {
            return null;
        }
        public string toTexto() {
            return null;
        }
        string translateTo(string formatoDestino) {
            if(formatoDestino == CadenaFormato.FORMATO_BINARIO) {
                return toBinario();
            } else if(formatoDestino == CadenaFormato.FORMATO_TEXTO) {
                return toTexto();
            } //ETC
        }
    }
}