using System.ComponentModel;


namespace EmployeeManagementSystem
{
    public static class VirtualDatabase
    {
        public static int EmployeeIdentity = 1;
        public static BindingList<Employee> Employees { get; set; } = new BindingList<Employee>();
    }
}
