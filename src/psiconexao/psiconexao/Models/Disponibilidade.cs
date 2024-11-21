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

        [DataType(DataType.Date)]
        [Display(Name = "Data Inicial")]
        public DateTime DataInicio { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data Final")]
        public DateTime DataFim { get; set; }

        [DataType(DataType.Time)]
        [Display(Name = "Horário Inicial")]
        public TimeSpan HoraInicio { get; set; }

        [DataType(DataType.Time)]
        [Display(Name = "Horário Final")]
        public TimeSpan HoraFim { get; set; }
        public bool Estado { get; set; }

        [ForeignKey("PsicologoId")]
        public int PsicologoId { get; set; }

        [InverseProperty("Disponibilidades")]
        [Display(Name = "Psicólogo")]
        public virtual Psicologo Psicologo { get; set; }

    }
}
