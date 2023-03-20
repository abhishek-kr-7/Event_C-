namespace Events
{
    class Finance
    {
        private readonly EmployeeSeparator employeeSeparator;
        public Finance(EmployeeSeparator employeeSeparator)
        {
            //emploeeSeparator vs employeeSeparator
            this.employeeSeparator = employeeSeparator;
            employeeSeparator.EmployeeSeparated += EmployeeSeparatedEventHandler;
        }

        public void EmployeeSeparatedEventHandler()
        {
            System.Console.WriteLine("Finance department: Employee separated");
        }
    }

    class IT
    {
        private readonly EmployeeSeparator employeeSeparator1;
        public IT(EmployeeSeparator employeeSeparator)
        {
            this.employeeSeparator1 = employeeSeparator;
            employeeSeparator.EmployeeSeparated += EmployeeSeparatedEventHandler;

        }
        public void EmployeeSeparatedEventHandler()
        {
            System.Console.WriteLine("IT department: Employee separated");
        }
    }
}