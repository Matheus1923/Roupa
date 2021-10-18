using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Roupa.Models
{
    [Table("Camisa")]
    public class Camisa
    {
        [Key]
        [Column("idcamisa")]
        [Required(ErrorMessage = "O campo é obrigatório")]

        public Int32 IdRoupa { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 10, ErrorMessage = "O campo deve conter entre 10 á 50 caracteres")]
        [Column("descricao")]

        public string Descricao { get; set; }

        [Required]
        [StringLength(2, MinimumLength = 1, ErrorMessage = "O campo deve conter entre 1 á 2 caracteres")]
        [Column("tamanho")]

        public string Tamanho { get; set; }

        [Column("preco")]
        [Required(ErrorMessage = "O campo é obrigatório")]

        public decimal Preco { get; set; }
    }
}
