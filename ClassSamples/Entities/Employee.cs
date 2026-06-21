namespace ClassSamples.Entities
{
    public class Employee
    {
        //define delegate for event
        public delegate void HighExpenseValueHandler(double value);

        //type of the event is the delegate name and then event name
        public event HighExpenseValueHandler HighExpenseValue; 

        public int EmployeeId { get; init; } = 999;
        public string FirstName { get; set; }
        public  string LastName { get; set; }
        public string city { get; init; } = "Mumbai";
        public double rate { get; set; } = 1.2;

        private int myvar;
        public int MyProperty
        {
            get { return myvar; }
            set { myvar = value; }
        }

        public Employee(int EmployeeId, string FirstName, string LastName )
        {
            this.EmployeeId = EmployeeId;
            this.FirstName = FirstName;
            this.LastName = LastName;
        }

        public string Fullname()
        {
            return $"{this.FirstName} {this.LastName}";
        }

        public virtual double CalculateExpense(double value)
        {
            double result = value * this.rate;

            if (result > 0)
            {
                if (HighExpenseValue != null )
                {
                    HighExpenseValue(result);
                }
            }

             return result;
        }
    }
}
