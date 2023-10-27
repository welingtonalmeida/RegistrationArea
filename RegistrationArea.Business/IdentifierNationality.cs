using RegistrationArea.Business.Interfaces;
using RegistrationArea.Business.Model;

namespace RegistrationArea.Business
{
    public class IdentifierNationality : IIdentifierNationality
    {
        public string ReturnIndentifier(Person person)
        {
            if (person.Name == "System")
            {
                return "Yes";
            }
            else if (person.CoutryOrigin != "Brasileira" && person.CoutryOrigin != "brasileira" && person.CoutryOrigin != "Br" && person.CoutryOrigin != "br")
            {
                return "Yes";
            }
            else
            {
                return "Not";
            }
        }
    }
}
