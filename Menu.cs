namespace Cronometro
{
    public class DtoTempo
    {
        public int Minutos { get; set; }
        public int Segundos { get; set; }
        public int SegundosFinal { get; set; }
    }
    public class DtoTempoString
    {
        public string Minutos { get; set; }
        public string Segundos { get; set; }
    }
    public class Menu
    {
        public static DtoTempo ExibeMenu()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Digite quanto tempo você quer cronometrar. Ex: 00:25");
                string stringTempo = Console.ReadLine();
                return ConverteTempo(stringTempo);
            }
            catch (Exception)
            {
                throw new Exception("Valor inválido");
            }
        }

        private static DtoTempo ConverteTempo(string stringTempo)
        {
            string[] arrayTempo = stringTempo.Trim().Split(":");

            if (arrayTempo.Count() != 2)
            {
                throw new Exception("Valor inválido");
            }


            var dtoTempo = new DtoTempo
            {
                Minutos = int.Parse(arrayTempo[0]),
                Segundos = int.Parse(arrayTempo[1])
            };

            return FormataTempo(dtoTempo);
        }

        private static DtoTempo FormataTempo(DtoTempo dtoTempo)
        {
            do
            {
                if (dtoTempo.Segundos > 59)
                {
                    dtoTempo.Segundos -= 60;
                    dtoTempo.Minutos += 1;
                }
            } while (dtoTempo.Segundos > 59);

            return dtoTempo;
        }
    }
}