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

        [Display(Name = "Data Inicial")]
        [DataType(DataType.Date)]
        public DateTime DataInicio { get; set; }

        [Display(Name = "Data Final")]
        [DataType(DataType.Date)]
        public DateTime DataFim { get; set; }

        [Display(Name = "Hora Inicial")]
        [DataType(DataType.Time)]
        public TimeSpan HoraInicio { get; set; }

        [Display(Name = "Hora Final")]
        [DataType(DataType.Time)]
        public TimeSpan HoraFim { get; set; }
        public bool Estado { get; set; }

        [ForeignKey("PsicologoId")]
        public int PsicologoId { get; set; }

        [InverseProperty("Disponibilidades")]
        public virtual Psicologo Psicologo { get; set; }

    }
}
