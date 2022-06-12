namespace RegexUserRegistration
{
    public class Tests
    {
        RegExp regex = new RegExp();

        [Test]
        public void GetFirstName_CheckRegexPattern_ReturnResult()
        {
            string fn = "Madhavi";
            Assert.AreEqual("Valid", regex.RegexFirstName(fn));
        }
        [Test]
        public void GetLastName_CheckRegexPattern_ReturnResult()
        {
            string ln = "Khalate";
            Assert.AreEqual("Valid", regex.RegexLastName(ln));
        }
        [Test]
        public void GetEmail_CheckRegexPattern_ReturnResult()
        {
            string emailID = "abc.100@abc.com";
            Assert.AreEqual("Valid", regex.RegexSampleMail(emailID));
        }
        [Test]
        public void GetPhoneNumber_CheckRegexPattern_ReturnResult()
        {
            string mob = "91 8998663264";
            Assert.AreEqual("Valid", regex.RegexMobileNo(mob));
        }
        [Test]
        public void GetPassword_CheckRegexPattern_ReturnResult()
        {
            string pwd = "abCd#123abc";
            Assert.AreEqual("Valid", regex.RegexPassword(pwd));
        }
    }
}
