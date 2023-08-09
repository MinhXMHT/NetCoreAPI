using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewApp.Models
{
    public class Employee
    {
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public int NamSinh { get; set; }
        public Employee()
        {
            HoTen = "Ho ten mac dinh";
            DiaChi = "dia chi mac dinh";
            NamSinh = 1989;
        }
        public void NhapThongTin()
        {
            System.Console.WriteLine("Ho Ten = ");
            HoTen = Console.ReadLine();
            System.Console.WriteLine("Dia Chi = ");
            DiaChi = Console.ReadLine();
            System.Console.WriteLine("Nam sinh = ");
            NamSinh = Convert.ToInt32(Console.ReadLine());
        }
        public void HienThi()
        {
            Console.Write("Nhan vien " + HoTen);
            Console.WriteLine(" - " + DiaChi);
            Console.WriteLine(" - " + NamSinh);
            Console.WriteLine(" - " + TinhTuoi(NamSinh));
        }
        public static int TinhTuoi(int NamSinh)
        {
            return DateTime.Now.Year - NamSinh;
        }
    }
}