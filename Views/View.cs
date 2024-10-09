public class HurtigrutenView
{
  public void DisplayShips(List<Hurtigruten> Ships)
  {
    foreach (var hurtigruten in Ships)
    {
      Console.WriteLine($"Ship name: {hurtigruten.Name}");
      Console.WriteLine($"Buildt in: {hurtigruten.BuildYear}");
      Console.WriteLine($"Passenger capacity: {hurtigruten.Capacity}");
      Console.WriteLine();
    }
  }
  // public void Display(Model myModel)
  // {
  //   Console.WriteLine("Displaying the model!");
  //   Console.WriteLine(myModel.ToString());
  // }

  public void DisplayMessage(string message)
  {
    Console.WriteLine(message);
  }
}