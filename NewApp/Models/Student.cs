using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewApp.Models
{
    public class Student
    {
        public string? HoTen { get; set; }
        public int NamSinh { get; set; }
        public void Display()
        {
            Console.WriteLine("---------");
            Console.WriteLine(HoTen + "--" + NamSinh);
        }
        public void CreateNewStudent()
        {
            Console.WriteLine("Nhap ho ten");
            HoTen = Console.ReadLine();
            Console.WriteLine("Nhap nam sinh");
            NamSinh = Convert.ToInt32(Console.ReadLine());
        }

        public void AddArrayList(ArrayList arr)
        {
            Console.WriteLine("Nhap so phan tu muon nhap");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0;i< n;i++)
            {
                Student std = new Student();
                std.CreateNewStudent();
                arr.Add(std);
            }            
        }
        public void EditArrayList(ArrayList arr, string? Name)
        {
            foreach(Student s in arr) 
            {
                if(s.HoTen == Name)
                {
                    Console.WriteLine("Nhap HoTen moi");
                    s.HoTen = Console.ReadLine();
                    Console.WriteLine("Nhap NamSinh moi");
                    s.NamSinh = Convert.ToInt32(Console.ReadLine());
                }
            }  
        }
        public void DeleteArrayList(ArrayList arr, string? Name)
        {
            Student? std = null;
            foreach(Student s in arr) 
            {
                if(s.HoTen == Name)
                {
                    std = s;
                }
            }  
            if(std != null)
                arr.Remove(std);
        }
    }    
}