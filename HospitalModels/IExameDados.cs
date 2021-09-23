using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalModels
{
    public interface IExameDados
    {
        void Incluir(Exame exame);
        void Alterar(Exame exame);
        void Excluir(Exame exame);
    }
}
