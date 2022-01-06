using System;
using System.ComponentModel.DataAnnotations;

namespace Andor.Models
{
    public class Formacao
    {
        [Key]
        public int Id { get; set; }
        public int Id_pessoa { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Instituicao { get; set; }
        [DataType(DataType.Date)]
        public DateTime? Inicio { get; set; }
        [DataType(DataType.Date)]
        public DateTime? Fim { get; set; }
        public string Situacao { get; set; }
    }
}
