// using System.Drawing;
// using System.Dynamic;
// using System;
using System.Collections;
using NewApp.Models;
// using System.Collections;
// // See https://aka.ms/new-console-template for more information
// // Console.WriteLine("Hello, World!");
// // int LCB, HeSo, PhuCap;
// // string HoTen;
// // System.Console.WriteLine("Nhap ho ten: ");
// // HoTen = Console.ReadLine();
// // System.Console.WriteLine("Nhap LCB: ");
// // LCB = Convert.ToInt32(Console.ReadLine());
// // System.Console.WriteLine("Nhap HeSo: ");
// // HeSo = Convert.ToInt32(Console.ReadLine());
// // Console.WriteLine("Nhap PhuCap: ");
// // PhuCap = Convert.ToInt32(Console.ReadLine());

// // System.Console.WriteLine(" Nhan vien {0} {1}*{2}+{3} = {4} ",HoTen, LCB,HeSo,PhuCap, LCB*HeSo+PhuCap);

// //Employee e = new Employee();
// //e.NhapThongTin();
// //e.HienThi();

// // int[] MangSo = new int[5];

// // for(int i=0; i< 5; i++)
// // {
// //     Console.WriteLine("Nhap vao phan tu thu {0}: ", i);
// //     MangSo[i] = Convert.ToInt32(Console.ReadLine());
// // }

// // Console.WriteLine("----------------------");

// // for(int i= 0;i < MangSo.Length; i++)
// // {
// //     Console.Write(MangSo[i] + "--");
// // }


// Console.WriteLine("Nhap so luong sinh vien");
// int n = Convert.ToInt32(Console.ReadLine());

// ArrayList arrayList= new ArrayList();

// for (int i = 0; i< n; i++)
// {
//     Console.WriteLine("Nhap thong tin sinh vien thu " + i);
//     arrayList.Add(s);
// }
//  Console.WriteLine("--------------------");
// foreach(Student s in arrayList)
// {
//     s.Display();
// }

// Console.WriteLine("Sua thong tin sinh vien thu may ?");
// int index = Convert.ToInt32(Console.ReadLine());
// Student sua = new Student();
// Console.WriteLine("Nhap lai ho ten");
// sua.HoTen = Console.ReadLine();
// Console.WriteLine("Nhap lai nam sinh");
// sua.NamSinh = Convert.ToInt32(Console.ReadLine());

// arrayList[index] = sua;

//  Console.WriteLine("--------------------");
// foreach(Student s in arrayList)
// {
//     s.Display();
// }

// Console.WriteLine("Xoa sinh vien thu may ?");
// index = Convert.ToInt32(Console.ReadLine());
// arrayList.RemoveAt(index);

//  Console.WriteLine("--------------------");
// foreach(Student s in arrayList)
// {
//     s.Display();
// }

ArrayList stdList = new ArrayList();
Student st = new Student();
st.AddArrayList(stdList);

foreach (Student std in stdList)
{
    Console.WriteLine("----");
    Console.WriteLine(std.HoTen + "--" + std.NamSinh);
}

Console.WriteLine("Nhap ten muon sua");
string? name = Console.ReadLine();
st.EditArrayList(stdList,name);   

foreach (Student std in stdList)
{
    Console.WriteLine("----");
    Console.WriteLine(std.HoTen + "--" + std.NamSinh);
}

Console.WriteLine("Nhap ten muon xoa");
name = Console.ReadLine();
st.DeleteArrayList(stdList,name);   

foreach (Student std in stdList)
{
    Console.WriteLine("----");
    Console.WriteLine(std.HoTen + "--" + std.NamSinh);
}