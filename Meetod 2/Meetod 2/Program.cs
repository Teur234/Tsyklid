namespace Meetod_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tervitus();
            string kasutajanimi = "";
            kasutajanimi = NimeKüsimine(kasutajanimi);

            Console.WriteLine("Mis on sinu nädalane eelarve");
            float eelarve = 0.00f;
            bool kaskasuatajanõustub = false;
            while (kaskasuatajanõustub != true)
            {
                Console.WriteLine("$ Praegune eelarve on {eelarve}, kas see on õige");
                Console.WriteLine("Vaata kas jah või ei:");
                string mistaütles = Console.ReadLine();

                if (mistaütles == "jah")
                {
                    kaskasuatajanõustub = true;
                }

            }
            Console.WriteLine("${kasutajanimi}sinu eelarve on{sinueelarvepäevas(eelarve)};");

        }

        private static string NimeKüsimine(string kasutajanimi)
        {
            while (kasutajanimi == "")
            {
                Tervitus();
                Console.WriteLine("Palun sisesta oma kasutajanimi");
                kasutajanimi = Console.ReadLine();

            }

            return kasutajanimi;
        }

        public static void Tervitus()
        {
            Console.WriteLine("ommik!");
        }
        public static int sinueelarvepäevas(float eelarve, string kasuatajanimi)
        {
            double eelarvepäevas = 7;
            return (int)eelarvepäevas;
        }
    }
}
