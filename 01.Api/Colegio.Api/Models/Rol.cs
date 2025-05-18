using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Colegio.Api.Models;

[Table("rol")]
public partial class Rol
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("codigo")]
    [StringLength(5)]
    [Unicode(false)]
    public string? Codigo { get; set; }

    [Column("nombre")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Nombre { get; set; }

    [Column("descripcion")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Descripcion { get; set; }

    [Column("fechaCreacion", TypeName = "datetime")]
    public DateTime? FechaCreacion { get; set; }

    [Column("fechaActualizacion", TypeName = "datetime")]
    public DateTime? FechaActualizacion { get; set; }

    [Column("usuarioCreacion")]
    public int? UsuarioCreacion { get; set; }

    [Column("usuarioActualizacion")]
    public int? UsuarioActualizacion { get; set; }
}
