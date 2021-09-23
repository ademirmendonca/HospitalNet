using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalModels
{
    public class TipoExame
    {
        [Key]
        public string IdTipoExame { get; set; }
        public string NomeTipoExame { get; set; }
        public string Descricao { get; set; }
    }
}
