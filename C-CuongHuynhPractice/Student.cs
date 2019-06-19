using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_CuongHuynhPractice
{
    enum Gioitinh
    {
        Male, 
        Female
    }
    class Student
    {
        private string name;
        private Gioitinh gender;
        private string email;

        public string Name { get => name; set => name = value; }
        internal Gioitinh Gender { get => gender; set => gender = value; }
        public string Email { get => email; set => email = value; }

        public Student()
        {

        }

        public Student(string name, Gioitinh gender, string email)
        {
            this.name = name;
            this.gender = gender;
            this.email = email;
        }

        public void input()
        {
            Console.WriteLine("Nhap ten: ");
            Name = Console.ReadLine();
            Console.WriteLine("Nhap gender: ");
            string gioitinh = Console.ReadLine();
            if (gioitinh.Equals("Male"))
            {
                gender = Gioitinh.Male;
            }
            if (gioitinh.Equals("Female"))
            {
                gender = Gioitinh.Female;
            }
            Console.WriteLine("Nhap email: ");
            Email = Console.ReadLine();
        }

        public void display()
        {
            Console.WriteLine("Ten: "+name);
            Console.WriteLine("Gender: "+ gender);
            Console.WriteLine("Email: "+email);
        }
    }
}
