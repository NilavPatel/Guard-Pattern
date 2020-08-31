using System;
using Xunit;

namespace Guard_Pattern.Test
{
    public class GuardTest
    {
        [Fact]
        public void Test_String_Against_Null()
        {
            string name = null;
            Assert.Throws<ArgumentNullException>(() => Guard.Against.Null(name, "Name"));
        }

        [Fact]
        public void Test_DateTime_Against_Null()
        {
            DateTime? startDate = null;
            Assert.Throws<ArgumentNullException>(() => Guard.Against.Null(startDate, "StartDate"));
        }

        [Fact]
        public void Test_Int_Against_Null()
        {
            int? money = null;
            Assert.Throws<ArgumentNullException>(() => Guard.Against.Null(money, "Money"));
        }

        [Fact]
        public void Test_String_Against_NullOrEmpty()
        {
            string name = "";
            Assert.Throws<ArgumentNullException>(() => Guard.Against.NullOrEmpty(name, "Name"));
        }

        [Fact]
        public void Test_String_Against_NullOrWhiteSpace()
        {
            string name = " ";
            Assert.Throws<ArgumentNullException>(() => Guard.Against.NullOrWhiteSpace(name, "Name"));
        }

        [Fact]
        public void Test_String_LeadingSpace_Against_LeadingAndTailingSpace()
        {
            string name = " nilav";
            Assert.Throws<ArgumentException>(() => Guard.Against.LeadingAndTailingSpace(name, "Name"));
        }

        [Fact]
        public void Test_String_TailingSpace_Against_LeadingAndTailingSpace()
        {
            string name = "nilav ";
            Assert.Throws<ArgumentException>(() => Guard.Against.LeadingAndTailingSpace(name, "Name"));
        }

        [Fact]
        public void Test_String_Against_Space()
        {
            string name = "nilav patel";
            Assert.Throws<ArgumentException>(() => Guard.Against.Space(name, "Name"));
        }

        [Fact]
        public void Test_String_Against_MinimumLength()
        {
            string name = "nilav";
            Assert.Throws<ArgumentException>(() => Guard.Against.MinimumLength(name, "Name", 10));
        }

        [Fact]
        public void Test_String_Against_MaximumLength()
        {
            string name = "nilav patel";
            Assert.Throws<ArgumentException>(() => Guard.Against.MaximumLength(name, "Name", 5));
        }

        [Fact]
        public void Test_String_Against_SpecialCharacters()
        {
            string name = "nilav@patel";
            Assert.Throws<ArgumentException>(() => Guard.Against.SpecialCharacters(name, "Name"));
        }

        [Fact]
        public void Test_String_Against_SpecialCharacters2()
        {
            string name = "nilav.patel";
            Assert.Throws<ArgumentException>(() => Guard.Against.SpecialCharacters(name, "Name"));
        }

        [Fact]
        public void Test_String_Against_SpecialCharacters3()
        {
            string name = "nilav/patel";
            Assert.Throws<ArgumentException>(() => Guard.Against.SpecialCharacters(name, "Name"));
        }

        [Fact]
        public void Test_String_Against_SpecialCharacters4()
        {
            string name = "nilav%patel";
            Assert.Throws<ArgumentException>(() => Guard.Against.SpecialCharacters(name, "Name"));
        }

        [Fact]
        public void Test_String_Against_SpecialCharacters5()
        {
            string name = "nilav$patel";
            Assert.Throws<ArgumentException>(() => Guard.Against.SpecialCharacters(name, "Name"));
        }

        [Fact]
        public void Test_String_Against_Digits()
        {
            string name = "nilav patel 123";
            Assert.Throws<ArgumentException>(() => Guard.Against.Digits(name, "Name"));
        }

        [Fact]
        public void Test_String_Against_Digits_Valid()
        {
            string name = "nilav patel";
            Guard.Against.Digits(name, "Name");
        }

        [Fact]
        public void Test_String_Against_Alphabet()
        {
            string name = "nilav patel";
            Assert.Throws<ArgumentException>(() => Guard.Against.Alphabet(name, "Name"));
        }

        [Fact]
        public void Test_String_Against_LowerCase()
        {
            string name = "nilav patel";
            Assert.Throws<ArgumentException>(() => Guard.Against.LowerCase(name, "Name"));
        }

        [Fact]
        public void Test_String_Against_UpperCase()
        {
            string name = "NILAV PATEL";
            Assert.Throws<ArgumentException>(() => Guard.Against.UpperCase(name, "Name"));
        }

        [Fact]
        public void Test_String_Against_UpperCase_Valid()
        {
            string name = "nilav patel 123";
            Guard.Against.UpperCase(name, "Name");
        }

        [Fact]
        public void Test_Number_Against_NumberLessThan()
        {
            int money = 500;
            Assert.Throws<ArgumentException>(() => Guard.Against.NumberLessThan(money, "Money", 1000));
        }

        [Fact]
        public void Test_Number_Against_NumberGreaterThan()
        {
            int money = 1000;
            Assert.Throws<ArgumentException>(() => Guard.Against.NumberGreaterThan(money, "Money", 500));
        }

        [Fact]
        public void Test_Number_Against_NumberLessThanOrEqual()
        {
            int money = 500;
            Assert.Throws<ArgumentException>(() => Guard.Against.NumberLessThanOrEqual(money, "Money", 500));
        }

        [Fact]
        public void Test_Number_Against_NumberGreaterThanOrEqual()
        {
            int money = 1000;
            Assert.Throws<ArgumentException>(() => Guard.Against.NumberGreaterThanOrEqual(money, "Money", 1000));
        }

        [Fact]
        public void Test_Number_Against_NumberZero()
        {
            int money = 0;
            Assert.Throws<ArgumentException>(() => Guard.Against.NumberZero(money, "Money"));
        }

        [Fact]
        public void Test_Number_Against_NumberNegativeOrZero()
        {
            int money = -1000;
            Assert.Throws<ArgumentException>(() => Guard.Against.NumberNegativeOrZero(money, "Money"));
        }

        [Fact]
        public void Test_Number_Against_NumberNegativeOrZero_Valid()
        {
            int money = 1000;
            Guard.Against.NumberNegativeOrZero(money, "Money");
        }

        [Fact]
        public void Test_Number_Against_NumberNegative()
        {
            int money = -1000;
            Assert.Throws<ArgumentException>(() => Guard.Against.NumberNegative(money, "Money"));
        }

        [Fact]
        public void Test_Number_Against_NumberOutOfRange()
        {
            int money = 1000;
            Assert.Throws<ArgumentException>(() => Guard.Against.NumberOutOfRange(money, "Money", 500, 600));
        }

        [Fact]
        public void Test_Number_Against_NumberOutOfRange_Valid()
        {
            int money = 1000;
            Guard.Against.NumberOutOfRange(money, "Money", 500, 2000);
        }

        [Fact]
        public void Test_DateTime_Against_DateTimeGreaterThan()
        {
            DateTime startDate = DateTime.Now;
            Assert.Throws<ArgumentException>(() => Guard.Against.DateTimeGreaterThan(startDate, "StartDate", DateTime.Now.AddDays(-1)));
        }

        [Fact]
        public void Test_DateTime_Against_DateTimeLessThanOrEqual()
        {
            DateTime startDate = DateTime.Now;
            Assert.Throws<ArgumentException>(() => Guard.Against.DateTimeLessThanOrEqual(startDate, "StartDate", DateTime.Now.AddDays(1)));
        }

        [Fact]
        public void Test_URL_Against_InValidURL()
        {
            Assert.Throws<ArgumentException>(() => Guard.Against.InValidURL("h://nilavpatel.github.io/", "URL"));
        }

        [Fact]
        public void Test_URL_Against_InValidURL_Valid()
        {
            Guard.Against.InValidURL("https://nilavpatel.github.io", "URL");
        }

        [Fact]
        public void Test_EmailId_Against_InValidEmailId()
        {
            Assert.Throws<ArgumentException>(() => Guard.Against.InValidEmailId("nilavpatel@1992@gmail.com", "EmailId"));
        }

        [Fact]
        public void Test_EmailId_Against_InValidEmailId_Valid()
        {
            Guard.Against.InValidEmailId("nilavpatel1992@gmail.com", "EmailId");
        }

        [Fact]
        public void Test_Guid_Against_InValidGuid()
        {
            Assert.Throws<ArgumentException>(() => Guard.Against.InValidGuid("AS52-58695-632563-ASHSJN", "Id"));
        }

        [Fact]
        public void Test_Guid_Against_InValidGuid_Valid()
        {
            Guard.Against.InValidGuid(Guid.NewGuid().ToString(), "Id");
        }

        [Fact]
        public void Test_Guid_Against_False_Valid()
        {
            Guard.Against.False(true, "Active");
        }

        [Fact]
        public void Test_Guid_Against_True_Valid()
        {
            Guard.Against.True(false, "Active");
        }

        [Fact]
        public void Test_Guid_Against_False_InValid()
        {
            Assert.Throws<ArgumentException>(() => Guard.Against.False(false, "Active"));
        }

        [Fact]
        public void Test_Guid_Against_True_InValid()
        {
            Assert.Throws<ArgumentException>(() => Guard.Against.True(true, "Active"));
        }

        [Fact]
        public void Test_Guid_Against_MoreThanMaxLimit_InValid()
        {
            var value = Int16.MaxValue + 1;
            Assert.Throws<ArgumentException>(() => Guard.Against.MoreThanMaxLimit(value, "Value"));
        }
    }
}
