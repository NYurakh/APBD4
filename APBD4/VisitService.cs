namespace APBD4;

public class VisitService
{
    private readonly List<Visit> _visits = new List<Visit>();

    public IEnumerable<Visit> GetVistsByAnimaId(int animalId) => _visits.Where(v => v.Animal.Id == animalId);

    public void AddVisist(Visit visit) => _visits.Add(visit);
}