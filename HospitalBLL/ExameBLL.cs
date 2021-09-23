using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalModels;

namespace HospitalBLL
{
    public class ExameBLL : IExameDados
    {
        public void Alterar(Exame exame)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Exame exame)
        {
            throw new NotImplementedException();
        }

        public void Incluir(Exame exame)
        {
            if (string.IsNullOrEmpty(exame.IdExame))
            {
                exame.IdExame = Guid.NewGuid().ToString();
            }

            if (string.IsNullOrEmpty(exame.NomeExame))
            {
                throw new ApplicationException("O nome deve ser informado");
            }
        }
    }
}
