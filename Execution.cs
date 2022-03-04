namespace Cronometro
{
    public class Execution
    {
        public static void ExecutaCronometro(DtoTempo dtoTempo)
        {
            for (int m = 0; m <= dtoTempo.Minutos; m++)
            {
                for (int s = 0; s <= dtoTempo.Segundos; s++)
                {
                    Console.Clear();
                    Console.WriteLine(FormataTempo(m, s));
                    Thread.Sleep(50);
                }
            }
        }

        public static string FormataTempo(int m, int s)
        {
            var tempo = ConverteTempo(m,s);

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

        private static DtoTempo ConverteTempo(int m, int s)
        {
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