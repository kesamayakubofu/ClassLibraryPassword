using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibraryPassword;

namespace PasswordCheckerTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Check_8Symbols_ReturnTrue() //проверяем на правильность(8 символов)
        {
            //Arrange
            string password = "Asqw12$$";
            bool expected = true;
            //Act
            bool actual = PasswordChecker.ValidatePassword(password);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Check_4Symbols_ReturnFalse() //проверяем на правильность длины строки(4 символа)
        {
            //Arrange
            string password = "Aq2$";
            bool expected = false;
            //Act
            bool actual = PasswordChecker.ValidatePassword(password);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Check_PasswordWithoutLowerSymbols_ReturnFalse()
        {
            //Arrange
            string password = "KGJSDF565476E4556986416$";
            bool expected = false;
            //Act
            bool actual = PasswordChecker.ValidatePassword(password);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Check_Passwordlowercase_ReturnFalse()
        {
            //Arrange
            string password = "kdfhnskljdhgi";
            bool expected = false;
            //Act
            bool actual = PasswordChecker.ValidatePassword(password);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Check_PasswordUppercase_ReturnFalse()
        {
            //Arrange
            string password = "GHEFTSBJJGWEF";
            bool expected = false;
            //Act
            bool actual = PasswordChecker.ValidatePassword(password);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Check_PasswordOnlyDigit_ReturnFalse()
        {
            //Arrange
            string password = "823465345";
            bool expected = false;
            //Act
            bool actual = PasswordChecker.ValidatePassword(password);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Check_PasswordIntersect_ReturnTrue()
        {
            //Arrange
            string password = "OHGjkf!@12";
            bool expected = true;
            //Act
            bool actual = PasswordChecker.ValidatePassword(password);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Check_PasswordNullOrEmpty_ReturnFalse()
        {
            //Arrange
            string password = "";
            bool expected = false;
            //Act
            bool actual = PasswordChecker.ValidatePassword(password);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Правильность пароля
        /// </summary>
        [TestMethod]
        public void Check_Passwordright_ReturnTrue()
        {
            //Arrange
            string password = "#KiryhaLoh1";
            bool expected = true;
            //Act
            bool actual = PasswordChecker.ValidatePassword(password);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Ввод генерируемого пароля
        /// </summary>
        [TestMethod]

        public void ValidatePassword_GeneratingPass_ReturnTrue()
        {
            //PasswordChecker obj= new PasswordChecker();
            //Arrange
            string password =PasswordChecker.GeneratePassword();
            Console.WriteLine(password);
            bool expected = true;
            //ACT
            bool actual = PasswordChecker.ValidatePassword(password);
            //Arrange
            Assert.AreEqual(expected, actual);

        }

        }
    }

