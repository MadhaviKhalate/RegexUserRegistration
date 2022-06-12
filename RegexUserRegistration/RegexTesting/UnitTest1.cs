namespace RegexUserRegistration
{
    public class Tests
    {
        [Test]
        public void GetInvalidFirstName_checkRegexPattern_ShouldThrowInvalidNameException()
        {
            try
            {
                string firstName = "madhavi12";
                string excepted = "Valid";
                RegExp regexp = new RegExp(firstName);
                string actual = regexp.RegexFirstName();
                excepted.Equals(actual);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Invalid Name", ex.Message);
            }
        }
        [Test]
        public void GetInvalidLastName_checkRegexPattern_ShouldThrowInvalidNameException()
        {
            try
            {
                string lastName = "khalate211";
                string excepted = "Valid";
                RegExp regexp = new RegExp(lastName);
                string actual = regexp.RegexLastName();
                excepted.Equals(actual);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Invalid Name", ex.Message);
            }
        }
        [Test]
        public void GetInvalidEmail_checkRegexPattern_ShouldThrowInvalidEmailException()
        {
            try
            {
                string email = "abc@abc@bl.com";
                string excepted = "Valid";
                RegExp regexp = new RegExp(email);
                string actual = regexp.RegexEmail();
                excepted.Equals(actual);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Invalid Email", ex.Message);
            }
        }
        [Test]
        public void GetInvalidPhoneNumber_CheckRegexPattern_ShouldThrowInvalidNumberException()
        {
            try
            {
                string number = "837356323762";
                string excepted = "Valid";
                RegExp regexp = new RegExp(number);
                string actual = regexp.RegexMobileNo();
                excepted.Equals(actual);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Invalid PhoneNumber", ex.Message);
            }
        }
        [Test]
        public void GetInvalidPassword_CheckRegexPattern_ShouldThrowInvalidPasswordException()
        {
            try
            {
                string password = "abcd@123#";
                string excepted = "Valid";
                RegExp regexp = new RegExp(password);
                string actual = regexp.RegexPassword();
                excepted.Equals(actual);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Invalid Password", ex.Message);
            }
        }
    }
}
