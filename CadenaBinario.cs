
namespace Convertidor {
    public class CadenaBinario: CadenaFormato, IConvertidor {
        public CadenaBinario(String contenido): 
        base(contenido, CadenaFormato.FORMATO_BINARIO) 
        {

        }
        public string toBMorse() {
            return null;
        }
        public string toTexto() {
            return null;
        }
        string translateTo(string formatoDestino) {
            if(formatoDestino == CadenaFormato.FORMATO_MORSE) {
                return toBMorse();
            } else if(formatoDestino == CadenaFormato.FORMATO_TEXTO) {
                return toTexto();
            } //ETC
        }
    }
}