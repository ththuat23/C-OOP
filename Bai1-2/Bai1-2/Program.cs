/*
Viết chương trình nhập từ bàn phím hai số nguyên a, b và một ký tự ch.
Nếu:
- ch là "+" thì thực hiện phép tính a + b và in kết quả lên màn hình.
- ch là "–" thì thực hiện phép tính a - b và in kết quả lên màn hình.
- ch là "*" thì thực hiện phép tính a * b và in kết quả lên màn hình.
- ch là "/" thì thực hiện phép tính a / b và in kết quả lên màn hình. 
Lưu ý kiểm tra điều kiện của phép chia. Nếu b == 0 thì in ra thông báo "Error!"
*/

using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            char phepToan;
            double ketQua = 0;

            // Input: Không thay đổi phần này
            Console.Write("Nhap so a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so b = ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Nhap phep toan (+,-,*,/): ");
            phepToan = char.Parse(Console.ReadLine());

            /* Viết code xử lý của bạn ở đây
               Dựa vào a,b và phép toán nhập vào hãy tính giá trị biểu thức
               và in giá trị biểu thức lên màn hình.
              
            */
            switch (phepToan)
            {
                case '+':
                    ketQua = a + b;
                    Console.WriteLine("Ket qua: " + ketQua);
                    break;

                case '-':
                    ketQua = a - b;
                    Console.WriteLine("Ket qua: " + ketQua);
                    break;

                case '*':
                    ketQua = a * b;
                    Console.WriteLine("Ket qua: " + ketQua);
                    break;

                case '/':
                    if (b == 0)
                    {
                        Console.WriteLine("Error!");
                    }
                    else
                    {
                        ketQua = (double)a / b;
                        Console.WriteLine("Ket qua: " + ketQua);
                    }
                    break;

                default:
                    Console.WriteLine("Phep toan khong hop le!");
                    break;
            }
        }
    }
}
