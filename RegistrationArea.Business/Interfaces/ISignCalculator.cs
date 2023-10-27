using RegistrationArea.Business.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace RegistrationArea.Business.Interfaces
{
   public interface ISignCalculator
    {
        string ReturnSign(Person person); 
    }
}
