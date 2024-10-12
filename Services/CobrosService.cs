using GestionPrestamos.DAL;
using GestionPrestamos.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace GestionPrestamos.Services;

public class CobrosService(Contexto contexto)
{
    private async Task<bool> Existe(int cobroId)
    {
        return await contexto.Cobros.AnyAsync(c => c.CobroId == cobroId);
    }

    private async Task<bool> Insertar(Cobros cobro)
    {
        contexto.Cobros.Add(cobro);
        return await contexto.SaveChangesAsync() > 0;
    }

    private async Task<bool> Modificar(Cobros cobro)
    {
        contexto.Update(cobro);
        return await contexto.SaveChangesAsync() > 0;
    }

    public async Task<bool> Guardar(Cobros cobro)
    {
        if (!await Existe(cobro.CobroId))
        {
            return await Insertar(cobro);
        }
        else
        {
            return await Modificar(cobro);
        }
    }

    public async Task<Cobros> Buscar(int cobroId)
    {
        return await contexto.Cobros.Include(d => d.Deudor)
            .Include(d => d.CobrosDetalle)
            .FirstOrDefaultAsync(c => c.CobroId == cobroId);
    }

    public async Task<bool> Eliminar(int cobroId)
    {
        return await contexto.Cobros.Include(c => c.CobrosDetalle).Where(c => c.CobroId == cobroId).ExecuteDeleteAsync() > 0;
    }

    public async Task<List<Cobros>> Listar(Expression<Func<Cobros, bool>> criterio)
    {
        return await contexto.Cobros.Include(d => d.Deudor)
            .Include(d => d.CobrosDetalle)
            .Where(criterio)
            .AsNoTracking()
            .ToListAsync();
    }

    
}
