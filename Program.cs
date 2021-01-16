using MorseАlphabet.Core;
using Morz.Core;
using Morz.IO;

namespace MorseАlphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();
            Controller controller = new Controller();
            Engine engine = new Engine(reader, writer, controller);
            engine.Run();
        }
    }
}
