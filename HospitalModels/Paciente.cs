using HospitalModels.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HospitalModels
{
    public class Paciente
    {
        [Key]
        public string Id { get; set; }
        [Required(ErrorMessage ="Nome é obrigatorio")]
        public string Nome { get; set; }

        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$", ErrorMessage ="CPF inválido"), Required, CPF]
        public string CPF { get; set; }
        [Required(ErrorMessage = "Informe a Data de Nascimento")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "Obrigatório")]
        public string Sexo { get; set; }

        [RegularExpression(@"^([0-9]{11})$", ErrorMessage ="Telefone inválido!"), Required, Telefone]
        public string Telefone { get; set; }
        [Required(ErrorMessage = "Email é obrigatório")]
        public string Email { get; set; }
    }
}
