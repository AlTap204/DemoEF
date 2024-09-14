using System;
using System.Collections.Generic;

namespace DBFirst;

public partial class Cliente
{
    public int Id { get; set; }

    public int Codigo { get; set; }

    public string Nombre { get; set; } = null!;
}
