namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EmergencyLoanManager emergencyLoanManager = new EmergencyLoanManager();
            //emergencyLoanManager.Calculate();

            //VehicleLoanManager vehicleLoanManager = new VehicleLoanManager();
            //vehicleLoanManager.Calculate();

            //MortgageLoanManager mortgageLoanManager = new MortgageLoanManager();
            //mortgageLoanManager.Calculate();

            ICreditManager emergencyLoanManager = new EmergencyLoanManager();
            //emergencyLoanManager.Calculate();

            ICreditManager vehicleLoanManager = new VehicleLoanManager();
            //vehicleLoanManager.Calculate();

            ICreditManager mortgageLoanManager = new MortgageLoanManager();
            //mortgageLoanManager.Calculate();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();


            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.Apply(vehicleLoanManager, fileLoggerService);

            List<ICreditManager> credits = new List<ICreditManager>() { emergencyLoanManager, vehicleLoanManager, mortgageLoanManager };
            //applicationManager.LoanInform(credits);

        }
    }
}