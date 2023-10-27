using System;

namespace RegistrationArea.Business.Model
{
    public abstract class Person
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string CoutryOrigin { get; set; }

        public abstract string GetInfo();
        
            
        
    }
}
