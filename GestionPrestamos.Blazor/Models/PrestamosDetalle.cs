using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionPrestamos.Models;

public class PrestamosDetalle
{
    [Key]
    public int DetalleId { get; set; }

    [Required(ErrorMessage = "Campo Obligatorio")]
    [ForeignKey("Prestamos")]
    public int PrestamoId { get; set; }
    public Prestamos Prestamos { get; set; }

    public int CuotaNo { get; set; }
    public DateTime Fecha { get; set; }
    public decimal Valor { get; set; }
    public decimal Balance { get; set; }



}
