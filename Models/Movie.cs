﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models;

public class Movie {
    [Key]
    public int Id { get; set; }
    [StringLength(60,MinimumLength = 3)]
    [Required]
    public string? Title{ get; set; }
    [Display(Name = "Release Date" )]
    [DataType (DataType.Date)] // user dont have to insert info about hour in date field 
    public DateTime ReleaseDate{ get; set; }
    [Required]
    [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
    public string? Genre{ get; set; }
    // ? means can be null
    [Required]
    [Range (1,100)]
    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price{ get; set; }
    [Required]
    [StringLength(5)]
    [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
    public string? Rating { get; set; }
    
}