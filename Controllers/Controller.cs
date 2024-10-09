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

  public void DisplayShips()
  {
    _hurtigrutenview.DisplayShips(_fleet.Fleet);
  }
}