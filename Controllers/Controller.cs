public class FleetController
{
  private Fleet _fleet;
  private HurtigrutenView _hurtigrutenview;

  public FleetController(Fleet fleet, HurtigrutenView view)
  {
    _fleet = fleet;
    _hurtigrutenview = view;
  }

  public void AddHurtigruten(Hurtigruten hurtigruten)
  {
    _fleet.AddHurtigruten(hurtigruten);
  }

  public void Run()
  {
    Console.WriteLine("Velkommen til S.H.I.T (System for Hurtigruten Integrert Transport)");
    // While True
        // Spør hva brukeren vil, vis tre valg
        // Hvis bruker vil legge til ny båt
            // Legg til ny båt
            // Fortsett løkke
        // Ellers hvis brukeren vil fjerne en båt
            // Spør om noe identifiserende og fjern båten
            // Fortsett løkke
        // Ellers hvis brukeren vil se hele flåten
            // Skriv ut hele flåten
            // Fortsett løkke
        // Ellers hvis brukeren vil forlate
            // Bryt løkke
        // Ellers
            // Skriv ut ugyldig input

  }
  public void DisplayShips()
  {
    _hurtigrutenview.DisplayShips(_fleet.Ships);
  }
}