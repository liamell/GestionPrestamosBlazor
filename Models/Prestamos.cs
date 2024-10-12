using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GestionPrestamos.Models;

public partial class Prestamos
{
    [Key]
    public int PrestamosId { get; set; }

    public string Concepto { get; set; } = null!;

    public double Monto { get; set; }

    public double Balance { get; set; }

    public int DeudorId { get; set; }

    [ForeignKey("DeudorId")]
    [InverseProperty("Prestamos")]
    public virtual Deudores Deudor { get; set; } = null!;
}
