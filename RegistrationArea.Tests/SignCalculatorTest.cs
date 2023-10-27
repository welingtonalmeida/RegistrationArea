using System;
using System.Collections.Generic;
using System.Text;
using RegistrationArea.Business;
using RegistrationArea.Business.Model;
using Xunit;

namespace RegistrationArea.Tests
{
    public class SignCalculatorTest
    {
        private SignCalculator signCalculator;

        public SignCalculatorTest()
        {
            signCalculator = new SignCalculator();
        }

        [Fact]
        public void ReturnSign_WhenBirthDayIs06April1990_ShouldReturnÁries()
        {
            string expectedResult = "Áries";

            User user = new User();
            user.BirthDate = new DateTime(1990, 04, 06);

            string sign = signCalculator.ReturnSign(user);

            Assert.Equal(expectedResult, sign);
            
        }
        [Fact]
        public void ReturnSign_WhenBirthDayIs15May1990_ShouldReturnTouro()
        {
            string expectedResult = "Touro";

            User user = new User();
            user.BirthDate = new DateTime(1990, 05, 15);

            string sign = signCalculator.ReturnSign(user);

            Assert.Equal(expectedResult, sign);

        }
        [Fact]
        public void ReturnSign_WhenBirthDayIs15June1990_ShouldReturnGêmeos()
        {
            string expectedResult = "Gêmeos";

            User user = new User();
            user.BirthDate = new DateTime(1990, 06, 15);

            string sign = signCalculator.ReturnSign(user);

            Assert.Equal(expectedResult, sign);

        }
        [Fact]
        public void ReturnSign_WhenBirthDayIs15July1990_ShouldReturnCâncer()
        {
            string expectedResult = "Câncer";

            User user = new User();
            user.BirthDate = new DateTime(1990, 07, 15);

            string sign = signCalculator.ReturnSign(user);

            Assert.Equal(expectedResult, sign);

        }
        [Fact]
        public void ReturnSign_WhenBirthDayIs15August1990_ShouldReturnLeão()
        {
            string expectedResult = "Leão";

            User user = new User();
            user.BirthDate = new DateTime(1990, 08, 15);

            string sign = signCalculator.ReturnSign(user);

            Assert.Equal(expectedResult, sign);

        }
        [Fact]
        public void ReturnSign_WhenBirthDayIs15September1990_ShouldReturnVirgem()
        {
            string expectedResult = "Virgem";

            User user = new User();
            user.BirthDate = new DateTime(1990, 09, 15);

            string sign = signCalculator.ReturnSign(user);

            Assert.Equal(expectedResult, sign);

        }
        [Fact]
        public void ReturnSign_WhenBirthDayIs15October1990_ShouldReturnLibra()
        {
            string expectedResult = "Libra";

            User user = new User();
            user.BirthDate = new DateTime(1990, 10, 15);

            string sign = signCalculator.ReturnSign(user);

            Assert.Equal(expectedResult, sign);

        }
        [Fact]
        public void ReturnSign_WhenBirthDayIs15November1990_ShouldReturnEscorpião()
        {
            string expectedResult = "Escorpião";

            User user = new User();
            user.BirthDate = new DateTime(1990, 11, 15);

            string sign = signCalculator.ReturnSign(user);

            Assert.Equal(expectedResult, sign);

        }
        [Fact]
        public void ReturnSign_WhenBirthDayIs20December1990_ShouldReturnSagitário()
        {
            string expectedResult = "Sagitário";

            User user = new User();
            user.BirthDate = new DateTime(1990, 12, 20);

            string sign = signCalculator.ReturnSign(user);

            Assert.Equal(expectedResult, sign);

        }
        [Fact]
        public void ReturnSign_WhenBirthDayIs16January1971_ShouldReturnCapricórnio()
        {
            string expectedResult = "Capricórnio";

            User user = new User();
            user.BirthDate = new DateTime(1990, 01, 16);

            string sign = signCalculator.ReturnSign(user);

            Assert.Equal(expectedResult, sign);

        }
        [Fact]
        public void ReturnSign_WhenBirthDayIs15February1990_ShouldReturnAquário()
        {
            string expectedResult = "Aquário";

            User user = new User();
            user.BirthDate = new DateTime(1990, 02, 15);

            string sign = signCalculator.ReturnSign(user);

            Assert.Equal(expectedResult, sign);

        }
        [Fact]
        public void ReturnSign_WhenBirthDayIs15March1990_ShouldReturnPeixes()
        {
            string expectedResult = "Peixes";

            User user = new User();
            user.BirthDate = new DateTime(1990, 03, 15);

            string sign = signCalculator.ReturnSign(user);

            Assert.Equal(expectedResult, sign);

        }
    }
}
