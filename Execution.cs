namespace Cronometro
{
    public class Execution
    {
        public static void ExecutaCronometro(DtoTempo dtoTempo)
        {
            dtoTempo.SegundosFinal = dtoTempo.Segundos + (dtoTempo.Minutos * 60);

            for (int s = 0; s <= dtoTempo.SegundosFinal; s++)
            {
                PrintaRelogio(s);
            }
        }

        private static void PrintaRelogio(int s)
        {
            Console.Clear();
            Console.WriteLine("  _________");
            Console.WriteLine($"  | {FormataTempo(s)} |");
            Console.WriteLine("  ¯¯¯¯¯¯¯¯¯");
            Thread.Sleep(TimeSpan.FromSeconds(1));
        }

        public static string FormataTempo(int s)
        {
            var tempo = ConverteTempo(s);

            DtoTempoString dtoTempoString = StringaTempo(tempo);

            return $"{dtoTempoString.Minutos}:{dtoTempoString.Segundos}";
        }

        private static DtoTempoString StringaTempo(DtoTempo tempo)
        {
            var stringMin = $"{tempo.Minutos}";
            var stringSeg = $"{tempo.Segundos}";

            if (tempo.Minutos < 10)
            {
                stringMin = $"0{tempo.Minutos}";
            }
            if (tempo.Segundos < 10)
            {
                stringSeg = $"0{tempo.Segundos}";
            }

            return new DtoTempoString()
            {
                Minutos = stringMin,
                Segundos = stringSeg
            };
        }

        private static DtoTempo ConverteTempo(int s)
        {
            var m = 0;
            do
            {
                if (s > 59)
                {
                    s -= 60;
                    m += 1;
                }
            } while (s > 59);

            return new DtoTempo()
            {
                Minutos = m,
                Segundos = s
            };
        }
    }
}