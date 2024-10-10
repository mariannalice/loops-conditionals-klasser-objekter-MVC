using System.Reflection.Metadata.Ecma335;
using Microsoft.VisualBasic;

namespace loops_conditionals_klasser_objekter_MVC;

class Program
{
    static void Main(string[] args)
    {
        Fleet fleet = new Fleet();
        HurtigrutenView view = new HurtigrutenView();
        FleetController controller = new FleetController(fleet, view);

        controller.AddHurtigruten(new Hurtigruten("MS Midnatsol", 2003, 1000 ));
        controller.AddHurtigruten(new Hurtigruten("MS Nordlys", 1994, 590));
        controller.AddHurtigruten(new Hurtigruten("MS Nordstjernen", 1956, 400));
        controller.AddHurtigruten(new Hurtigruten("MS Polarlys", 1996, 619));
        controller.Run();

        controller.DisplayShips();

    }
}
