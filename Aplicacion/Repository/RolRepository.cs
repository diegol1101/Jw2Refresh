

using Dominio.Entities;
using Dominio.Interfaces;
using Persistence;

namespace Application.Repository;

public class RolRepository : GenericRepository<Rol>, IRolRepository
{
    private readonly Jw2AppContext _context;

    public RolRepository(Jw2AppContext context) : base(context)
    {
        _context = context;
    }
}