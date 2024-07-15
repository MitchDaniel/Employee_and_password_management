using Task1;

namespace CSharp_HW_modul_10_part_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeManagement employeeManagement = new EmployeeManagement();
            employeeManagement.AddLoginPassword(new EmployeeLoginPassword("mitch_daniel", "12345"), new Employee("Daniel Kilimichenko", "Senior Teacher"));
            employeeManagement.AddLoginPassword(new EmployeeLoginPassword("Nirmata", "24680"), new Employee("Ivan Petrovich", "Senior admin"));
            employeeManagement.AddLoginPassword(new EmployeeLoginPassword("Boss", "13579"), new Employee("Oleg Nikolayevich", "The Boss"));

            Console.WriteLine(employeeManagement.GetPasswordEmployee("Nirmata"));
            employeeManagement.PrintAllInfo();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Изменения логина и пароля для Nirmata");
            employeeManagement.ChangeLoginPassword(new EmployeeLoginPassword("Nirmata", "24680"), new EmployeeLoginPassword("Nirmataaaaaa", "______24680"));
            //Console.WriteLine("После изменения логина и пароля для Nirmata");
            //try
            //{
            //    Console.WriteLine(employeeManagement.GetPasswordEmployee("Nirmata"));
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            employeeManagement.ChangeLoginPassword("Nirmataaaaaa", "______24680", new EmployeeLoginPassword("Nirmat", "1"));

            employeeManagement.PrintAllInfo();
        }
    }
}

//Создайте приложение для менеджмента сотрудников и паролей
//необходимо хранить следующую информацию:
//-Логины сотрудников
//-Пароли сотрудников
//Для хранения информации используйте Dictionary<T>
//Приложение должно предоставлять такую функциональность:
//-Добавление логина и пароля сотрудника
//-Удаление логина сотрудника
//-Изменение информации о логине и пароле сотрудника
//-Получение информации о пароле по логину сотрудника


