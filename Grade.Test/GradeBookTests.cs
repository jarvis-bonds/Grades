using Grades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Grade.Test
{
    [TestClass]
    public class GradeBookTests
    {
        [TestMethod]
        public void UsingArrays()
        {
            float[] grades;
            grades = new float[3];

            AddGrades(grades);
            Assert.AreEqual(89.5f, grades[1]);

        }

        private void AddGrades(float[] grades)
        {
            grades[1] = 89.5f;
        }


        [TestMethod]
        public void ComputesHighestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(90);
            book.AddGrade(80);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(80, result.LowestGrade);


        }

        [TestMethod]
        public void ComputesAverageGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(90);
            book.AddGrade(80);
            book.AddGrade(85);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(85, result.AverageGrade);


        }

        [TestMethod]
        public void ReferenceTypesPassbyValue()
        {
            GradeBook book1 = new GradeBook();
            GradeBook book2 = book1;

            GiveBookName(out book2); //out or ref type changes the value of the object
            Assert.AreEqual("A Grade Book", book2.Name);

        }

        private void GiveBookName(out GradeBook book)
        {
            book = new GradeBook();
            book.Name = "A Grade Book";
        }

        [TestMethod]
        public void IncrementValue(int number)
        {
            int x = 46;
            IncrementNumber(x);

        }

        private void IncrementNumber(int number)
        {
            number += 1;
            number = 0;
        }

        [TestMethod]
        public void AddDaysToDateTime()
        {
            DateTime date = new DateTime(2015, 1, 1);
            date = date.AddDays(1); //to change the value reference the variable to change the value

            Assert.AreEqual(2, date.Day);

        }


    }
}
