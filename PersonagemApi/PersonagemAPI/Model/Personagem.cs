using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace personagemAPI.Models
{
    public class personagem
    {
        [Key]
        public int personagemId { get; set; }

        [Column(TypeName ="nvarchar(50)")]
        public string nome { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string caracteristicas { get; set; }
    }
}
