using RegistrationArea.Business.Interfaces;
using RegistrationArea.Business.Model;
using System;

namespace RegistrationArea.Business
{
    public class AgeCalculator : IAgeCalculator
    {
        public DateTime Today { get; }

        public AgeCalculator()
        {
            Today = DateTime.Now;
        }
        public AgeCalculator(DateTime dateTime) 
        {
            Today = dateTime;
        }

        public int ReturnAge(Person person)
        {
            if (person.Name == "System")
            {
                return 0;
            }
            int subtracao;

            if (Today.Month < person.BirthDate.Month)
            {
                    subtracao = Today.Year - person.BirthDate.Year;

                    subtracao--;

                    return subtracao;
            }
            else if (Today.Month > person.BirthDate.Month)
            {
                    subtracao = Today.Year - person.BirthDate.Year;

                    return subtracao;
            }
            else 
            {
                if (Today.Day < person.BirthDate.Day)
                {
                    subtracao = Today.Year - person.BirthDate.Year;

                    subtracao--;

                    return subtracao;
                }
                else 
                {
                    subtracao = Today.Year - person.BirthDate.Year;

                    return subtracao;
                }
               

            }
            
           
        }
    }
}
