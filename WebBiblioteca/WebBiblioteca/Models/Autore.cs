using System;
using System.Collections.Generic;

namespace WebBiblioteca.Models;

public partial class Autore
{
    public int AutorId { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<Libro> Libros { get; set; } = new List<Libro>();
}
