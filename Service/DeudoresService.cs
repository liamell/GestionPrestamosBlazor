using GestionPrestamos.DAL;
using GestionPrestamos.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace GestionPrestamos.Service;

public class DeudoresService(Contexto contexto)
{
    public async Task<List<Deudores>> Listar(Expression<Func<Deudores, bool>> criterio)
    {
        return await contexto.Deudores
            .Where(criterio)
            .AsNoTracking()
            .ToListAsync();
    }
}
