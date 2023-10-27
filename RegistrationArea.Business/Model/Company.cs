namespace RegistrationArea.Business.Model
{
    public class Company : Person
    {
        public string Cnpj { get; set; }

        public override string GetInfo()
        {
            return "The name user is " + Name + "The Cnpj is " + Cnpj + "The birth Date is " + BirthDate + "The Coutry Origin is " + CoutryOrigin;
        }
    }
}
