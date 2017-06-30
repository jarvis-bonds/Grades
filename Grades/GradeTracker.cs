using System;
using System.Collections;
using System.IO;

namespace Grades
{
    public abstract class GradeTracker : IGradeTracker
    {
        public abstract void AddGrade(float grade);
        public abstract GradeStatistics ComputeStatistics();
        public abstract void WriteGrades(TextWriter destination);
        public abstract IEnumerator GetEnumerator();

        protected string _name;

        public string Name
        {
            get //the get retrieves the data from the private field
            {
                return _name;
            }
            set //validates the value for the property
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name can not be null or empty");
                }

                if (_name != value)
                {
                    NameChangeEventArgs args = new NameChangeEventArgs();
                    args.ExistingName = _name;
                    args.NewName = value;
                }
            }
        }

        public event NameChangeDelegate NameChanged;
    }
}
