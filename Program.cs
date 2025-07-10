namespace OOP_asmnt2
{

    internal class Program
    {

        public static void userInput(Employee[] employees)
        {
            int id, salary, day, month=0, year=0;
            string name;
            Security_Level security_Level;
           
            char gender;
            for (int i = 0; i < employees.Length; i++)
            {
                bool isParsed;
                Console.WriteLine($"enter Data of #{i+1} EMP");
                do
                {
                    Console.WriteLine("enter the id: ");
                    isParsed = int.TryParse(Console.ReadLine(), out id);
                }
                while (!isParsed);

                Console.WriteLine("enter emp name: ");
                name = Console.ReadLine();

                do
                {
                    Console.WriteLine("Enter the security level: ");
                    isParsed = Enum.TryParse(Console.ReadLine(), out security_Level);
                }
                while (!isParsed);

                do
                {
                    Console.WriteLine("enter the Salary: ");
                    isParsed = int.TryParse(Console.ReadLine(), out salary);
                }
                while (!isParsed);

                do
                {
                    Console.WriteLine("enter the day of Hiring: ");
                    isParsed = int.TryParse(Console.ReadLine(), out day);
                    if (!isParsed)
                        continue;
                    
                    Console.WriteLine("enter the month of Hiring: ");
                    isParsed = int.TryParse(Console.ReadLine(), out month);
                    

                    if (!isParsed)
                        continue ;

                    Console.WriteLine("enter the year of Hiring: ");
                    isParsed = int.TryParse(Console.ReadLine(), out year);

                    
                }
                while (!isParsed||(day>31||month>12));

                do
                {
                    Console.WriteLine("enter the Gender (F/M): ");
                    isParsed = char.TryParse(Console.ReadLine(), out gender);
                }
                while (!isParsed||(gender!='F'&&gender!='M'));
                Hire_Date hire_Date = new Hire_Date(day,month,year);
                employees[i] = new Employee(id, name, security_Level, salary, hire_Date, gender);
            }


        }
        
        static void Main(string[] args)
        {
            Employee[] EmpArr = new Employee[3];
            EmpArr[0] = new Employee(10, "ahmed", Security_Level.DBA, 5000, new Hire_Date(10, 12, 2017), 'M');
            EmpArr[1] = new Employee(20, "Mahmoud", Security_Level.guest, 50000, new Hire_Date(7, 10, 2025), 'M');
            EmpArr[2] = new Employee(30, "Nour", Security_Level.secretary, 49000, new Hire_Date(8, 10, 2025), 'F');


            for (int i = 0; i < EmpArr.Length; i++) {

                Console.WriteLine($"\ndata for #{i+1} Employee\n");
                Console.WriteLine(EmpArr[i]);
            }
            //  userInput(EmpArr); //if i want user to input data {Handled all runtime error cases}
        }
    }
}
