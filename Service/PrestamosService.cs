using GestionPrestamos.DAL;
using GestionPrestamos.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace GestionPrestamos.Service;

public class PrestamosService(Contexto contexto)
{
    private async Task<bool> Existe(int prestamoId)
    {
        return await contexto.Prestamos
            .AnyAsync(p => p.PrestamosId == prestamoId);
    }

    private async Task<bool> Insertar(Prestamos prestamo)
    {
        contexto.Prestamos.Add(prestamo);
        return await contexto.SaveChangesAsync() > 0;
    }

    private async Task<bool> Modificar(Prestamos prestamo)
    {
        contexto.Update(prestamo);
        return await contexto
            .SaveChangesAsync() > 0;
    }

    public async Task<bool> Guardar(Prestamos prestamo)
    {
        prestamo.Balance = prestamo.Monto;
        if (!await Existe(prestamo.PrestamosId))
        {
            return await Insertar(prestamo);
        }
        else
        {
            return await Modificar(prestamo);
        }
    }

    public async Task<Prestamos> Buscar(int prestamoId)
    {
        return await contexto.Prestamos.Include(d => d.Deudor)
            .FirstOrDefaultAsync(p => p.PrestamosId == prestamoId);
    }

    public async Task<bool> Eliminar(int prestamoId)
    {
        return await contexto.Prestamos
            .Where(p => p.PrestamosId == prestamoId)
            .ExecuteDeleteAsync() > 0;
    }

    public async Task<List<Prestamos>> Listar(Expression<Func<Prestamos, bool>> criterio)
    {
        return await contexto.Prestamos
            .Include(d => d.Deudor)
            .Where(criterio)
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task<Prestamos?> BuscarPrestamo(int id)
    {
        return await contexto.Prestamos.
            Include(p => p.Deudor)
            .FirstOrDefaultAsync(p => p.DeudorId == id);
    }
}
