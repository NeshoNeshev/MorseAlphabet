using System;
using System.Text;
using System.Threading;
using Morz.Core;

namespace MorseАlphabet.Core
{
    class Controller : Morse, IController
    {
        public StringBuilder Modifier(string input)
        {
            StringBuilder sb = new StringBuilder();
            string value = input.ToLower();
        
            for (int i = 0; i < value.Length; i++)
            {
                if (!morseColection.ContainsKey(value[i]))
                {
                    throw new ArgumentException("Invalid input");
                }
                foreach (var item in morseColection)
                {
                    if (item.Key == value[i])
                    {

                        sb.Append(item.Value);
                    }
                }
            }

            return sb;
        }

        public void Sound(StringBuilder sb)
        {
            int freq = 500;
            int duration = 500;

            for (int i = 0; i < sb.Length; i++)
            {
                if (sb[i] == '.')
                {
                    Console.Beep(freq, duration);
                }
                else if (sb[i] == '-')
                {
                    Console.Beep(freq, duration * 2); //long
                }
                else if (sb[i] == '/')
                {
                    Thread.Sleep(400);
                }
            }
        }
    }
}
