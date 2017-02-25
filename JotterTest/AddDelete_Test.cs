using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace JotterTest
{
    [TestClass]
    public class AddDelete_Test
    {
        // Create an entry about new Employee
        [TestMethod]
        public void AddEmployeeTest()
        {
            // Arrange.
            var expected = new Employee
            {
                id = 10,
                surname = @"Smith",
                forename = @"John",
                yearOfBirth = 1995,
                phoneNumber = @"+14075552368",
                manager = @"Johnson Ethan"
            };
            var listEmployee = new List<Employee>();

            // Act.
            AddEmployee(listEmployee, id, surname, forename, yearOfBirth, phoneNumber, manager);
            var actual = listEmployee[0];

            // Assert.
            Assert.AreEqual(expected, actual);
        }

        // Create an entry about new Manager
        [TestMethod]
        public void AddManagerTest()
        {
            // Arrange.
            var expected = new Manager
            {
                id = 1,
                surname = @"Johnson",
                forename = @"Ethan",
                yearOfBirth = 1980,
                phoneNumber = @"+1407-555-4278",
                departmentName = @"Testing Department"
            };
            var listManager = new List<Manager>();

            // Act.
            AddManager(listManager, id, surname, forename, yearOfBirth, phoneNumber, departmentName);
            var actual = listManager[0];

            // Assert.
            Assert.AreEqual(expected, actual);
        }

        // Delete an entry about Employee
        [TestMethod]
        public void DeleteEmployeeTest()
        {
            // Arrange.

            // Create an expected list of employees.
            var expected = new List<Employee>();
            // Add employees to the list.
            expected.Add(new Employee() { id = 1, surname = @"Smith", forename = @"John", yearOfBirth = 1995, phoneNumber = @"+14075552368", manager = @"Johnson Ethan" });

            var actual = new List<Employee>();
            actual.Add(new Employee() { id = 10, surname = @"Smith", forename = @"John", yearOfBirth = 1995, phoneNumber = @"+14075552368", manager = @"Johnson Ethan" });
            actual.Add(new Employee() { id = 11, surname = @"Gibson", forename = @"Patrick", yearOfBirth = 1993, phoneNumber = @"+19315558642", manager = @"Johnson Ethan" });
            
            // Act.
            DeleteEmployee(actual, actual[1].id);

            // Assert.
            Assert.AreEqual(expected, actual);
        }

        // Delete an entry about Manager
        [TestMethod]
        public void DeleteManagerTest()
        {
            // Arrange.
            
            var expected = new List<Manager>();
            expected.Add(new Manager() { id = 1, surname = @"Johnson", forename = @"Ethan", yearOfBirth = 1980, phoneNumber = @"" + 14075554278"", departmentName = @"Testing Department" });

            var actual = new List<Manager>();
            expected.Add(new Manager() { id = 1, surname = @"Johnson", forename = @"Ethan", yearOfBirth = 1980, phoneNumber = @"+1407-555-4278", departmentName = @"Testing Department" });
            expected.Add(new Manager() { id = 5, surname = @"Mason", forename = @"Lawrence", yearOfBirth = 1984, phoneNumber = @"+1407-555-3727", departmentName = @"Testing Department" });

            // Act.
            DeleteManager(actual, actual[1].id);

            // Assert.
            Assert.AreEqual(expected, actual);
        }

        // Delete odd symbols from mobile number
        [TestMethod]
        public void CleanPhoneTest()
        {
            // Arrange.

            var expected = @"+14075554278";
            var input = @" +1-407-555-4278 ";

            // Act.
            var actual = CleanPhone(input);

            // Assert.
            Assert.AreEqual(expected, actual);
        }
    }
}