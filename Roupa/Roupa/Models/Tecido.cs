using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Roupa.Models
{
    [Table("Tecido")]
    public class Tecido
    {
        [Key]
        [Column("idtecido")]
        [Required(ErrorMessage = "O campo é obrigatório")]

        public Int32 IdTecido { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 10, ErrorMessage = "O campo deve conter entre 10 á 50 caracteres")]
        [Column("descricao")]

        public string Descricao { get; set; }

        [Column("preco")]
        [Required(ErrorMessage = "O campo é obrigatório")]

        public decimal Preco { get; set; }

        [Column("idroupa")]
        [Required(ErrorMessage = "O CAMPO É OBRIGATÓRIO")]

        public int IdRoupa { get; set; }
    }
}
