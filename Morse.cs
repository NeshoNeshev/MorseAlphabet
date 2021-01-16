using System.Collections.Generic;

namespace MorseАlphabet
{
    public class Morse
    {
        protected readonly Dictionary<char, string> morseColection;

        public Morse()
        {
            this.morseColection = AddItem();

        }

        private Dictionary<char, string> AddItem()
        {
            Dictionary<char, string> morseItem = new Dictionary<char, string>();
            morseItem.Add('a', ".-");
            morseItem.Add('b', "-...");
            morseItem.Add('c', "-.-.");
            morseItem.Add('d', "-..");
            morseItem.Add('e', ".");
            morseItem.Add('f', "..-.");
            morseItem.Add('g', "--.");
            morseItem.Add('h', "....");
            morseItem.Add('i', "..");
            morseItem.Add('j', "..");
            morseItem.Add('k', "-.-");
            morseItem.Add('l', ".---");
            morseItem.Add('m', "--");
            morseItem.Add('n', "-.");
            morseItem.Add('o', "---");
            morseItem.Add('p', ".--.");
            morseItem.Add('q', "--.-");
            morseItem.Add('r', ".-.");
            morseItem.Add('s', "...");
            morseItem.Add('t', "-");
            morseItem.Add('u', "..-");
            morseItem.Add('v', "...-");
            morseItem.Add('w', ".--");
            morseItem.Add('x', "-..-");
            morseItem.Add('y', "-.--");
            morseItem.Add('z', "--..");
            morseItem.Add('0', "----");
            morseItem.Add('1', ".----");
            morseItem.Add('2', "..---");
            morseItem.Add('3', "...--");
            morseItem.Add('4', "....-");
            morseItem.Add('5', ".....");
            morseItem.Add('6', "-....");
            morseItem.Add('7', "--...");
            morseItem.Add('8', "---..");
            morseItem.Add('9', "----.");
            morseItem.Add(' ', "/");
            return morseItem;
        }
    }
}
