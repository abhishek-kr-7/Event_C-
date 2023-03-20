namespace Events
{
    class EmployeeSeparator
    {
        public delegate void EmployeeSeparatedEventHandler();
        public event EmployeeSeparatedEventHandler ?EmployeeSeparated;

        public void Separate()
        {
            if (EmployeeSeparated != null)
                EmployeeSeparated();
            else
                System.Console.WriteLine("Not Subcribered");
        }
    }
}