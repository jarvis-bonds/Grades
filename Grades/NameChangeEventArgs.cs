using System;

namespace Grades
{
    public class NameChangeEventArgs : EventArgs
    {
        public string ExistingName { get; set; }
        public string NewName { get; set; }
    }
}