using RegistrationArea.Business;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using RegistrationArea.Business.Model;

namespace RegistrationArea.Tests
{
    public class LegalAgeTest
    {
        private LegalAge legal;

        public LegalAgeTest()
        {
            DateTime fakeDate = new DateTime(2021, 10, 17);

            legal = new LegalAge(fakeDate);
        }

        [Fact]
        public void ReturnIdentifier_WhenBirthDayIs06April1990_ShouldReturnYes()
        {
            string expectedResult2 = "Yes";

            User user = new User();
            user.BirthDate = new DateTime(1990, 04, 06);

            string nationality = legal.ReturnLegalAge(user);

            Assert.Equal(expectedResult2, nationality);
        }
        [Fact]
        public void ReturnIdentifier_WhenBirthDayIs20December2003_ShouldReturnNot()
        {
            string expectedResult2 = "Not";

            User user = new User();
            user.BirthDate = new DateTime(2003, 12, 20);

            string nationality = legal.ReturnLegalAge(user);

            Assert.Equal(expectedResult2, nationality);
        }
        [Fact]
        public void ReturnIdentifier_WhenBirthDayIs16October2003_ShouldReturnYes()
        {
            string expectedResult2 = "Yes";

            User user = new User(); 
            user.BirthDate = new DateTime(2003, 10, 16);

            string nationality = legal.ReturnLegalAge(user);

            Assert.Equal(expectedResult2, nationality); 
        }

        [Fact]
        public void ReturnIdentifier_WhenBirthDayIs17October2003_ShouldReturnYes()
        {
            string expectedResult2 = "Yes";

            User user = new User();
            user.BirthDate = new DateTime(2003, 10, 17);

            string nationality = legal.ReturnLegalAge(user);

            Assert.Equal(expectedResult2, nationality);
        }


        [Fact]
        public void ReturnIdentifier_WhenBirthDayIs18October2003_ShouldReturnNot()
        {
            string expectedResult2 = "Not";

            User user = new User();
            user.BirthDate = new DateTime(2003, 10, 18);

            string nationality = legal.ReturnLegalAge(user);

            Assert.Equal(expectedResult2, nationality);
        }

    }
}
