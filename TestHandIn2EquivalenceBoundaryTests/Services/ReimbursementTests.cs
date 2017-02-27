using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestHandIn2EquivalenceBoundary.Services.Tests
{
    [TestClass()]
    public class ReimbursementTests
    {
        public Reimbursement r;

        [TestInitialize]
        public void beforeTest()
        {
            r = new Reimbursement();
        }


        /// <summary>
        /// DECISION BASED TEST CASES FOR DEDUCTABLE MET
        /// </summary>

        [TestMethod()]
        public void deuctableMetDoctorsVisit()
        {
            Assert.AreEqual(1000, r.reimbursement(2000, ConsultationTypes.Doctor));
        }

        [TestMethod()]
        public void deuctableMetHospitalVisit()
        {
            Assert.AreEqual(1600, r.reimbursement(2000, ConsultationTypes.Hospital));
        }



        /// <summary>
        /// DECISION BASED TEST CASES FOR DEDUCTABLE NOT MET
        /// </summary>

        [TestMethod()]
        public void deuctableNotMetDoctorsVisit()
        {
            Assert.AreEqual(0, r.reimbursement(1999, ConsultationTypes.Doctor));
        }

        [TestMethod()]
        public void deuctablNoteMetHospitalVisit()
        {
            Assert.AreEqual(0, r.reimbursement(1999, ConsultationTypes.Hospital));
        }
    }
}