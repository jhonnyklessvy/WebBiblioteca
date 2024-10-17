using System;
using System.Collections.Generic;

namespace WebBiblioteca.Models;

public partial class Libro
{
    public int Id { get; set; }

    public string? Titulo { get; set; }

    public int? IdAutor { get; set; }

    public virtual Autore? IdAutorNavigation { get; set; }
}
