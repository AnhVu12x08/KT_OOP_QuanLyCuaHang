using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace KT_OOP_QuanLyCuaHang
{
    internal class GiaDung : ThietBi, IHoTro
    {
        string chatLieu;
        //them de chuong trinh co the chay, de khong yeu cau 
        public GiaDung():base()
        {
            chatLieu = string.Empty;
        }
        //them de chuong trinh co the chay, de khong yeu cau 
        public GiaDung(string maTB, string tenTB, int namSX, double giaBan, double phanTramHH, string chatLieu) : base(maTB, tenTB, namSX, giaBan, phanTramHH)
        {
            this.chatLieu = chatLieu;
        }
        public override double PhiBaoHanh()
        {
            if (chatLieu.ToLower() == "nhua")
                return 0;
            else if( GiaBan* 0.15 > 10000)
                return 10000;
            else 
                return GiaBan * 0.15;
        }
        public double HoTroGiaBan()
        {
            return 40000;
        }
        //them de chuong trinh co the chay, de khong yeu cau 
        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhập vào chất liệu");
            chatLieu = Console.ReadLine();
            Console.WriteLine("=====================================");

        }
        //them de chuong trinh co the chay, de khong yeu cau 
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Chất liệu: " + chatLieu);
            Console.WriteLine("=====================================");
        }
    }
}
