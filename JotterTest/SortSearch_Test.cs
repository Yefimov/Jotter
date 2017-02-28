using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Jotter;
using System.Collections.Generic;

namespace JotterTest
{
    [TestClass]
    public class SortSearch_Test
    { /*
        // This method is for searching a person by its Forename.
        [TestMethod]
        public void SearchForenameTest()
        {
            // Arrange.
            var listEmployee = new List<Employee>();
            listEmployee.Add(new Employee() { Id = 10, Surname = @"Smith", Forename = @"John", BirthYear = 1995, PhoneNumber = @"+14075552368", Manager = @"Johnson Ethan" });
            listEmployee.Add(new Employee() { Id = 12, Surname = @"Schroeder", Forename = @"John", BirthYear = 1996, PhoneNumber = @"+14075559434", Manager = @"Mason Lawrence" });
            listEmployee.Add(new Employee() { Id = 11, Surname = @"Gibson", Forename = @"Patrick", BirthYear = 1993, PhoneNumber = @"+19315558642", Manager = @"Johnson Ethan" });
            listEmployee.Add(new Manager() { Id = 1, Surname = @"Johnson", Forename = @"Ethan", BirthYear = 1980, PhoneNumber = @"+14075554278", DepartmentName = @"Testing Department" });
            listEmployee.Add(new Manager() { Id = 5, Surname = @"Mason", Forename = @"Lawrence", BirthYear = 1984, PhoneNumber = @"+14075553727", DepartmentName = @"Testing Department" });
            var expected = new List<Employee>();
            listEmployee.Add(new Employee() { Id = 10, Surname = @"Smith", Forename = @"John", BirthYear = 1995, PhoneNumber = @"+14075552368", Manager = @"Johnson Ethan" });
            listEmployee.Add(new Employee() { Id = 12, Surname = @"Schroeder", Forename = @"John", BirthYear = 1996, PhoneNumber = @"+14075559434", Manager = @"Mason Lawrence" });

            // Act.
            var actual = SearchForename(listEmployee, @"John");

            // Assert.
            Assert.AreEqual(expected, actual);
        }

        // This method is for searching a person by its Surname.
        [TestMethod]
        public void SearchSurnameTest()
        {
            // Arrange.
            var listEmployee = new List<Employee>();
            listEmployee.Add(new Employee() { Id = 10, Surname = @"Smith", Forename = @"John", BirthYear = 1995, PhoneNumber = @"+14075552368", Manager = @"Johnson Ethan" });
            listEmployee.Add(new Employee() { Id = 12, Surname = @"Smith", Forename = @"Michael", BirthYear = 1996, PhoneNumber = @"+14075559434", Manager = @"Mason Lawrence" });
            listEmployee.Add(new Employee() { Id = 11, Surname = @"Gibson", Forename = @"Patrick", BirthYear = 1993, PhoneNumber = @"+19315558642", Manager = @"Johnson Ethan" });
            listEmployee.Add(new Manager() { Id = 1, Surname = @"Johnson", Forename = @"Ethan", BirthYear = 1980, PhoneNumber = @"+14075554278", DepartmentName = @"Testing Department" });
            listEmployee.Add(new Manager() { Id = 5, Surname = @"Mason", Forename = @"Lawrence", BirthYear = 1984, PhoneNumber = @"+14075553727", DepartmentName = @"Testing Department" });
            var expected = new List<Employee>();
            listEmployee.Add(new Employee() { Id = 10, Surname = @"Smith", Forename = @"John", BirthYear = 1995, PhoneNumber = @"+14075552368", Manager = @"Johnson Ethan" });
            listEmployee.Add(new Employee() { Id = 12, Surname = @"Smith", Forename = @"Michael", BirthYear = 1996, PhoneNumber = @"+14075559434", Manager = @"Mason Lawrence" });

            // Act.
            var actual = SearchSurname(listEmployee, @"Smith");

            // Assert.
            Assert.AreEqual(expected, actual);
        }

        // This method is for searching a person by its phonenumber.
        [TestMethod]
        public void SearchPhoneTest()
        {
            // Arrange.
            var listEmployee = new List<Employee>();
            listEmployee.Add(new Employee() { Id = 10, Surname = @"Smith", Forename = @"John", BirthYear = 1995, PhoneNumber = @"+14075552368", Manager = @"Johnson Ethan" });
            listEmployee.Add(new Employee() { Id = 12, Surname = @"Schroeder", Forename = @"John", BirthYear = 1996, PhoneNumber = @"+14075559434", Manager = @"Mason Lawrence" });
            listEmployee.Add(new Employee() { Id = 11, Surname = @"Gibson", Forename = @"Patrick", BirthYear = 1993, PhoneNumber = @"+19315558642", Manager = @"Johnson Ethan" });
            listEmployee.Add(new Manager() { Id = 1, Surname = @"Johnson", Forename = @"Ethan", BirthYear = 1980, PhoneNumber = @"+14075554278", DepartmentName = @"Testing Department" });
            listEmployee.Add(new Manager() { Id = 5, Surname = @"Mason", Forename = @"Lawrence", BirthYear = 1984, PhoneNumber = @"+14075553727", DepartmentName = @"Testing Department" });
            var expected = new List<Employee>();
            listEmployee.Add(new Manager() { Id = 5, Surname = @"Mason", Forename = @"Lawrence", BirthYear = 1984, PhoneNumber = @"+14075553727", DepartmentName = @"Testing Department" });

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
            listEmployee.Add(new Employee() { Id = 10, Surname = @"Smith", Forename = @"John", BirthYear = 1995, PhoneNumber = @"+14075552368", Manager = @"Johnson Ethan" });
            listEmployee.Add(new Employee() { Id = 12, Surname = @"Schroeder", Forename = @"John", BirthYear = 1996, PhoneNumber = @"+14075559434", Manager = @"Mason Lawrence" });
            listEmployee.Add(new Employee() { Id = 11, Surname = @"Gibson", Forename = @"Patrick", BirthYear = 1993, PhoneNumber = @"+19315558642", Manager = @"Johnson Ethan" });
            listEmployee.Add(new Manager() { Id = 1, Surname = @"Johnson", Forename = @"Ethan", BirthYear = 1980, PhoneNumber = @"+14075554278", DepartmentName = @"Testing Department" });
            listEmployee.Add(new Manager() { Id = 5, Surname = @"Mason", Forename = @"Lawrence", BirthYear = 1984, PhoneNumber = @"+14075553727", DepartmentName = @"Testing Department" });
            var expected = new List<Employee>();
            listEmployee.Add(new Employee() { Id = 11, Surname = @"Gibson", Forename = @"Patrick", BirthYear = 1993, PhoneNumber = @"+19315558642", Manager = @"Johnson Ethan" });
            listEmployee.Add(new Manager() { Id = 1, Surname = @"Johnson", Forename = @"Ethan", BirthYear = 1980, PhoneNumber = @"+14075554278", DepartmentName = @"Testing Department" });
            listEmployee.Add(new Manager() { Id = 5, Surname = @"Mason", Forename = @"Lawrence", BirthYear = 1984, PhoneNumber = @"+14075553727", DepartmentName = @"Testing Department" });
            listEmployee.Add(new Employee() { Id = 12, Surname = @"Schroeder", Forename = @"John", BirthYear = 1996, PhoneNumber = @"+14075559434", Manager = @"Mason Lawrence" });
            listEmployee.Add(new Employee() { Id = 10, Surname = @"Smith", Forename = @"John", BirthYear = 1995, PhoneNumber = @"+14075552368", Manager = @"Johnson Ethan" });
            
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
            listEmployee.Add(new Employee() { Id = 10, Surname = @"Smith", Forename = @"John", BirthYear = 1995, PhoneNumber = @"+14075552368", Manager = @"Johnson Ethan" });
            listEmployee.Add(new Employee() { Id = 12, Surname = @"Schroeder", Forename = @"John", BirthYear = 1996, PhoneNumber = @"+14075559434", Manager = @"Mason Lawrence" });
            listEmployee.Add(new Employee() { Id = 11, Surname = @"Gibson", Forename = @"Patrick", BirthYear = 1993, PhoneNumber = @"+19315558642", Manager = @"Johnson Ethan" });
            listEmployee.Add(new Manager() { Id = 1, Surname = @"Johnson", Forename = @"Ethan", BirthYear = 1980, PhoneNumber = @"+14075554278", DepartmentName = @"Testing Department" });
            listEmployee.Add(new Manager() { Id = 5, Surname = @"Mason", Forename = @"Lawrence", BirthYear = 1984, PhoneNumber = @"+14075553727", DepartmentName = @"Testing Department" });
            var expected = new List<Employee>();
            listEmployee.Add(new Manager() { Id = 1, Surname = @"Johnson", Forename = @"Ethan", BirthYear = 1980, PhoneNumber = @"+14075554278", DepartmentName = @"Testing Department" });
            listEmployee.Add(new Manager() { Id = 5, Surname = @"Mason", Forename = @"Lawrence", BirthYear = 1984, PhoneNumber = @"+14075553727", DepartmentName = @"Testing Department" });
            listEmployee.Add(new Employee() { Id = 11, Surname = @"Gibson", Forename = @"Patrick", BirthYear = 1993, PhoneNumber = @"+19315558642", Manager = @"Johnson Ethan" });
            listEmployee.Add(new Employee() { Id = 10, Surname = @"Smith", Forename = @"John", BirthYear = 1995, PhoneNumber = @"+14075552368", Manager = @"Johnson Ethan" });
            listEmployee.Add(new Employee() { Id = 12, Surname = @"Schroeder", Forename = @"John", BirthYear = 1996, PhoneNumber = @"+14075559434", Manager = @"Mason Lawrence" });

            // Act.
            var actual = SortBirthday(listEmployee);

            // Assert.
            Assert.AreEqual(expected, actual);
        } */
    }
}
