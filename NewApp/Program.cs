using System.Drawing;
using System.Dynamic;
using System;
using NewApp.Models;
// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// int LCB, HeSo, PhuCap;
// string HoTen;
// System.Console.WriteLine("Nhap ho ten: ");
// HoTen = Console.ReadLine();
// System.Console.WriteLine("Nhap LCB: ");
// LCB = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Nhap HeSo: ");
// HeSo = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Nhap PhuCap: ");
// PhuCap = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(" Nhan vien {0} {1}*{2}+{3} = {4} ",HoTen, LCB,HeSo,PhuCap, LCB*HeSo+PhuCap);

//Employee e = new Employee();
//e.NhapThongTin();
//e.HienThi();

int[] MangSo = new int[5];

for(int i=0; i< 5; i++)
{
    Console.WriteLine("Nhap vao phan tu thu {0}: ", i);
    MangSo[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("----------------------");

for(int i= 0;i < MangSo.Length; i++)
{
    Console.Write(MangSo[i] + "--");
}
