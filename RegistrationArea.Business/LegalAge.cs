using RegistrationArea.Business.Interfaces;
using RegistrationArea.Business.Model;
using System;

namespace RegistrationArea.Business
{
    public class LegalAge : ILegalAge
    {
        public DateTime Today { get; }

        private IAgeCalculator iageCalculator;
        public LegalAge()
        {
            Today = DateTime.Now;
            iageCalculator = new AgeCalculator();
        }
        public LegalAge(DateTime dateTime)
        {
            iageCalculator = new AgeCalculator(dateTime);
        }

        public string ReturnLegalAge(Person person)
        {
            if (person is Company)
            {
                return "Nao Tem";
            }

            int age = iageCalculator.ReturnAge(person);

            if (person.Name == "System")
            {
                return "Yes";
            }

            if (age < 18)
            {
                return "Not";
            }
            else
            {
                return "Yes";
            }
        }
    }
}





