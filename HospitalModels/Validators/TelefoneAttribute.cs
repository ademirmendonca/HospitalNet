using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HospitalModels.Validators
{
    public class TelefoneAttribute : ValidationAttribute
    {

		protected override ValidationResult IsValid(object value, ValidationContext validationContext)
		{
			if (value == null)

				return new ValidationResult("Telefone é obrigatório");

			var telefone = value.ToString();
			return IsPhoneNumber(telefone)
				? ValidationResult.Success
				: new ValidationResult("Telefone inválido!");
		}
		public  bool IsPhoneNumber(string number)
        {
            return Regex.Match(number, @"^([0-9]{11})$").Success;
        }
    }
}
