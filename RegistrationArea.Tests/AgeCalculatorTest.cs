using System;
using Xunit;
using RegistrationArea.Business;
using RegistrationArea.Business.Model;

namespace RegistrationArea.Tests
{
    public class AgeCalculatorTest
    {
        private AgeCalculator ageCalculator;
        public AgeCalculatorTest()
        {
            DateTime fakeDate = new DateTime(2021, 10, 12);

            ageCalculator = new AgeCalculator(fakeDate);
        }

        [Fact]
        public void ReturnAge_WhenBirthDateIs20December1990_ShouldReturn30()
        {
            int expectedResult = 30;

           

            User user = new User();
            user.BirthDate = new DateTime(1990, 12, 20);

            int age = ageCalculator.ReturnAge(user);

            Assert.Equal(expectedResult, age);

        }
        [Fact]
        public void ReturnAge_WhenBirthDateIs26July1994_ShouldReturn27()
        {
            int expectedResult = 27;


            User user = new User();
            user.BirthDate = new DateTime(1994, 07, 26);

            int age = ageCalculator.ReturnAge(user);

            Assert.Equal(expectedResult, age);

        }
        [Fact]
        public void ReturnAge_WhenBirthDateIs20October1990_ShouldReturn30()
        {
            int expectedResult = 30;


            User user = new User();
            user.BirthDate = new DateTime(1990, 10, 20);

            int age = ageCalculator.ReturnAge(user);

            Assert.Equal(expectedResult, age);

        }
        [Fact]
        public void ReturnAge_WhenBirthDateIs12October1990_ShouldReturn31()
        {
            int expectedResult = 31;


            User user = new User();
            user.BirthDate = new DateTime(1990, 10, 12);

            int age = ageCalculator.ReturnAge(user);

            Assert.Equal(expectedResult, age);

        }
        [Fact]
        public void ReturnAge_WhenBirthDateIs11October1990_ShouldReturn31()
        {
            int expectedResult = 31;


            User user = new User();
            user.BirthDate = new DateTime(1990, 10, 11);

            int age = ageCalculator.ReturnAge(user);

            Assert.Equal(expectedResult, age);

        }
        [Fact]
        public void ReturnAge_WhenBirthDateIs13October2003_ShouldReturn17()
        {
            int expectedResult = 17;


            User user = new User();
            user.BirthDate = new DateTime(2003, 10, 13);

            int age = ageCalculator.ReturnAge(user);

            Assert.Equal(expectedResult, age);

        }
    }
}
