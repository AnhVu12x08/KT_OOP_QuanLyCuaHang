using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace KT_OOP_QuanLyCuaHang
{
    internal class DienTu : ThietBi, IHoTro
    {
        int thoiGianBaoHanh;
        //them de chuong trinh co the chay, de khong yeu cau
        public DienTu() : base()
        {
            thoiGianBaoHanh = 0;
        }
        //them de chuong trinh co the chay, de khong yeu cau
        public DienTu(string maTB, string tenTB, int namSX, double giaBan, double phanTramHH, int thoiGianBaoHanh) : base(maTB, tenTB, namSX, giaBan, phanTramHH)
        {
            this.thoiGianBaoHanh = thoiGianBaoHanh;
        }
        public override double PhiBaoHanh()
        {
            if (thoiGianBaoHanh > 24)
                return 0.1;
            else
                return 0.08;
        }
        public double HoTroGiaBan()
        {
            if(GiaBan > 100000)
                return GiaBan * 0.03;
            else
                return GiaBan * 0.02;
        }
        //them de chuong trinh co the chay, de khong yeu cau
        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhập thời gian bảo hành");
            thoiGianBaoHanh = int.Parse(Console.ReadLine());
            Console.WriteLine("=====================================");
        }
        //them de chuong trinh co the chay, de khong yeu cau
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Thời gian bảo hành: " + thoiGianBaoHanh);
            Console.WriteLine("=====================================");

        }
    }
}
