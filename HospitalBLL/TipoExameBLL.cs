using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalModels;

namespace HospitalBLL
{
    public class TipoExameBLL : ITipoExameDados
    {
        public void Alterar(TipoExame tipoExame)
        {
            throw new NotImplementedException();
        }

        public void Excluir(TipoExame tipoExame)
        {
            throw new NotImplementedException();
        }

        public void Incluir(TipoExame tipoExame)
        {
            if (string.IsNullOrEmpty(tipoExame.NomeTipoExame))
            {
                throw new ApplicationException("O nome deve ser informado");
            }

            if (string.IsNullOrEmpty(tipoExame.IdTipoExame))
            {
                tipoExame.IdTipoExame = Guid.NewGuid().ToString();
            }
        }
    }
}
