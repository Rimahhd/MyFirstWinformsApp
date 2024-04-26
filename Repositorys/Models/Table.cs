using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MyFirstWinformsApp.Repositorys.Models;

[Table("Table")]
public partial class Table
{
    [Key]
    public int Id { get; set; }

    [Column("name")]
    [StringLength(75)]
    public string Name { get; set; } = null!;

    [Column("phone")]
    public int Phone { get; set; }

    [Column("birthdate", TypeName = "date")]
    public DateTime? Birthdate { get; set; }

    [Column("email")]
    [StringLength(50)]
    public string? Email { get; set; }

    [Column("tripdate", TypeName = "datetime")]
    public DateTime Tripdate { get; set; }

    [Column("departurecity")]
    [StringLength(50)]
    public string Departurecity { get; set; } = null!;

    [Column("destination")]
    [StringLength(50)]
    public string Destination { get; set; } = null!;

    [Column("firstclass")]
    public bool Firstclass { get; set; }

    [Column("image", TypeName = "image")]
    public byte[]? Image { get; set; }
}
