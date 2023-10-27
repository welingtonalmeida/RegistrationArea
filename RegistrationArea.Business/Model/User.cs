namespace RegistrationArea.Business.Model
{
    public class User : Person
    {
        public string Cpf { get; set; }

        public override string GetInfo()
        {
            return "The name user is " + Name + "The Cpf is " + Cpf + "The birth Date is " + BirthDate + "The Coutry Origin is " + CoutryOrigin ;
        }
    }
}
