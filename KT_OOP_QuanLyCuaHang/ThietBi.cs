using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT_OOP_QuanLyCuaHang
{
    internal abstract class ThietBi
    {
        protected string MaTB;
        string maTB
        {
            get
            {
                return MaTB;
            }
            set
            {
                if (value.StartsWith("TB") && value.Length == 5 && value.Substring(2).All(char.IsDigit))
                {
                    MaTB = value;
                }
                else
                    MaTB = "TB001";
            }
        }
        protected string tenTB;
        protected int namSX;
        protected double GiaBan;
        public double giaBan
        {
            get
            {
                return GiaBan;
            }
            set
            {
                if (value > 0)
                    GiaBan = value;
                else
                {
                    Console.WriteLine("Giá bán không được nhỏ hơn 0 nên gán giá trị bằng 0");
                    GiaBan = 0;

                }
            }
        }
        protected double phanTramHH;
        protected static double tyLeThue = 0.1;
        public ThietBi()
        {
            maTB = "TB001";
            tenTB = "Máy Xúc Đất";
            namSX = DateTime.Now.Year;
            giaBan = 10000;
            phanTramHH = 0.04;
        }
        public ThietBi (string maTB, string tenTB, int namSX, double giaBan, double phanTramHH)
        {
            this.maTB = maTB;
            this.tenTB = tenTB;
            this.namSX = namSX;
            this.giaBan = giaBan;
            this.phanTramHH = phanTramHH;
        }
        public double ThueSX()
        {
            return giaBan * ThietBi.tyLeThue;
        }
        public abstract double PhiBaoHanh();
        public double ChiPhi()
        {
            return phanTramHH * giaBan + PhiBaoHanh();
        }
        public double LoiNhuan()
        {
            return giaBan - ChiPhi() - ThueSX();
        }
        //them de chuong trinh co the chay, de khong yeu cau
        public virtual void Nhap()
        {
            Console.WriteLine("Nhập mã thiết bị: ");
            maTB = Console.ReadLine();
            Console.WriteLine("Nhập tên thiết bị: ");
            tenTB = Console.ReadLine();
            Console.WriteLine("Nhập năm sản xuất: ");
            namSX = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập giá bán: ");
            giaBan = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập phần trăm hoa hồng: ");
            phanTramHH = double.Parse(Console.ReadLine());
        }
        public virtual void Xuat()
        {
            Console.WriteLine("Mã thiết bị: " + maTB);
            Console.WriteLine("Tên thiết bị: " + tenTB);
            Console.WriteLine("Năm sản xuất: " + namSX);
            Console.WriteLine("Giá Bán: " + giaBan);
            Console.WriteLine("Phần trăm hoa hồng: " + phanTramHH);
            Console.WriteLine("Thuế sản xuất: " + ThueSX());
            Console.WriteLine("Phí bảo hành: " + PhiBaoHanh());
            Console.WriteLine("Chi phí: " + ChiPhi());
            Console.WriteLine("Lợi nhuận: " + LoiNhuan());
        }
    }
}
