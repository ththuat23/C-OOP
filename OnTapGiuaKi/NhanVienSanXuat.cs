namespace QLNV
{
    class NhanVienSanXuat : NhanVien
    {
        public int SoSanPham { get; set; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("So san pham: ");
            SoSanPham = int.Parse(Console.ReadLine() ?? "0");
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"San pham: {SoSanPham} - Luong: {TinhLuong()}");
        }

        public override double TinhLuong()
        {
            return LuongCoBan * SoSanPham;
        }
    }
}