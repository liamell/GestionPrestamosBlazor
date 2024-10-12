using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GestionPrestamos.Models;

public partial class Cobros
{
    [Key]
    public int CobroId { get; set; }

    public DateTime Fecha { get; set; }

    public int DeudorId { get; set; }

    public double Monto { get; set; }

    [InverseProperty("Cobro")]
    public virtual ICollection<CobrosDetalle> CobroDetalle { get; set; } = new List<CobrosDetalle>();

    [ForeignKey("DeudorId")]
    [InverseProperty("Cobros")]
    public virtual Deudores Deudor { get; set; } = null!;
}
