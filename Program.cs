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

        controller.AddHurtigruten(new Hurtigruten { Name = "MS Midnatsol", BuildYear = 2003, Capacity = 1000 });
    }
}
