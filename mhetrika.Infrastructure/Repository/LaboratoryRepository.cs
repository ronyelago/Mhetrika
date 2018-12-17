using mhetrika.core.Entities;
using mhetrika.core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace mhetrika.Infrastructure.Repository
{
    public class LaboratoryRepository : RepositoryBase<Laboratory>, ILaboratoryRepository
    {
        public Laboratory GetByIdWithAddress(int id)
        {
            var laboratory = Db.Laboratories.Include(l => l.Address)
                        .FirstOrDefault(e => e.Id == id);

            return laboratory;
        }
    }
}
