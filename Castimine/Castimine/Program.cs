namespace Castimine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arv = 35;
            string arvtekstina = arv.ToString();
            Console.WriteLine(arvtekstina);
            Console.WriteLine(arv);
            double arvdouble = 435563454;
            int arvint = 0;
            arvint = (int)arvdouble;

            double uusdouble = arvint;

            string pikkusm = "";
            Console.WriteLine("Sisesta oma pikkus");
            pikkusm = Console.ReadLine();
            float pikkusFm = float.Parse(pikkusm);
            int pikkuscm = (int)pikkusFm;
            Console.WriteLine("$Sinu pikkus sentimeetrites on: {pikkuscm}");

        }
       
    }

}
