using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Guard_Pattern.Test
{
    [TestClass]
    public class GuardTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_String_AgainstNull()
        {
            string name = null;
            Guard.AgainstNull(name, "Name");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_DateTime_AgainstNull()
        {
            DateTime? startDate = null;
            Guard.AgainstNull(startDate, "StartDate");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_Int_AgainstNull()
        {
            int? money = null;
            Guard.AgainstNull(money, "Money");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_String_AgainstNullOrEmpty()
        {
            string name = "";
            Guard.AgainstNullOrEmpty(name, "Name");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_String_AgainstNullOrWhiteSpace()
        {
            string name = " ";
            Guard.AgainstNullOrWhiteSpace(name, "Name");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_String_LeadingSpace_AgainstLeadingAndTailingSpace()
        {
            string name = " nilav";
            Guard.AgainstLeadingAndTailingSpace(name, "Name");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_String_TailingSpace_AgainstLeadingAndTailingSpace()
        {
            string name = "nilav ";
            Guard.AgainstLeadingAndTailingSpace(name, "Name");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_String_AgainstSpace()
        {
            string name = "nilav patel";
            Guard.AgainstSpace(name, "Name");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_String_AgainstMinimumLength()
        {
            string name = "nilav";
            Guard.AgainstMinimumLength(name, "Name", 10);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_String_AgainstMaximumLength()
        {
            string name = "nilav patel";
            Guard.AgainstMaximumLength(name, "Name", 5);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_String_AgainstSpecialCharacters()
        {
            string name = "nilav@patel";
            Guard.AgainstSpecialCharacters(name, "Name");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_String_AgainstSpecialCharacters2()
        {
            string name = "nilav.patel";
            Guard.AgainstSpecialCharacters(name, "Name");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_String_AgainstSpecialCharacters3()
        {
            string name = "nilav/patel";
            Guard.AgainstSpecialCharacters(name, "Name");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_String_AgainstSpecialCharacters4()
        {
            string name = "nilav%patel";
            Guard.AgainstSpecialCharacters(name, "Name");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_String_AgainstSpecialCharacters5()
        {
            string name = "nilav$patel";
            Guard.AgainstSpecialCharacters(name, "Name");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_String_AgainstDigits()
        {
            string name = "nilav patel 123";
            Guard.AgainstDigits(name, "Name");
        }

        [TestMethod]
        public void Test_String_AgainstDigits_Valid()
        {
            string name = "nilav patel";
            Guard.AgainstDigits(name, "Name");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_String_AgainstAlphabet()
        {
            string name = "nilav patel";
            Guard.AgainstAlphabet(name, "Name");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_String_AgainstLowerCase()
        {
            string name = "nilav patel";
            Guard.AgainstLowerCase(name, "Name");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_String_AgainstUpperCase()
        {
            string name = "NILAV PATEL";
            Guard.AgainstUpperCase(name, "Name");
        }

        [TestMethod]
        public void Test_String_AgainstUpperCase_Valid()
        {
            string name = "nilav patel 123";
            Guard.AgainstUpperCase(name, "Name");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_Number_AgainstNumberLessThan()
        {
            int money = 500;
            Guard.AgainstNumberLessThan(money, "Money", 1000);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_Number_AgainstNumberGreaterThan()
        {
            int money = 1000;
            Guard.AgainstNumberGreaterThan(money, "Money", 500);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_Number_AgainstNumberLessThanOrEqual()
        {
            int money = 500;
            Guard.AgainstNumberLessThanOrEqual(money, "Money", 500);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_Number_AgainstNumberGreaterThanOrEqual()
        {
            int money = 1000;
            Guard.AgainstNumberGreaterThanOrEqual(money, "Money", 1000);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_Number_AgainstNumberZero()
        {
            int money = 0;
            Guard.AgainstNumberZero(money, "Money");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_Number_AgainstNumberNegativeOrZero()
        {
            int money = -1000;
            Guard.AgainstNumberNegativeOrZero(money, "Money");
        }

        [TestMethod]
        public void Test_Number_AgainstNumberNegativeOrZero_Valid()
        {
            int money = 1000;
            Guard.AgainstNumberNegativeOrZero(money, "Money");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_Number_AgainstNumberNegative()
        {
            int money = -1000;
            Guard.AgainstNumberNegative(money, "Money");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_Number_AgainstNumberOutOfRange()
        {
            int money = 1000;
            Guard.AgainstNumberOutOfRange(money, "Money", 500, 600);
        }

        [TestMethod]
        public void Test_Number_AgainstNumberOutOfRange_Valid()
        {
            int money = 1000;
            Guard.AgainstNumberOutOfRange(money, "Money", 500, 2000);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_DateTime_AgainstDateTimeGreaterThan()
        {
            DateTime startDate = DateTime.Now;
            Guard.AgainstDateTimeGreaterThan(startDate, "StartDate", DateTime.Now.AddDays(-1));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_DateTime_AgainstDateTimeLessThanOrEqual()
        {
            DateTime startDate = DateTime.Now;
            Guard.AgainstDateTimeLessThanOrEqual(startDate, "StartDate", DateTime.Now.AddDays(1));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_URL_AgainstInValidURL()
        {
            Guard.AgainstInValidURL("h://nilavpatel.github.io/", "URL");
        }

        [TestMethod]
        public void Test_URL_AgainstInValidURL_Valid()
        {
            Guard.AgainstInValidURL("https://nilavpatel.github.io", "URL");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_EmailId_AgainstInValidEmailId()
        {
            Guard.AgainstInValidEmailId("nilavpatel@1992@gmail.com", "EmailId");
        }

        [TestMethod]
        public void Test_EmailId_AgainstInValidEmailId_Valid()
        {
            Guard.AgainstInValidEmailId("nilavpatel1992@gmail.com", "EmailId");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_Guid_AgainstInValidGuid()
        {
            Guard.AgainstInValidGuid("AS52-58695-632563-ASHSJN", "Id");
        }

        [TestMethod]
        public void Test_Guid_AgainstInValidGuid_Valid()
        {
            Guard.AgainstInValidGuid(Guid.NewGuid().ToString(), "Id");
        }

        [TestMethod]
        public void Test_Guid_AgainstFalse_Valid()
        {
            Guard.AgainstFalse(true, "Active");
        }

        [TestMethod]
        public void Test_Guid_AgainstTrue_Valid()
        {
            Guard.AgainstTrue(false, "Active");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_Guid_AgainstFalse_InValid()
        {
            Guard.AgainstFalse(false, "Active");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_Guid_AgainstTrue_InValid()
        {
            Guard.AgainstTrue(true, "Active");
        }
    }
}
