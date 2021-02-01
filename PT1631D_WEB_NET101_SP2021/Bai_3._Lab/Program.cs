using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3._Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.OutputEncoding = Encoding.UTF8;

                Console.WriteLine(" ________________________");
                Console.WriteLine("|__________MENU__________|");
                Console.WriteLine("| 1. Mang so nguyen      |");
                Console.WriteLine("| 2. Kiem tra hoc luc    |");
                Console.WriteLine("| 3. Bang cuu chuong     |");
                Console.WriteLine("| 4. Thoat               |");
                Console.WriteLine("|________________________|");

                Console.Write("Moi ban chon menu: ");
                int menu = int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        Bai1();
                        break;
                    case 2:
                        Bai2();
                        break;
                    case 3:
                        Bai3();
                        break;
                    default:
                        Console.WriteLine("Ket thuc chuong trinh");
                        Console.ReadKey();
                        return;
                }

                Console.ReadLine();
            }
        }

        private static void Bai1()
        {
            Console.WriteLine("1. Mang so nguyen");

            Console.Write("Nhap kich thuoc mang: ");
            int n = Convert.ToInt32(Console.ReadLine());

            var arr = new List<int>();
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap gia tri tai vi tri {0} = ", i);
                arr.Add(int.Parse(Console.ReadLine()));
            }

            //a: Xóa các phần tử có giá trị = 1 và in mảng.
            while (arr.IndexOf(1) != -1) // kiểm tra xem trong mảng có phần tử có giá trị 1 không
            {
                arr.Remove(1); // xóa phần tử
            }

            Console.WriteLine("Mang sau khi xoa phan tu co gia tri  = 1: ");
            foreach (var item in arr)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine();

            //b: In mảng theo chiều ngược lại.
            Console.WriteLine("Mang theo chieu nguoc lai:");
            for (int i = arr.Count - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + "\t");
            }
            Console.WriteLine();

            //c: Kiểm tra mảng có đối xứng hay không.
            bool check = true; // biến dùng để kiểm tra xem mảng có đối xứng ko, mặc định = true
            int length = arr.Count;
            int h = length / 2; // lấy vị trí phần tử giữa
            for (int i = 0; i < h; i++)
            {
                // nếu 2 phần tử đối xứng ko bằng nhau thì gán check = false và thoát vòng lặp
                if (arr[i] != arr[length - 1 - i])
                {
                    check = false;
                    break;
                }
            }
            Console.Write("Kiem tra mang: ");
            if (check)
                Console.WriteLine("Mang doi xung");
            else
                Console.WriteLine("Mang khong doi xung");

            Console.WriteLine("=========================================DONE=========================================");
        }

        private static void Bai2()
        {
            Console.WriteLine("2. Kiem tra hoc luc");
            Console.Write("Nhap so luong diem: ");
            int n = Convert.ToInt32(Console.ReadLine());

            float[] arr = new float[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap diem thu {0} = ", i);
                arr[i] = float.Parse(Console.ReadLine());
            }

            // a.	Tính điểm trung bình
            float sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += arr[i];
            }

            float avg = sum / n;
            Console.WriteLine("Diem trung binh: " + avg);

            // b.	In ra màn hình các điểm >= điểm trung bình trên 1 dòng và < điểm trung bình trên 1 dòng.
            Console.WriteLine("Diem >= diem trung binh: ");
            for (int i = 0; i < n; i++)
            {
                if (arr[i] >= avg)
                    Console.Write(arr[i] + "\t");
            }
            Console.WriteLine();

            Console.WriteLine("Diem < diem trung binh: ");
            for (int i = 0; i < n; i++)
            {
                if (arr[i] < avg)
                    Console.Write(arr[i] + "\t");
            }
            Console.WriteLine();

            Console.WriteLine("=========================================DONE=========================================");
        }

        private static void Bai3()
        {
            Console.WriteLine("3. Bang cuu chuong");

            Console.Write("Nhap gia tri bat dau: ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Nhap gia tri ket thuc: ");
            int end = int.Parse(Console.ReadLine());

            int[,] arr = new int[end - start + 1, 10];

            // gán giá trị cho mảng
            for (int i = start; i <= end; i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i - start, j] = i * (j + 1);
                }
            }

            // a. In mảng ra màn hình
            Console.WriteLine("Bang cuu chuong tu {0} den {1}:", start, end);
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write("{0} x {1} = {2}\t", i + start, j + 1, arr[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // b. In ra màn hình theo từng dòng các hàng có chỉ số hàng là chẵn.
            Console.WriteLine("In cac hang co chi so hang chan:");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                if (i % 2 != 0)
                    continue;

                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write("{0} x {1} = {2}\t", i + start, j + 1, arr[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("=========================================DONE=========================================");
        }

    }
}
