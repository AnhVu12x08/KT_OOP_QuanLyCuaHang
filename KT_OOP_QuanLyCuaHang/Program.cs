using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using KT_OOP_QuanLyCuaHang;

class QuanLyCuaHang
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.Unicode;
        Console.InputEncoding = Encoding.Unicode;
        //GiaDung gd = new GiaDung();
        //gd.Nhap();
        //gd.Xuat();
        //DienTu dt = new DienTu();
        //dt.Nhap();
        //dt.Xuat();
        //GiaoDuc gd1 = new GiaoDuc();
        //gd1.Nhap();
        //gd1.Xuat();
        Console.WriteLine("Nhập vào số thiết bị");
        List<ThietBi> dsTB = new List<ThietBi>();
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Nhập vào loại thiết bị gia dung, dien tu hay giao duc");
            string loaiTB = Console.ReadLine();
            if (loaiTB.ToLower().Replace(" ","") == "giadung")
            {
                GiaDung gd2 = new GiaDung();
                gd2.Nhap();
                dsTB.Add(gd2);
            }
            else if (loaiTB.ToLower().Replace(" ", "") == "dientu")
            {
                DienTu dt2 = new DienTu();
                dt2.Nhap();
                dsTB.Add(dt2);
            }
            else if (loaiTB.ToLower().Replace(" ", "") == "giaoduc")
            {
                GiaoDuc gd3 = new GiaoDuc();
                gd3.Nhap();
                dsTB.Add(gd3);
            }
        }
        foreach (var item in dsTB)
        {
            item.Xuat();
            ////Console.WriteLine("Phi bao hanh: " + item.PhiBaoHanh());
            ////if (item is IHoTro)
            ////{
            ////    IHoTro ht = (IHoTro)item;
            ////    Console.WriteLine("Ho tro gia ban: " + ht.HoTroGiaBan());
            ////}
        }
        //Console.ReadKey();
    }
}



