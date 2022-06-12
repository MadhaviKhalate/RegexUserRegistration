namespace RegexUserRegistration
{
    public class Tests
    {
        [Test]
        public void GetFirstName_CheckRegexPattern_ReturnResult()
        {
            string fn = "Madhavi";
            RegExp regex = new RegExp(fn);
            Assert.AreEqual("Valid", regex.RegexFirstName());
        }
        [Test]
        public void GetLastName_CheckRegexPattern_ReturnResult()
        {
            string ln = "Khalate";
            RegExp regex = new RegExp(ln);
            Assert.AreEqual("Valid", regex.RegexLastName());
        }
        [Test]
        public void GetEmail_CheckRegexPattern_ReturnResult()
        {
            string emailID = "abc.100@abc.com";
            RegExp regex = new RegExp(emailID);
            Assert.AreEqual("Valid", regex.RegexSampleMail());
        }
        [Test]
        public void GetPhoneNumber_CheckRegexPattern_ReturnResult()
        {
            string mob = "91 8998663264";
            RegExp regex = new RegExp(mob);
            Assert.AreEqual("Valid", regex.RegexMobileNo());
        }
        [Test]
        public void GetPassword_CheckRegexPattern_ReturnResult()
        {
            string pwd = "abCd#123abc";
            RegExp regex = new RegExp(pwd);
            Assert.AreEqual("Valid", regex.RegexPassword());
        }
    }
}
