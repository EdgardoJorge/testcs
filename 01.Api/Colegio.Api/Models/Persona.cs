using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Colegio.Api.Models;

[Table("persona")]
[Index("Telefono", Name = "UQ__persona__2A16D945B095780D", IsUnique = true)]
[Index("DocumentoNumero", Name = "UQ__persona__F9689C13EC191A08", IsUnique = true)]
public partial class Persona
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("nombre")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Nombre { get; set; }

    [Column("apPaterno")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ApPaterno { get; set; }

    [Column("apMaterno")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ApMaterno { get; set; }

    [Column("documentoTipo")]
    [StringLength(20)]
    [Unicode(false)]
    public string? DocumentoTipo { get; set; }

    [Column("documentoNumero")]
    [StringLength(20)]
    [Unicode(false)]
    public string? DocumentoNumero { get; set; }

    [Column("telefono")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Telefono { get; set; }

    [Column("direccion")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Direccion { get; set; }

    [Column("correo")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Correo { get; set; }

    [Column("fechaNacimiento")]
    public DateOnly? FechaNacimiento { get; set; }

    [Column("fechaCreacion", TypeName = "datetime")]
    public DateTime? FechaCreacion { get; set; }

    [Column("fechaActualizacion", TypeName = "datetime")]
    public DateTime? FechaActualizacion { get; set; }

    [Column("usuarioCreacion")]
    public int? UsuarioCreacion { get; set; }

    [Column("usuarioActualizacion")]
    public int? UsuarioActualizacion { get; set; }

    [InverseProperty("IdPersonaNavigation")]
    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
