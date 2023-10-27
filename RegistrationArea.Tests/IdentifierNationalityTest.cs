using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using RegistrationArea.Business;
using RegistrationArea.Business.Model;


namespace RegistrationArea.Tests
{
    public class IdentifierNationalityTest
    {
        private IdentifierNationality indentifierCalculator;

        public IdentifierNationalityTest()
        {
            indentifierCalculator = new IdentifierNationality();
        }

        [Fact]
        public void ReturnIdentifier_WhenCountryOriginIsForeignSpain_ShouldReturnYes()
        {
            string expectedResult = "Yes";

            User user = new User();

            user.CoutryOrigin = "Spain";

            string nationality = indentifierCalculator.ReturnIndentifier(user);

            Assert.Equal(expectedResult, nationality);

        }

        [Fact]

        public void ReturnIdentifier_WhenCountryOriginIsNotForeignBrasileira_ShouldReturnNot()
        {
            string expectedResult = "Not";

            User user = new User();

            user.CoutryOrigin ="Brasileira";

            string nationality = indentifierCalculator.ReturnIndentifier(user);

            Assert.Equal(expectedResult, nationality);

        }
        [Fact]

        public void ReturnIdentifier_WhenCountryOriginIsForeignItalian_ShouldReturnYes()
        {
            string expectedResult = "Yes";

            User user = new User();

            user.CoutryOrigin = "Italian";

            string nationality = indentifierCalculator.ReturnIndentifier(user);

            Assert.Equal(expectedResult, nationality);

        }
        [Fact]

        public void ReturnIdentifier_WhenCountryOriginIsNotForeignBr_ShouldReturnNot()
        {
            string expectedResult = "Not";

            User user = new User();

            user.CoutryOrigin = "Br";

            string nationality = indentifierCalculator.ReturnIndentifier(user);

            Assert.Equal(expectedResult, nationality);

        }
        [Fact]

        public void ReturnIdentifier_WhenCountryOriginIsNotForeignbr_ShouldReturnNot()
        {
            string expectedResult = "Not";

            User user = new User();

            user.CoutryOrigin = "br";

            string nationality = indentifierCalculator.ReturnIndentifier(user);

            Assert.Equal(expectedResult, nationality);

        }
       /* [Fact]

        public void ReturnIdentifier_WhenCountryOriginIsNotForeignbR_ShouldReturnNot()
        {
            string expectedResult = "Not";

            User user = new User();

            user.CoutryOrigin = "bR";

            string nationality = indentifierCalculator.ReturnIndentifier(user);

            Assert.Equal(expectedResult, nationality);

        }*/
    }
}
