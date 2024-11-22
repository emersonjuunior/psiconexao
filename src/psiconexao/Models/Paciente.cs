using System.ComponentModel.DataAnnotations.Schema;

namespace psiconexao.Models
{
    [Table("Pacientes")]
    public class Paciente : Usuario
    {
        public string Cpf { get; set; }
        public string Trauma { get; set; }
        public string HistoricoConsulta { get; set; }
        
        [InverseProperty("Paciente")]
        public virtual ICollection<Consulta> Consultas { get; set; } = new List<Consulta>();
    }
}
