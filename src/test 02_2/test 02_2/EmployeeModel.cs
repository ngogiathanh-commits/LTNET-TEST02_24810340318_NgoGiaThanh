using System;

namespace test_02_2
{
    public class EmployeeModel
    {
        public string EmployeeId { get; set; }   
        public string FullName { get; set; }     
        public string Position { get; set; }     
        public decimal Salary { get; set; }      
        public string AvatarPath { get; set; }   

        public EmployeeModel() { }

        public EmployeeModel(string employeeId, string fullName, string position, decimal salary, string avatarPath = "")
        {
            EmployeeId = employeeId;
            FullName = fullName;
            Position = position;
            Salary = salary;
            AvatarPath = avatarPath;
        }
    }
}