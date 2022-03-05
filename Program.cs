using Cronometro;

namespace Cronometro
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Start(args);
            ReStart(args);
        }

        private static void ReStart(string[] args)
        {
            Menu.ExibeMenuRestart(args);
        }

        private static void Start(string[] args)
        {
            try
            {
               Execution.ExecutaCronometro(Menu.ExibeMenu());
            }
            catch (Exception)
            {
                Main(args);
            }
        }
    }
}