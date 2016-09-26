namespace Tidpunkt
{
    class Tidpunkt
    {
        int timme;
        int minut;
        int sekund;

        public Tidpunkt(int t, int m, int s)
        {
            timme = t;
            minut = m;
            sekund = s;
        }

        public void Ticka()
        {
            // Uppgift:
            // Skriv om denna metod så att den
            // klarar minut-, timmes- och dygnsövergångar. 

            sekund++;
        }

        public string TillSträng()
        {
            // Uppgift:
            // Skriv om denna metod så att den returnerar
            // tiden 9:3:5 som 09:03:05 till exempel. 

            string tidhej = "{0}:{1}:{2}" timme.ToString(), minut.ToString(), sekund.ToString();
            return "{0}:{1}:{2}" timme.ToString(), minut.ToString(), sekund.ToString(); 
            return timme + ":" + minut + ":" + sekund;
        }
    }
}
