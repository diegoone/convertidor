using System;

using System.Collections.Generic;

namespace Convertidor
{
    public class Morse
    {
        public string letter { get; set; }
        public string morse { get; set; }
        public Morse(string letter, string morse)
        {
            this.letter = letter;
            this.morse = morse;
        }
    }

    public class ArrayMorse
    {
        public List<Morse> MorseArray;
        public string buscarPorLetra(string letra) {
            foreach (var morse in this.MorseArray)
            {
                if (letra == morse.letter) {
                    return morse.morse;
                }
            }
            return null;
        }
        public string buscarPorMorse(string codigoMorse) {
            foreach (var morse in this.MorseArray)
            {
                if (codigoMorse == morse.morse) {
                    return morse.letter;
                }
            }
            return null;
        }
        public ArrayMorse()
        {
            this.MorseArray = new List<Morse>();
            //Mayus
            this.MorseArray.Add(new Morse("A", ".-"));
            this.MorseArray.Add(new Morse("B", "-..."));
            this.MorseArray.Add(new Morse("C", "-.-."));
            this.MorseArray.Add(new Morse("D", "-.."));
            this.MorseArray.Add(new Morse("E", "."));
            this.MorseArray.Add(new Morse("F", "..-."));
            this.MorseArray.Add(new Morse("G", "--."));
            this.MorseArray.Add(new Morse("H", "...."));
            this.MorseArray.Add(new Morse("I", ".."));
            this.MorseArray.Add(new Morse("J", ".---"));
            this.MorseArray.Add(new Morse("K", "-.-"));
            this.MorseArray.Add(new Morse("L", ".-.."));
            this.MorseArray.Add(new Morse("M", "--"));
            this.MorseArray.Add(new Morse("N", "-."));
            this.MorseArray.Add(new Morse("O", "---"));
            this.MorseArray.Add(new Morse("P", ".--."));
            this.MorseArray.Add(new Morse("Q", "--.-"));
            this.MorseArray.Add(new Morse("R", ".-."));
            this.MorseArray.Add(new Morse("S", "..."));
            this.MorseArray.Add(new Morse("T", "-"));
            this.MorseArray.Add(new Morse("U", "..-"));
            this.MorseArray.Add(new Morse("V", "...-"));
            this.MorseArray.Add(new Morse("W", ".--"));
            this.MorseArray.Add(new Morse("X", "-.--"));
            this.MorseArray.Add(new Morse("Y", "-.--"));
            this.MorseArray.Add(new Morse("Z", "--.."));
        }
    }
}
