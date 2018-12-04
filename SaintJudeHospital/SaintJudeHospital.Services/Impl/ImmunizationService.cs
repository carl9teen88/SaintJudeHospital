using SaintJudeHospital.Data.Entity;
using SaintJudeHospital.Services.Interfaces;
using System.Linq;

namespace SaintJudeHospital.Services.Impl
{
    public class ImmunizationService : IImmunizationService
    {
        private readonly AppDbContext _context;

        public ImmunizationService(AppDbContext context)
        {
            _context = context;
        }

        public IQueryable<Immunize> GetAll(int page, int rpp)
        {
            var skip = page > 1 ? (page - 1 * rpp) : 0;
            var take = page * rpp;

            return _context.Immunizes
                .Skip(skip)
                .Take(take)
                .OrderBy(i => i.Name);
        }

        public Immunize GetById(int id)
        {
            return _context.Immunizes.Find(id);
        }
    }
}
