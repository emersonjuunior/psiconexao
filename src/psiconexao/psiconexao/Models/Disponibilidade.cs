using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace psiconexao.Models
{
    [Table("Disponibilidades")]
    public class Disponibilidade
    {
        [Key]
        public int DisponibilidadeId { get; set; }
        public DateTime DataHora { get; set; }
        public bool Estado { get; set; }

        [ForeignKey("UsuarioId")]
        [Column("PsicologoId")]
        public int UsuarioId { get; set; }

        [InverseProperty("Disponibilidades")]
        public virtual Psicologo Psicologo { get; set; }

    }
}
