using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT_OOP_QuanLyCuaHang
{
    internal class GiaoDuc : ThietBi
    {
        int tuoiSuDung;
        //them de chuong trinh co the chay, de khong yeu cau 
        public GiaoDuc() : base()
        {
            tuoiSuDung = 0;
        }
        public GiaoDuc(string maTB, string tenTB, int namSX, double giaBan, double phanTramHH,int tuoiSuDung) : base(maTB, tenTB, namSX, giaBan, phanTramHH)
        {
            this.tuoiSuDung = tuoiSuDung;
        }
        //them de chuong trinh co the chay, de khong yeu cau
        public override double PhiBaoHanh()
        {
            if (tuoiSuDung > 10)
            {
                if(namSX < 2020)
                    return giaBan * 0.1;
                else
                    return giaBan * 0.18;
            }
            else
                return 0;
        }
        //them de chuong trinh co the chay, de khong yeu cau 
        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhập vào tuổi sử dụng");
            tuoiSuDung = int.Parse(Console.ReadLine());
            Console.WriteLine("=====================================");
        }
        //them de chuong trinh co the chay, de khong yeu cau 
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Tuổi sử dụng: " + tuoiSuDung);
            Console.WriteLine("=====================================");
        }
    }
}
