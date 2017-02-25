using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JotterTest
{
    [TestClass]
    public class SortSearch_Test
    {
        // This method is for searching a person by its forename.
        [TestMethod]
        public void SearchForenameTest()
        {
            // Arrange.
            var listEmployee = new List<Employee>();
            listEmployee.Add(new Employee() { id = 10, surname = @"Smith", forename = @"John", yearOfBirth = 1995, phoneNumber = @"+14075552368", manager = @"Johnson Ethan" });
            listEmployee.Add(new Employee() { id = 12, surname = @"Schroeder", forename = @"John", yearOfBirth = 1996, phoneNumber = @"+14075559434", manager = @"Mason Lawrence" });
            listEmployee.Add(new Employee() { id = 11, surname = @"Gibson", forename = @"Patrick", yearOfBirth = 1993, phoneNumber = @"+19315558642", manager = @"Johnson Ethan" });
            listEmployee.Add(new Manager() { id = 1, surname = @"Johnson", forename = @"Ethan", yearOfBirth = 1980, phoneNumber = @"+1407-555-4278", departmentName = @"Testing Department" });
            listEmployee.Add(new Manager() { id = 5, surname = @"Mason", forename = @"Lawrence", yearOfBirth = 1984, phoneNumber = @"+1407-555-3727", departmentName = @"Testing Department" });
            var expected = new List<Employee>();
            listEmployee.Add(new Employee() { id = 10, surname = @"Smith", forename = @"John", yearOfBirth = 1995, phoneNumber = @"+14075552368", manager = @"Johnson Ethan" });
            listEmployee.Add(new Employee() { id = 12, surname = @"Schroeder", forename = @"John", yearOfBirth = 1996, phoneNumber = @"+14075559434", manager = @"Mason Lawrence" });

            // Act.
            var actual = SearchForename(listEmployee, @"John");

            // Assert.
            Assert.AreEqual(expected, actual);
        }

        // This method is for searching a person by its surname.
        [TestMethod]
        public void SearchSurnameTest()
        {
            // Arrange.
            var listEmployee = new List<Employee>();
            listEmployee.Add(new Employee() { id = 10, surname = @"Smith", forename = @"John", yearOfBirth = 1995, phoneNumber = @"+14075552368", manager = @"Johnson Ethan" });
            listEmployee.Add(new Employee() { id = 12, surname = @"Smith", forename = @"Michael", yearOfBirth = 1996, phoneNumber = @"+14075559434", manager = @"Mason Lawrence" });
            listEmployee.Add(new Employee() { id = 11, surname = @"Gibson", forename = @"Patrick", yearOfBirth = 1993, phoneNumber = @"+19315558642", manager = @"Johnson Ethan" });
            listEmployee.Add(new Manager() { id = 1, surname = @"Johnson", forename = @"Ethan", yearOfBirth = 1980, phoneNumber = @"+1407-555-4278", departmentName = @"Testing Department" });
            listEmployee.Add(new Manager() { id = 5, surname = @"Mason", forename = @"Lawrence", yearOfBirth = 1984, phoneNumber = @"+1407-555-3727", departmentName = @"Testing Department" });
            var expected = new List<Employee>();
            listEmployee.Add(new Employee() { id = 10, surname = @"Smith", forename = @"John", yearOfBirth = 1995, phoneNumber = @"+14075552368", manager = @"Johnson Ethan" });
            listEmployee.Add(new Employee() { id = 12, surname = @"Smith", forename = @"Michael", yearOfBirth = 1996, phoneNumber = @"+14075559434", manager = @"Mason Lawrence" });

            // Act.
            var actual = SearchSurename(listEmployee, @"Smith");

            // Assert.
            Assert.AreEqual(expected, actual);
        }

        // This method is for searching a person by its phonenumber.
        [TestMethod]
        public void SearchPhoneTest()
        {
            // Arrange.
            var listEmployee = new List<Employee>();
            listEmployee.Add(new Employee() { id = 10, surname = @"Smith", forename = @"John", yearOfBirth = 1995, phoneNumber = @"+14075552368", manager = @"Johnson Ethan" });
            listEmployee.Add(new Employee() { id = 12, surname = @"Schroeder", forename = @"John", yearOfBirth = 1996, phoneNumber = @"+14075559434", manager = @"Mason Lawrence" });
            listEmployee.Add(new Employee() { id = 11, surname = @"Gibson", forename = @"Patrick", yearOfBirth = 1993, phoneNumber = @"+19315558642", manager = @"Johnson Ethan" });
            listEmployee.Add(new Manager() { id = 1, surname = @"Johnson", forename = @"Ethan", yearOfBirth = 1980, phoneNumber = @"+1407-555-4278", departmentName = @"Testing Department" });
            listEmployee.Add(new Manager() { id = 5, surname = @"Mason", forename = @"Lawrence", yearOfBirth = 1984, phoneNumber = @"+1407-555-3727", departmentName = @"Testing Department" });
            var expected = new List<Employee>();
            listEmployee.Add(new Manager() { id = 5, surname = @"Mason", forename = @"Lawrence", yearOfBirth = 1984, phoneNumber = @"+1407-555-3727", departmentName = @"Testing Department" });

            // Act.
            var actual = SearchPhone(listEmployee, @"+1407-555-3727");

            // Assert.
            Assert.AreEqual(expected, actual);
        }

        // Sort all entries by their surnames.
        [TestMethod]
        public void SortSurnameTest()
        {
            // Arrange.
            var listEmployee = new List<Employee>();
            listEmployee.Add(new Employee() { id = 10, surname = @"Smith", forename = @"John", yearOfBirth = 1995, phoneNumber = @"+14075552368", manager = @"Johnson Ethan" });
            listEmployee.Add(new Employee() { id = 12, surname = @"Schroeder", forename = @"John", yearOfBirth = 1996, phoneNumber = @"+14075559434", manager = @"Mason Lawrence" });
            listEmployee.Add(new Employee() { id = 11, surname = @"Gibson", forename = @"Patrick", yearOfBirth = 1993, phoneNumber = @"+19315558642", manager = @"Johnson Ethan" });
            listEmployee.Add(new Manager() { id = 1, surname = @"Johnson", forename = @"Ethan", yearOfBirth = 1980, phoneNumber = @"+1407-555-4278", departmentName = @"Testing Department" });
            listEmployee.Add(new Manager() { id = 5, surname = @"Mason", forename = @"Lawrence", yearOfBirth = 1984, phoneNumber = @"+1407-555-3727", departmentName = @"Testing Department" });
            var expected = new List<Employee>();
            listEmployee.Add(new Employee() { id = 11, surname = @"Gibson", forename = @"Patrick", yearOfBirth = 1993, phoneNumber = @"+19315558642", manager = @"Johnson Ethan" });
            listEmployee.Add(new Manager() { id = 1, surname = @"Johnson", forename = @"Ethan", yearOfBirth = 1980, phoneNumber = @"+1407-555-4278", departmentName = @"Testing Department" });
            listEmployee.Add(new Manager() { id = 5, surname = @"Mason", forename = @"Lawrence", yearOfBirth = 1984, phoneNumber = @"+1407-555-3727", departmentName = @"Testing Department" });
            listEmployee.Add(new Employee() { id = 12, surname = @"Schroeder", forename = @"John", yearOfBirth = 1996, phoneNumber = @"+14075559434", manager = @"Mason Lawrence" });
            listEmployee.Add(new Employee() { id = 10, surname = @"Smith", forename = @"John", yearOfBirth = 1995, phoneNumber = @"+14075552368", manager = @"Johnson Ethan" });
            
            // Act.
            var actual = SortSurname(listEmployee);

            // Assert.
            Assert.AreEqual(expected, actual);
        }

        // Sort all entries by their birthdays.
        [TestMethod]
        public void SortBirthdayTest()
        {
            // Arrange.
            var listEmployee = new List<Employee>();
            listEmployee.Add(new Employee() { id = 10, surname = @"Smith", forename = @"John", yearOfBirth = 1995, phoneNumber = @"+14075552368", manager = @"Johnson Ethan" });
            listEmployee.Add(new Employee() { id = 12, surname = @"Schroeder", forename = @"John", yearOfBirth = 1996, phoneNumber = @"+14075559434", manager = @"Mason Lawrence" });
            listEmployee.Add(new Employee() { id = 11, surname = @"Gibson", forename = @"Patrick", yearOfBirth = 1993, phoneNumber = @"+19315558642", manager = @"Johnson Ethan" });
            listEmployee.Add(new Manager() { id = 1, surname = @"Johnson", forename = @"Ethan", yearOfBirth = 1980, phoneNumber = @"+1407-555-4278", departmentName = @"Testing Department" });
            listEmployee.Add(new Manager() { id = 5, surname = @"Mason", forename = @"Lawrence", yearOfBirth = 1984, phoneNumber = @"+1407-555-3727", departmentName = @"Testing Department" });
            var expected = new List<Employee>();
            listEmployee.Add(new Manager() { id = 1, surname = @"Johnson", forename = @"Ethan", yearOfBirth = 1980, phoneNumber = @"+1407-555-4278", departmentName = @"Testing Department" });
            listEmployee.Add(new Manager() { id = 5, surname = @"Mason", forename = @"Lawrence", yearOfBirth = 1984, phoneNumber = @"+1407-555-3727", departmentName = @"Testing Department" });
            listEmployee.Add(new Employee() { id = 11, surname = @"Gibson", forename = @"Patrick", yearOfBirth = 1993, phoneNumber = @"+19315558642", manager = @"Johnson Ethan" });
            listEmployee.Add(new Employee() { id = 10, surname = @"Smith", forename = @"John", yearOfBirth = 1995, phoneNumber = @"+14075552368", manager = @"Johnson Ethan" });
            listEmployee.Add(new Employee() { id = 12, surname = @"Schroeder", forename = @"John", yearOfBirth = 1996, phoneNumber = @"+14075559434", manager = @"Mason Lawrence" });

            // Act.
            var actual = SortBirthday(listEmployee);

            // Assert.
            Assert.AreEqual(expected, actual);
        }
    }
}
