 namespace Events
 {
    class Program
    {
        static void Main(string[] args){
            EmployeeSeparator es1 = new EmployeeSeparator();

            // es1.Separate();
            Finance f1 = new Finance(es1);
            // es1.Separate();

            IT i1 = new IT(es1);
            es1.Separate();
        }
    }
 }