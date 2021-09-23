using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalModels
{
    public class Exame
    {
        [Key]
        public string IdExame { get; set; }        
        public string NomeExame { get; set; }        
        public string Observacao { get; set; }
    }
}
