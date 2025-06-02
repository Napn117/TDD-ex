using System.Net.Http.Headers;
using C12013205;

namespace MasterScholarshipTests
{
    [TestClass]
    public class UnitTest
    {
        [TestInitialize]
        public void setup()
        {
            MastersScholarship.ResetAssessmentCount();
        }

        [TestMethod]
        public void AssessScholarship_LowGPA_ReturnsReviewScholarship()
        {
            var scholarship = new MastersScholarship();
            var student = new Student("Jesse", 6.9);
            string result = scholarship.AssessScholarship(student);

            Assert.IsTrue(result.Contains("Low GPA"));
        }

        [TestMethod]
        public void AssessScholarship_MedGPA_ReturnsSomeScholarship()
        {
            var scholarship = new MastersScholarship();
            var student = new Student("Mark", 7.9);
            string result = scholarship.AssessScholarship(student);

            Assert.IsTrue(result.Contains("Medium GPA"));
        }

        [TestMethod]
        public void AssessScholarship_HighGPA_ReturnsMaxScholarship()
        {
            var scholarship = new MastersScholarship();
            var student = new Student("John", 8.1);
            string result = scholarship.AssessScholarship(student);

            Assert.IsTrue(result.Contains("High GPA"));
        }

        [TestMethod]
        public void ResetAssessmentCount_SetsTotalStudentsZero()
        {
            var scholarship = new MastersScholarship();
            scholarship.AssessScholarship(new Student("Easton", 5));
            MastersScholarship.ResetAssessmentCount();

            Assert.AreEqual(0, MastersScholarship.TotalStudentsAssessed);
        }

        [TestMethod]
        public void AssessScholarship_Year1Year2_ArePrivateSet()
        {
            var scholarship1 = new MastersScholarship();
            var scholarship2 = new MastersScholarship();
            var student = new Student("Harris", 6);
            scholarship1.AssessScholarship(student);

            Assert.AreEqual(0, scholarship2.ScholarshipToBePaidYear1);
            Assert.AreEqual(0, scholarship2.ScholarshipToBePaidYear2);
        }

        [TestMethod]
        public void MultipleAssessments_IncrementAssessmentCount()
        {
            var scholarship1 = new MastersScholarship();
            var scholarship2 = new MastersScholarship();
            var scholarship3 = new MastersScholarship();
            var scholarship4 = new MastersScholarship();
            var scholarship5 = new MastersScholarship();

            scholarship1.AssessScholarship(new Student("Jesse", 2));
            scholarship2.AssessScholarship(new Student("Mark", 4));
            scholarship3.AssessScholarship(new Student("John", 6));
            scholarship4.AssessScholarship(new Student("Easton", 8));
            scholarship5.AssessScholarship(new Student("Harris", 10));

            Assert.AreEqual(5, MastersScholarship.TotalStudentsAssessed);
        }

        [TestMethod]
        public void ZTestMethodTotalStudent()
        {
            var scholarship1 = new MastersScholarship();
            scholarship1.AssessScholarship(new Student("SoftwareCon", 8));

            Assert.AreEqual(1, MastersScholarship.TotalStudentsAssessed);
        }
    }
}