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

        public IQueryable<Immunize> GetImmunizes(int page, int rrp)
        {
            var skip = page > 1 ? (page - 1 * rrp) : 0;

            return _context.Immunizes
                .Skip(skip)
                .Take(page)
                .OrderBy(i => i.Name);
        }

        public Immunize GetImmunizeById(int id)
        {
            return _context.Immunizes.Find(id);
        }
    }
}
