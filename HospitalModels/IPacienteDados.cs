using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalModels
{
    public interface IPacienteDados
    {
        void Incluir(Paciente paciente);
        void Alterar(Paciente paciente);
        void Excluir(Paciente paciente);
        

    }
}
