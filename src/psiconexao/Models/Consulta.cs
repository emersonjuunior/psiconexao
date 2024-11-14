using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace psiconexao.Models
{
    [Table("Consultas")]        
    public class Consulta
    {        
        [Key]
        public int ConsultaId { get; set; }

        [DataType(DataType.Date)]
        public DateTime Data { get; set; }

        [DataType(DataType.Time)]
        public TimeSpan Hora { get; set; }

        [ForeignKey("PsicologoId")]
        public int PsicologoId { get; set; }

        [InverseProperty("Consultas")]
        public virtual Psicologo Psicologo { get; set; }

        [ForeignKey("PacienteId")]
        public int PacienteId { get; set; }

        [InverseProperty("Consultas")]
        public virtual Paciente Paciente { get; set; }

        public Estado Estado { get; set; }        

    }
    public enum Estado
    {
        Agendada,
        cancelada,
        concluida,
        Pendente
    }
}