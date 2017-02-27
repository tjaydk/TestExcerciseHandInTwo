
namespace TestHandIn2EquivalenceBoundary.Services
{
    public class Reimbursement
    {
        private const int reimbursementDoctor       = 50;
        private const int reimbursementhospital     = 80;
        private const double deductableLimit        = 2000;


        /// <summary>
        /// Reimburses 50% if doctor visit and deductable is met, and 80% if hospital visit and deductable met.
        /// If the deductable is not met it returns 0.
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public double reimbursement(double amount, ConsultationTypes type)
        {
            if      (isDeductableMet(amount) && type == ConsultationTypes.Doctor)   { return (amount / 100) * reimbursementDoctor; }
            else if (isDeductableMet(amount) && type == ConsultationTypes.Hospital) { return (amount / 100) * reimbursementhospital; }
            else                                                                    { return 0; }
        }

        /// <summary>
        /// Check wether deductable is met or not based on the deductableLimit.
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        private bool isDeductableMet(double amount)
        {
            return amount >= deductableLimit;
        }
    }
}
