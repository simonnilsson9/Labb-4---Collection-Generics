namespace Labb_4___Collection_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee Em1 = new Employee("1","Simon","Male","40000");
            Employee Em2 = new Employee("2","Emm","Female","45000");
            Employee Em3 = new Employee("3","Jimmy","Male","70000");
            Employee Em4 = new Employee("4","Maria","Female","75000");
            Employee Em5 = new Employee("5","Anton","Male","30000");

            Stack<Employee> stack = new Stack<Employee>();
            stack.Push(Em1);
            stack.Push(Em2);
            stack.Push(Em3);
            stack.Push(Em4);
            stack.Push(Em5);

            foreach (Employee em in stack)
            {                
                em.EmployeeInfo();
                Console.WriteLine($"Items left in stack: {stack.Count}");
            }
            Console.WriteLine("--------------------------\nRetrive Using Pop Method");

            while (stack.Count > 0)
            {                
                Employee EmpPop = stack.Pop();
                EmpPop.EmployeeInfo();
                Console.WriteLine($"Items left in stack: {stack.Count}");
            }
            Console.WriteLine("--------------------------\nRetrive Using Peek Method");

            stack.Push(Em1);
            stack.Push(Em2);
            stack.Push(Em3);
            stack.Push(Em4);
            stack.Push(Em5);

            Employee EmpPeek = stack.Peek();
            for (int i = 0; i < 2; i++)
            {
                EmpPeek.EmployeeInfo();
                Console.WriteLine($"Items left in stack: {stack.Count}");
            }

            Console.WriteLine("--------------------------");

            if (stack.Contains(Em3))
            {
                Console.WriteLine("Employee 3 is in the stack.");
            }
            else
            {
                Console.WriteLine("Employee 3 is not in the stack.");
            }
            Console.WriteLine("--------------------------");

            //List
            List<Employee> EmpList = new List<Employee>();
            EmpList.Add(Em1);
            EmpList.Add(Em2);
            EmpList.Add(Em3);
            EmpList.Add(Em4);
            EmpList.Add(Em5);

            if (EmpList.Contains(Em2))
            {
                Console.WriteLine("Employee2 object exists in the list.");
            }
            else
            {
                Console.WriteLine("Employee2 object does not exists in the list.");
            }
            Console.WriteLine("--------------------------");

            Employee firstMaleEmployee = EmpList.Find(employee => employee.Gender == "Male");
            if (firstMaleEmployee != null)
            {
                Console.WriteLine($"The first male in the list is: ");
                firstMaleEmployee.EmployeeInfo();
            }
            else
            {
                Console.WriteLine("No male employees was found.");
            }
            Console.WriteLine("--------------------------");

            List<Employee> findAllMaleEmployees = EmpList.FindAll(employee => employee.Gender == "Male");
            Console.WriteLine("Male employees:");

            foreach (Employee male in findAllMaleEmployees)
            {
                male.EmployeeInfo();
            }
        }
    }
}