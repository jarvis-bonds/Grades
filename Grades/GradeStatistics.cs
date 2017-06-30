namespace Grades
{

    public class GradeStatistics
    {

        public GradeStatistics()
        {

            HighestGrade = float.MinValue;
            LowestGrade = float.MaxValue;
        }

        public float HighestGrade;
        public float AverageGrade;
        public float LowestGrade;

        public string Description
        {
            get
            {
                string result;
                switch (LetterGrade)
                {
                    case "A":
                        result = "Excellent";
                        break;
                    case "B":
                        result = "Good";
                        break;
                    case "C":
                        result = "Average";
                        break;
                    case "D":
                        result = "Below Average";
                        break;
                    case "F":
                        result = "Failing";
                        break;
                    default:
                        result = "Incomplete";
                        break;
                }
                return result;
            }
        }

        public string LetterGrade
        {
            get
            {
                string result;
                if (AverageGrade >= 90)
                {
                    result = "A";
                }
                else if (AverageGrade >= 80)
                {
                    result = "B";
                }
                else if (AverageGrade >= 75)
                {
                    result = "C";
                }
                else if (AverageGrade >= 70)
                {
                    result = "D";
                }
                else
                {
                    result = "F";
                }
                return result;
            }
        }
    }
}