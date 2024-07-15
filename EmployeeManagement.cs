using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class EmployeeManagement
    {
        Dictionary<EmployeeLoginPassword, Employee> _dictionaryLoginPasswordEmployee = new Dictionary<EmployeeLoginPassword, Employee>();

        public void AddLoginPassword(EmployeeLoginPassword loginPassword, Employee employee)
        {
            _dictionaryLoginPasswordEmployee.Add(loginPassword, employee);
        }
        
        public void ChangeLoginPassword(EmployeeLoginPassword oldloginPassword, EmployeeLoginPassword newLoginPassword)
        {
            Employee tempEmployee = new Employee(string.Empty, string.Empty);
            foreach (var kvp in _dictionaryLoginPasswordEmployee)
            {
                if(kvp.Key.Password == oldloginPassword.Password && kvp.Key.Password == oldloginPassword.Password)
                {
                    tempEmployee.Fullname = kvp.Value.Fullname;
                    tempEmployee.WorkPosition = kvp.Value.WorkPosition;
                    _dictionaryLoginPasswordEmployee.Remove(kvp.Key);
                    AddLoginPassword(newLoginPassword, tempEmployee);
                    return;
                }
            }
            throw new Exception("Login not found");
        }

        public void ChangeLoginPassword(string oldlogin, string Password, EmployeeLoginPassword newLoginPassword)
        {
            foreach (var kvp in _dictionaryLoginPasswordEmployee)
            {
                if (kvp.Key.Login == oldlogin && kvp.Key.Password == Password)
                {
                    kvp.Key.Password = newLoginPassword.Password;
                    kvp.Key.Login = newLoginPassword.Login;
                    return;
                }
            }
            throw new Exception("Login not found");
        }

        public string GetPasswordEmployee(string login)
        {
            foreach (var item in _dictionaryLoginPasswordEmployee)
            {
                if(item.Key.Login == login)
                {
                    return item.Key.Password;
                }
            }
            throw new Exception("The worker is not found");
        }

        public void DeleteLogin(string login)
        {
            foreach (var item in _dictionaryLoginPasswordEmployee)
            {
                if (item.Key.Login == login)
                {
                    _dictionaryLoginPasswordEmployee.Remove(item.Key);
                }
            }
            throw new Exception("The worker is not found");
        }

        public void PrintAllInfo()
        {
            foreach (var kvp in _dictionaryLoginPasswordEmployee)
            {
                Console.WriteLine($"{kvp.Value.ToString()},  login: {kvp.Key.Login}, password: {kvp.Key.Password}"); 
            }
        }
    }
}

//-Добавление логина и пароля сотрудника +
//-Удаление логина сотрудника 
//-Изменение информации о логине и пароле сотрудника +
//-Получение информации о пароле по логину сотрудника +