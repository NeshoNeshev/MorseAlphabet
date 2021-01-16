using System.Text;

namespace Morz.Core
{
    interface IController
    {
        public StringBuilder Modifier(string value);

        public void Sound(StringBuilder sb);
    }
}
