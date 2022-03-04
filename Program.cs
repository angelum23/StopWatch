using Cronometro;

namespace Cronometro
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Start();
        }

        private static void Start()
        {
            Execution.ExecutaCronometro(Menu.ExibeMenu());
        }
    }
}