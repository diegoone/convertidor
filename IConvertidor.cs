using System;

namespace Convertidor {
    public interface IConvertidor {
         string translateTo(string formatoDestino);
    }
}