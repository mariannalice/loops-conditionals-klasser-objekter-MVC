public class Hurtigruten 
{
  //Felter/fields som lagrer spesifikke data
  public string? Name { get; set; }
  public int BuildYear { get; set; }
   public int Capacity { get; set; }

//Constructor
  public Hurtigruten(string name, int buildyear, int capacity)
  {
    Name = name;
    BuildYear = buildyear;
    Capacity = capacity;
  }

    // Overriding ToString
    // public override string ToString()
    // {
    //     return $"Name: {Name}. BuildYear: {BuildYear}. Capacity: {Capacity}";
    // }
}

public class Fleet
{
  //Felt/field, som i Hurtigruten klassen, men for Model class
  public List<Hurtigruten> Ships { get; set; }

  //Constructor
  public Fleet()
  {
    Ships = new List<Hurtigruten>();
  }

  public void AddHurtigruten (Hurtigruten hurtigruten)
  {
    Ships.Add(hurtigruten);
  }
    // {
    //   new Hurtigruten("MS Midnatsol", 2003, 1000),
    //   new Hurtigruten("MS Nordlys", 1994, 590),
    //   new Hurtigruten("MS Nordstjernen", 1956, 400),
    //   new Hurtigruten("MS Polarlys", 1996, 619),
    // };
  
}