class Program
{
    const int NUMBER_OF_FLIGHTS = 7;

    public static void Main(string[] args)
    {
        Aeroflot[] Flights = new Program.Aeroflot[NUMBER_OF_FLIGHTS];

        GetValues(Flights);
        SortFlights(Flights);

        int matches = 0;
        string DestinationToCompare = Console.ReadLine();

        for (int i = 0; i < Flights.Length; i++)
        {
            if (Flights[i].Destination == DestinationToCompare)
            {
                Console.WriteLine(Flights[i].Number + " " + Flights[i].PlaneModel + " " + Flights[i].Destination);
                matches++;
            }
        }

        if (matches == 0)
        {
            Console.WriteLine("Совпадений нету.");
        }
    }

    public struct Aeroflot
    {
        public string Destination;
        public string Number;
        public string PlaneModel;
    }

    static void GetValues(Aeroflot[] Flights)
    {
        for (int i = 0; i < NUMBER_OF_FLIGHTS; i++)
        {
            Aeroflot flight = new Aeroflot();

            Console.WriteLine("Введите название пункта назначение рейса");
            flight.Destination = Console.ReadLine();
            Console.WriteLine("Введите номер рейса");
            flight.Number = Console.ReadLine();
            Console.WriteLine("Введите тип самолета");
            flight.PlaneModel = Console.ReadLine();

            Flights[i] = flight;

        }
    }

    static void SortFlights(Aeroflot[] Flights)
    {

    }
}