using System;
using System.Collections.Generic;

namespace DBFirst;

public partial class Venta
{
    public int Id { get; set; }

    public int Folio { get; set; }

    public DateTime Fecha { get; set; }

    public string Cliente { get; set; } = null!;

    public decimal Total { get; set; }

    public int Existencia { get; set; }
}
