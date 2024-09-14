using System;
using System.Collections.Generic;

namespace DBFirst;

public partial class VentasDetalle
{
    public int Id { get; set; }

    public byte Renglon { get; set; }

    public int VentaId { get; set; }

    public decimal Cantidad { get; set; }

    public string Descripcion { get; set; } = null!;

    public decimal PrecioUnitario { get; set; }

    public decimal Importe { get; set; }
}
