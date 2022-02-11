using System;

namespace WindowsFormsAppPart3
{
    public class Customer
    {
        public Guid Id { get; set; } //1U5G5FDV2-F5R84G-451561651561
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FatherName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public override string ToString()
        {
            return "Id: " + Id + " Ad:" + Name + " Soyad:" + Surname + " Ata adı:" + FatherName + " E-mail:" + Email + " Mobil nömrə:" + PhoneNumber;
        }
    }
}
