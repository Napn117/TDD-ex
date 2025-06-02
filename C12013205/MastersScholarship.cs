using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C12013205;


namespace C12013205
{
    public class MastersScholarship
    {
        public double ScholarshipToBePaidYear1 { get; private set; }

        public double ScholarshipToBePaidYear2 { get; private set; }

        public static int TotalStudentsAssessed { get; private set; }

        public string AssessScholarship(Student myStudent)
        {
            TotalStudentsAssessed++;
            if (myStudent.StudentGPA >= 8)
            {
                ScholarshipToBePaidYear1 = 10000;
                ScholarshipToBePaidYear2 = 20000;
                return $"{myStudent.StudentName} : High GPA: Maximum Scholarship is granted";
            }

            else if (myStudent.StudentGPA >= 7)
            {
                ScholarshipToBePaidYear1 = 5000;
                ScholarshipToBePaidYear2 = 10000;
                return $"{myStudent.StudentName} : Medium GPA: Some Scholarship granted";
            }
            else
            {
                ScholarshipToBePaidYear1 = 0;
                ScholarshipToBePaidYear2 = 0;
                return $"{myStudent.StudentName} : Low GPA: Review Scholarship after Year 1";
            }
        }

        public static void ResetAssessmentCount()
        {
            TotalStudentsAssessed = 0;
        }
    }
}
