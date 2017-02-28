using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Jotter;
using Ploeh.SemanticComparison;

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
            var expectedEmployee = new Employee
            {
                Surname = @"Smith",
                Forename = @"John",
                BirthYear = 1995,
                PhoneNumber = @"+14075552368",
                Manager = @"Johnson Ethan"
            };
            //  AutoFixture's Likeness class offers general-purpose Test-Specific Equality.
            // http://xunitpatterns.com/test-specific%20equality.html
            var expected = new Ploeh.SemanticComparison.Likeness<Employee, Employee>(expectedEmployee);
            var listEmployee = new List<Employee>();

            // Act.
            Employee.AddEmployee(listEmployee, @"Smith", @"John", 1995, @"+14075552368", @"Johnson Ethan");
            var actual = listEmployee[0];

            // Assert.
            Assert.AreEqual(expected, actual);
        }
        
        // Create an entry about new Manager
        [TestMethod]
        public void AddManagerTest()
        {
            // Arrange.
            var expectedManager = new Manager
            {
                Surname = @"Johnson",
                Forename = @"Ethan",
                BirthYear = 1980,
                PhoneNumber = @"+14075554278",
                DepartmentName = @"Testing Department"
            };
            //  AutoFixture's Likeness class offers general-purpose Test-Specific Equality.
            var expected = new Likeness<Manager, Manager>(expectedManager);
            var listManager = new List<Employee>();

            // Act.
            Manager.AddManager(listManager, @"Johnson", @"Ethan", 1980, @"+14075554278", @"Testing Department");
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
            var expectedEmployeeList = new List<Employee>();
            // Add employees to the list.
            expectedEmployeeList.Add(new Manager()  { Surname = @"Mason", Forename = @"Lawrence", BirthYear = 1984, PhoneNumber = @"+14075553727", DepartmentName = @"Testing Department" });
            expectedEmployeeList.Add(new Employee() { Surname = @"Smith", Forename = @"John", BirthYear = 1995, PhoneNumber = @"+14075552368", Manager = @"Johnson Ethan" });
            var expected = new Ploeh.SemanticComparison.Likeness<List<Employee>, List<Employee>>(expectedEmployeeList);
            // In this test we'll delete actual[2]
            var numberInTheList = 2;

            // Here we can see that DeleteEmployee can remove entries about Jotter.Employee and Jotter.Manager.
            var actual = new List<Employee>();
            actual.Add(new Manager() { Surname = @"Mason", Forename = @"Lawrence", BirthYear = 1984, PhoneNumber = @"+14075553727", DepartmentName = @"Testing Department" });
            actual.Add(new Employee() { Surname = @"Smith", Forename = @"John", BirthYear = 1995, PhoneNumber = @"+14075552368", Manager = @"Johnson Ethan" });
            actual.Add(new Manager() { Surname = @"Johnson", Forename = @"Ethan", BirthYear = 1980, PhoneNumber = @"+14075554278", DepartmentName = @"Testing Department" });

            // Act.
            Employee.DeleteEmployee(actual, numberInTheList);

            // Assert.
            Assert.AreEqual(expected, actual);
        }

        // Check, does this number has odd symbols and 4-15 lenght (standart E.164)
        [TestMethod]
        public void IsNumberTest()
        {
            // Arrange.

            var expected = true;
            var input = @"+14075552368";

            // Act.
            var actual = Employee.IsPhone(input);

            // Assert.
            Assert.AreEqual(expected, actual);
        }
    }
}