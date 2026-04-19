namespace QLNV
{
    class NhanVienVanPhong : NhanVien
    {
        public int SoNgayLam { get; set; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("So ngay lam: ");
            SoNgayLam = int.Parse(Console.ReadLine() ?? "0");
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Ngay lam: {SoNgayLam} - Luong: {TinhLuong()}");
        }

        public override double TinhLuong()
        {
            return LuongCoBan * SoNgayLam;
        }
    }
}