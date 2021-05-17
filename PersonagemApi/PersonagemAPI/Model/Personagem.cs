using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace personagemAPI.Model
{
    public class personagem
    {
        [Key]
        public int personagemId { get; set; }

        [Column(TypeName ="nvarchar(50)")]
        [Required(ErrorMessage = "Nome é obrigatório")]
        public string nome { get; set; }

        [Column(TypeName = "nvarchar(11)")]
        [Required(ErrorMessage = "CPF é obrigatório")]
        public string cpf { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        [Required(ErrorMessage = "Caracteristicas são obrigatórias")]
        public string caracteristicas { get; set; }
    }
}
