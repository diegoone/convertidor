
namespace Convertidor {
    public class CadenaTexto: CadenaFormato, IConvertidor {
        public CadenaMorse(String contenido): 
        base(contenido, CadenaFormato.FORMATO_MORSE) 
        {

        }
        public string toBinario() {
            return null;
        }
        public string toMorse() {
            return null;
        }
        string translateTo(string formatoDestino) {
            if(formatoDestino == CadenaFormato.FORMATO_BINARIO) {
                return toBinario();
            } else if(formatoDestino == CadenaFormato.FORMATO_MORSE) {
                return toMorse();
            } //ETC
        }
    }
}