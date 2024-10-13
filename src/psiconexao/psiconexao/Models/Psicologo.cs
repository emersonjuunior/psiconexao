using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace psiconexao.Models
{
    [Table("Psicologos")]
    public class Psicologo : Usuario {

        [ForeignKey("UsuarioId")]
        public int UsuarioId { get; set; }

        [Required]
        [StringLength(11)]
        public string crp { get; set; }
        
        public string UrlFoto { get; set; }

        public string Biografia { get; set; }

        public float PrecoConsulta { get; set; }

        //public virtual ICollection<Disponibilidade> Disponibilidades { get; set; };

        [Display(Name ="Tipo de Especialidade")]
        public TipoEspecialidade TEspecialidade { get; set; }

        [Display(Name = "Tipo de Abordagem")]
        public TipoAbordagem TAbordagem { get; set; }

        public enum TipoEspecialidade
        {
            Clínica,
            Escolar,
            Saúde, 
            Desenvolvimento,
            Esporte, 
            NeuroPsicologia,
            Familiar,
            Casal,
            Transcultural,
            Comportamental
        }

        public enum TipoAbordagem
        {
            CognitivoComportamental,
            Psicanálise,
            Humanista, 
            Sistêmica,
            Gestalt,
            Narrativa,
            Positiva,
            Grupo,
            Midfullness
        }

    }
}
