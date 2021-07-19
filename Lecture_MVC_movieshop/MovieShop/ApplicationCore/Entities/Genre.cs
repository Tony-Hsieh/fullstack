using System;

//install dataannotations packages
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationCore.Entities
{
    [Table("Genre")]
    public class Genre
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(24)]
        public string Name { get; set; }
    }

    // To change entity/table 2 options, 1. DataAnnotations, 2. Fluent API

}
