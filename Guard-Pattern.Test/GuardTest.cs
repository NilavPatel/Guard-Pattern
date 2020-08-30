using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Guard_Pattern.Test
{
    [TestClass]
    public class GuardTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_String_Against_Null()
        {
            string name = null;
            Guard.Against.Null(name, "Name");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_DateTime_Against_Null()
        {
            DateTime? startDate = null;
            Guard.Against.Null(startDate, "StartDate");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_Int_Against_Null()
        {
            int? money = null;
            Guard.Against.Null(money, "Money");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_String_Against_NullOrEmpty()
        {
            string name = "";
            Guard.Against.NullOrEmpty(name, "Name");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_String_Against_NullOrWhiteSpace()
        {
            string name = " ";
            Guard.Against.NullOrWhiteSpace(name, "Name");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_String_LeadingSpace_Against_LeadingAndTailingSpace()
        {
            string name = " nilav";
            Guard.Against.LeadingAndTailingSpace(name, "Name");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_String_TailingSpace_Against_LeadingAndTailingSpace()
        {
            string name = "nilav ";
            Guard.Against.LeadingAndTailingSpace(name, "Name");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_String_Against_Space()
        {
            string name = "nilav patel";
            Guard.Against.Space(name, "Name");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_String_Against_MinimumLength()
        {
            string name = "nilav";
            Guard.Against.MinimumLength(name, "Name", 10);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_String_Against_MaximumLength()
        {
            string name = "nilav patel";
            Guard.Against.MaximumLength(name, "Name", 5);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_String_Against_SpecialCharacters()
        {
            string name = "nilav@patel";
            Guard.Against.SpecialCharacters(name, "Name");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_String_Against_SpecialCharacters2()
        {
            string name = "nilav.patel";
            Guard.Against.SpecialCharacters(name, "Name");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_String_Against_SpecialCharacters3()
        {
            string name = "nilav/patel";
            Guard.Against.SpecialCharacters(name, "Name");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_String_Against_SpecialCharacters4()
        {
            string name = "nilav%patel";
            Guard.Against.SpecialCharacters(name, "Name");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_String_Against_SpecialCharacters5()
        {
            string name = "nilav$patel";
            Guard.Against.SpecialCharacters(name, "Name");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_String_Against_Digits()
        {
            string name = "nilav patel 123";
            Guard.Against.Digits(name, "Name");
        }

        [TestMethod]
        public void Test_String_Against_Digits_Valid()
        {
            string name = "nilav patel";
            Guard.Against.Digits(name, "Name");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_String_Against_Alphabet()
        {
            string name = "nilav patel";
            Guard.Against.Alphabet(name, "Name");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_String_Against_LowerCase()
        {
            string name = "nilav patel";
            Guard.Against.LowerCase(name, "Name");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_String_Against_UpperCase()
        {
            string name = "NILAV PATEL";
            Guard.Against.UpperCase(name, "Name");
        }

        [TestMethod]
        public void Test_String_Against_UpperCase_Valid()
        {
            string name = "nilav patel 123";
            Guard.Against.UpperCase(name, "Name");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_Number_Against_NumberLessThan()
        {
            int money = 500;
            Guard.Against.NumberLessThan(money, "Money", 1000);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_Number_Against_NumberGreaterThan()
        {
            int money = 1000;
            Guard.Against.NumberGreaterThan(money, "Money", 500);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_Number_Against_NumberLessThanOrEqual()
        {
            int money = 500;
            Guard.Against.NumberLessThanOrEqual(money, "Money", 500);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_Number_Against_NumberGreaterThanOrEqual()
        {
            int money = 1000;
            Guard.Against.NumberGreaterThanOrEqual(money, "Money", 1000);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_Number_Against_NumberZero()
        {
            int money = 0;
            Guard.Against.NumberZero(money, "Money");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_Number_Against_NumberNegativeOrZero()
        {
            int money = -1000;
            Guard.Against.NumberNegativeOrZero(money, "Money");
        }

        [TestMethod]
        public void Test_Number_Against_NumberNegativeOrZero_Valid()
        {
            int money = 1000;
            Guard.Against.NumberNegativeOrZero(money, "Money");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_Number_Against_NumberNegative()
        {
            int money = -1000;
            Guard.Against.NumberNegative(money, "Money");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_Number_Against_NumberOutOfRange()
        {
            int money = 1000;
            Guard.Against.NumberOutOfRange(money, "Money", 500, 600);
        }

        [TestMethod]
        public void Test_Number_Against_NumberOutOfRange_Valid()
        {
            int money = 1000;
            Guard.Against.NumberOutOfRange(money, "Money", 500, 2000);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_DateTime_Against_DateTimeGreaterThan()
        {
            DateTime startDate = DateTime.Now;
            Guard.Against.DateTimeGreaterThan(startDate, "StartDate", DateTime.Now.AddDays(-1));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_DateTime_Against_DateTimeLessThanOrEqual()
        {
            DateTime startDate = DateTime.Now;
            Guard.Against.DateTimeLessThanOrEqual(startDate, "StartDate", DateTime.Now.AddDays(1));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_URL_Against_InValidURL()
        {
            Guard.Against.InValidURL("h://nilavpatel.github.io/", "URL");
        }

        [TestMethod]
        public void Test_URL_Against_InValidURL_Valid()
        {
            Guard.Against.InValidURL("https://nilavpatel.github.io", "URL");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_EmailId_Against_InValidEmailId()
        {
            Guard.Against.InValidEmailId("nilavpatel@1992@gmail.com", "EmailId");
        }

        [TestMethod]
        public void Test_EmailId_Against_InValidEmailId_Valid()
        {
            Guard.Against.InValidEmailId("nilavpatel1992@gmail.com", "EmailId");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_Guid_Against_InValidGuid()
        {
            Guard.Against.InValidGuid("AS52-58695-632563-ASHSJN", "Id");
        }

        [TestMethod]
        public void Test_Guid_Against_InValidGuid_Valid()
        {
            Guard.Against.InValidGuid(Guid.NewGuid().ToString(), "Id");
        }

        [TestMethod]
        public void Test_Guid_Against_False_Valid()
        {
            Guard.Against.False(true, "Active");
        }

        [TestMethod]
        public void Test_Guid_Against_True_Valid()
        {
            Guard.Against.True(false, "Active");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_Guid_Against_False_InValid()
        {
            Guard.Against.False(false, "Active");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_Guid_Against_True_InValid()
        {
            Guard.Against.True(true, "Active");
        }
    }
}
