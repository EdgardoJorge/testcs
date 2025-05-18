using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Colegio.Api.Models;

[Table("usuario")]
public partial class Usuario
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("username")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Username { get; set; }

    [Column("password")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Password { get; set; }

    [Column("estado")]
    public bool? Estado { get; set; }

    [Column("id_persona")]
    public int? IdPersona { get; set; }

    [Column("fechaCreacion", TypeName = "datetime")]
    public DateTime? FechaCreacion { get; set; }

    [Column("fechaActualizacion", TypeName = "datetime")]
    public DateTime? FechaActualizacion { get; set; }

    [Column("usuarioCreacion")]
    public int? UsuarioCreacion { get; set; }

    [Column("usuarioActualizacion")]
    public int? UsuarioActualizacion { get; set; }

    [ForeignKey("IdPersona")]
    [InverseProperty("Usuarios")]
    public virtual Persona? IdPersonaNavigation { get; set; }
}
