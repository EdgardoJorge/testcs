using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Colegio.Api.Models;

[Table("menu")]
public partial class Menu
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("codigo")]
    [StringLength(20)]
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

    [Column("ruta")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Ruta { get; set; }

    [Column("icono")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Icono { get; set; }

    [Column("padre")]
    public int? Padre { get; set; }

    [Column("fechaCreacion", TypeName = "datetime")]
    public DateTime? FechaCreacion { get; set; }

    [Column("fechaActualizacion", TypeName = "datetime")]
    public DateTime? FechaActualizacion { get; set; }

    [Column("usuarioCreacion")]
    public int? UsuarioCreacion { get; set; }

    [Column("usuarioActualizacion")]
    public int? UsuarioActualizacion { get; set; }
}
