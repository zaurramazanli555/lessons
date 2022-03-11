namespace DelegatesAndLinq
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        public Person(string name, string surname, int age, string email)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            this.Email = email;
        }
    }
}
