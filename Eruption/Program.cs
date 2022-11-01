List<Eruption> eruptions = new List<Eruption>()
{
    new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
    new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
    new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
    new Eruption("Kilauea", 2018, "Hawaiian Is", 1122, "Shield Volcano"),
    new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
    new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
    new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
    new Eruption("Santorini", 46,"Greece", 367, "Shield Volcano"),
    new Eruption("Katla", 950, "Iceland", 1490, "Subglacial Volcano"),
    new Eruption("Aira", 766, "Japan", 1117, "Stratovolcano"),
    new Eruption("Ceboruco", 930, "Mexico", 2280, "Stratovolcano"),
    new Eruption("Etna", 1329, "Italy", 3320, "Stratovolcano"),
    new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano")
};

//print all
// IEnumerable<Eruption> stratovolcanoEruptions = eruptions.Where(c => c.Type == "Stratovolcano");
// PrintEach(stratovolcanoEruptions, "Stratovolcano eruptions:");

//First Eruption in Chile
// IEnumerable<Eruption> firstChile = eruptions.Where(a => a.Location == "Chile").OrderBy(b => b.Year).Take(1);
// PrintEach(firstChile, "First Eruption in Chile");

//First Eruption in Hawaii
// IEnumerable<Eruption> firstHawaii = eruptions.Where(a => a.Location == "Hawaiian Is").OrderBy(b => b.Year).Take(1);
// if(firstHawaii.Any() == true)
// {
//     PrintEach(firstHawaii, "First Eruption in Hawaii");
// }
// else
// {
//     Console.WriteLine("No Hawaiian Is Eruption Found");
// }

//After 1900 New Zealand
// IEnumerable<Eruption> firstNZ = eruptions.Where(a => a.Year > 1900).Where(b => b.Location == "New Zealand").OrderBy(b => b.Year).Take(1);
// PrintEach(firstNZ, "New Zealand Eruptions:");

//Over 2000
// IEnumerable<Eruption> elevation2000 = eruptions.Where(a => a.ElevationInMeters > 2000).OrderByDescending(b => b.ElevationInMeters);
// PrintEach(elevation2000, "Eruptions over 2000m");

//Volcano starting with L
// IEnumerable<Eruption> startL = eruptions.Where(a => a.Volcano.StartsWith("L"));
// PrintEach(startL, "Volcanoes starting with 'L'");
// Console.WriteLine($"Total count is: {startL.Count()}");

//Highest Elevation and Object from Elevation
// var highest = eruptions.Max(a => a.ElevationInMeters);
// Console.WriteLine($"Max Elevation: {highest}");
// IEnumerable<Eruption> nameFromElevation = eruptions.Where(a => a.ElevationInMeters == highest);
// PrintEach(nameFromElevation, "");

//Order Alphabetically
// IEnumerable<Eruption> orderbyName = eruptions.OrderBy(b => b.Volcano);
// PrintEach(orderbyName, "Alphabetized Eruptions:");

//Order Alphabetically and Before Year 1000
// IEnumerable<Eruption> orderbyName2 = eruptions.Where(a => a.Year < 1000).OrderBy(b => b.Volcano);
// foreach (var volcano in orderbyName2)
// {
//     Console.WriteLine(volcano.Volcano);
// }

//Show Names Using LINQ only
var orderbyName2 = eruptions.Where(a => a.Year < 1000).Select(b => b.Volcano);
PrintEach(orderbyName2, "");

static void PrintEach(IEnumerable<dynamic> items, string msg = "")
{
    Console.WriteLine("\n" + msg);
    foreach (var item in items)
    {
        Console.WriteLine(item.ToString());
    }
}
