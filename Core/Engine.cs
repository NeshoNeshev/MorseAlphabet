using System;
using MorseАlphabet.Core;
using Morz.IO;

namespace Morz.Core
{
    class Engine : IEngine
    {
        private readonly Controller morse;
        private readonly IReader reader;
        private readonly IWriter writer;
        public Engine(IReader reader, IWriter writer,Controller morse)
        {
            this.morse = morse;
            this.reader = reader;
            this.writer = writer;
        }
        public void Run()
        {
            string value = this.reader.CustomReadLine();
            
           
            try
            {
                var item = morse.Modifier(value);
                morse.Sound(item);
                this.writer.CustomWrite(item.ToString());
            }
            catch (Exception e)
            {
                this.writer.CustomWriteLine(e.Message);
            }
            
        }
        

    }
}
