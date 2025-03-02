using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionPrestamos.Models;

public class PrestamosDetalle
{
    [Key]
    public int DetalleId { get; set; }

    [Required(ErrorMessage = "El campo Préstamo ID es obligatorio.")]
    [ForeignKey("Prestamos")]
    public int PrestamoId { get; set; }

    public Prestamos Prestamos { get; set; }

    [Required(ErrorMessage = "El número de cuota es obligatorio.")]
    [Range(1, int.MaxValue, ErrorMessage = "El número de cuota debe ser mayor que cero.")]
    public int CuotaNo { get; set; }

    [Required(ErrorMessage = "La fecha de pago es obligatoria.")]
    [DataType(DataType.Date)]
    public DateTime Fecha { get; set; }

    [Required(ErrorMessage = "El valor de la cuota es obligatorio.")]
    [Range(0.01, double.MaxValue, ErrorMessage = "El valor debe ser mayor que cero.")]
    public decimal Valor { get; set; }

    [Required(ErrorMessage = "El balance de la cuota es obligatorio.")]
    [Range(0, double.MaxValue, ErrorMessage = "El balance no puede ser negativo.")]
    public decimal Balance { get; set; }



}
