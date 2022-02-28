using EmployeeManagementSystem.Enums;
using System;

namespace EmployeeManagementSystem
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public string JobDetails { get; set; }
        public string ImagePath { get; set; }
        public string CvPath { get; set; }

        public Employee(string name, string surname, DateTime dateOfBirth, string jobDetails, bool isMale, bool isFemale)
        {
            Id = VirtualDatabase.EmployeeIdentity;
            Name = name;
            Surname = surname;
            DateOfBirth = dateOfBirth;
            JobDetails = jobDetails;

            if (isMale)
                Gender = Gender.Male;
            else if (isFemale)
                Gender = Gender.Female;

            VirtualDatabase.EmployeeIdentity += 1;
        }
    }
}
