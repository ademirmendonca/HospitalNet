using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalModels;

namespace HospitalBLL
{
    public class PacienteBLL : IPacienteDados
    {
        public void Alterar(Paciente paciente)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Paciente paciente)
        {
            throw new NotImplementedException();
        }

        public void Incluir(Paciente paciente)
        {
            if (string.IsNullOrEmpty(paciente.Id))
            {
                paciente.Id = Guid.NewGuid().ToString();
            }

            if (string.IsNullOrEmpty(paciente.Nome))
            {
                throw new ApplicationException("O nome deve ser informado");
            }
        }
    }
}
