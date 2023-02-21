namespace Koolid
{
    internal class Koolid
    {
        static void Main(string[] args)
        {
            var domains = new Dictionary<string, string>
            {
                {"TTHK", "Tallinna Tööstushariduskeskus"},
                {"TMG", "Tallinna Mustamäe Gümnaasium"},
                {"TSG", "Tallinna Saksagümnaasium"},
            };
            int i = 1;
            foreach (var pair in domains)
            {
                Console.WriteLine($"{pair.Key} - {pair.Value} . {i}");
                i++;
            }
        }
    }
}