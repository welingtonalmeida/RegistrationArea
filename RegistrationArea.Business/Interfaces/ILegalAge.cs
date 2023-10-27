using RegistrationArea.Business.Model;

namespace RegistrationArea.Business.Interfaces
{
    public interface ILegalAge
    {
        string ReturnLegalAge(Person person);
    }
}
