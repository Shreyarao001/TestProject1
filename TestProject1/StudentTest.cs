using System;
using ClassLibrary1;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class StudentTest
    {
        [Test]
        public void TestStudentName()
        {
            // Arrange
            Student student = new Student();
            student.Name = "Preethi";
            // Act
            string studentName = student.Name;
            // Assert
            Assert.AreEqual("Preethi", studentName);
        }
        [Test]
        public void TestStudentAddress()
        {
            // Arrange
            Student student = new Student();
            student.Address = "yusufguda";
            // Act
            string studentAddress = student.Address;
            // Assert
            Assert.AreEqual("yusufguda", studentAddress);
        }
    }
}
