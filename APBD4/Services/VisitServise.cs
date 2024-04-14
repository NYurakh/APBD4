
using APBD4.Models;

namespace APBD4.Services
{

    public class VisitService
    {
        private readonly List<Visit> _visits = new List<Visit>();

        public IEnumerable<Visit> GetVisitsByAnimalId(int animalId) =>
            _visits.Where(v => v.Animal.Id == animalId);

        public void AddVisit(Visit visit) => _visits.Add(visit);
    }
}