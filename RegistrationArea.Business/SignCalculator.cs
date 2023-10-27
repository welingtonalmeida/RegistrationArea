using RegistrationArea.Business.Interfaces;
using RegistrationArea.Business.Model;

namespace RegistrationArea.Business
{
    public class SignCalculator : ISignCalculator
    {
      
        public string ReturnSign(Person person)
        {
            if (person is Company)
            {
                return "Nao Tem";
            }
            if (person.Name == "System")
            {
                return "Nao Tem";
            }
           else if (person.BirthDate.Day > 20 && person.BirthDate.Month == 03 || person.BirthDate.Day < 21 && person.BirthDate.Month == 04)
            {
                return "Áries";
            }
            else if (person.BirthDate.Day > 20 && person.BirthDate.Month == 04 || person.BirthDate.Day < 21 && person.BirthDate.Month == 05)
            {
                return "Touro";
            }
            else if (person.BirthDate.Day > 20 && person.BirthDate.Month == 05 || person.BirthDate.Day < 21 && person.BirthDate.Month == 06)
            {
                return "Gêmeos";
            }
            else if (person.BirthDate.Day > 20 && person.BirthDate.Month == 06 || person.BirthDate.Day < 23 && person.BirthDate.Month == 07)
            {
                return "Câncer";
            }
            else if (person.BirthDate.Day > 22 && person.BirthDate.Month == 07 || person.BirthDate.Day < 23 && person.BirthDate.Month == 08)
            {
                return "Leão";
            }
            else if (person.BirthDate.Day > 22 && person.BirthDate.Month == 08 || person.BirthDate.Day < 23 && person.BirthDate.Month == 09)
            {
                return "Virgem";
            }
            else if (person.BirthDate.Day > 22 && person.BirthDate.Month == 09 || person.BirthDate.Day < 23 && person.BirthDate.Month == 10)
            {
                return "Libra";
            }
            else if (person.BirthDate.Day > 22 && person.BirthDate.Month == 10 || person.BirthDate.Day < 22 && person.BirthDate.Month == 11)
            {
                return "Escorpião";
            }
            else if (person.BirthDate.Day > 21 && person.BirthDate.Month == 11 || person.BirthDate.Day < 22 && person.BirthDate.Month == 12)
            {
                return "Sagitário";
            }
            else if (person.BirthDate.Day > 21 && person.BirthDate.Month == 12 || person.BirthDate.Day < 21 && person.BirthDate.Month == 01)
            {
                return "Capricórnio";
            }
            else if (person.BirthDate.Day > 20 && person.BirthDate.Month == 01 || person.BirthDate.Day < 19 && person.BirthDate.Month == 02)
            {
                return "Aquário";
            }
            else if (person.BirthDate.Day > 18 && person.BirthDate.Month == 02 || person.BirthDate.Day < 21 && person.BirthDate.Month == 03)
            {
                return "Peixes";
            }
            else
            {
                return "Nao Tem";
            }


            
        }
    }
}
