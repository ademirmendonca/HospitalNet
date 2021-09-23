using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalModels
{
    public interface ITipoExameDados
    {
        void Incluir(TipoExame tipoExame);
        void Alterar(TipoExame tipoExame);
        void Excluir(TipoExame tipoExame);
    }
}
