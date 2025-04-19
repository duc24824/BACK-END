using System;

class Program
{
    //LAP1.1
    //bài1
    static void Main(string[] args)
    {
        Console.Write("Nhập tên của bạn: ");
        string ten = Console.ReadLine();

        Console.Write("Nhập tuổi của bạn: ");
        int tuoi = int.Parse(Console.ReadLine());

        Console.WriteLine($"Xin chào {ten}, bạn {tuoi} tuổi!");
    }

    //bài2
    static void Main(string[] args)
    {
        Console.Write("Nhập chiều dài: ");
        double chieuDai = double.Parse(Console.ReadLine());

        Console.Write("Nhập chiều rộng: ");
        double chieuRong = double.Parse(Console.ReadLine());

        double dienTich = chieuDai * chieuRong;

        Console.WriteLine($"Diện tích hình chữ nhật là: {dienTich}");
    }

    //bài3
    static void Main(string[] args)
    {
        Console.Write("Nhập nhiệt độ (°C): ");
        double doC = double.Parse(Console.ReadLine());

        double doF = (doC * 9 / 5) + 32;

        Console.WriteLine($"{doC}°C tương đương {doF}°F");
    }

    //bài4
    static void Main(string[] args)
    {
        Console.Write("Nhập một số nguyên: ");
        int so = int.Parse(Console.ReadLine());

        if (so % 2 == 0)
            Console.WriteLine($"{so} là số chẵn.");
        else
            Console.WriteLine($"{so} là số lẻ.");
    }

    //bài5
    static void Main(string[] args)
    {
        Console.Write("Nhập số thứ nhất: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Nhập số thứ hai: ");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine($"Tổng: {a + b}");
        Console.WriteLine($"Tích: {a * b}");
    }

    //bài6
    static void Main(string[] args)
    {
        Console.Write("Nhập một số: ");
        double so = double.Parse(Console.ReadLine());

        if (so > 0)
            Console.WriteLine("Đây là số dương.");
        else if (so < 0)
            Console.WriteLine("Đây là số âm.");
        else
            Console.WriteLine("Đây là số không.");
    }

    //bài7
    static void Main(string[] args)
    {
        Console.Write("Nhập năm: ");
        int nam = int.Parse(Console.ReadLine());

        if ((nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0))
            Console.WriteLine($"{nam} là năm nhuận.");
        else
            Console.WriteLine($"{nam} không phải là năm nhuận.");
    }

    //bài8
    static void Main(string[] args)
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"\nBảng cửu chương {i}:");
            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine($"{i} x {j} = {i * j}");
            }
        }
    }

    //bài9
    static void Main(string[] args)
    {
        Console.Write("Nhập số nguyên dương: ");
        int n = int.Parse(Console.ReadLine());

        long giaiThua = 1;
        for (int i = 1; i <= n; i++)
            giaiThua *= i;

        Console.WriteLine($"Giai thừa của {n} là {giaiThua}");
    }

    //bài10
    static void Main(string[] args)
    {
        Console.Write("Nhập số nguyên: ");
        int so = int.Parse(Console.ReadLine());

        if (so < 2)
        {
            Console.WriteLine($"{so} không phải là số nguyên tố.");
        }
        else
        {
            bool laSoNguyenTo = true;
            for (int i = 2; i <= Math.Sqrt(so); i++)
            {
                if (so % i == 0)
                {
                    laSoNguyenTo = false;
                    break;
                }
            }
            Console.WriteLine(laSoNguyenTo ? $"{so} là số nguyên tố." : $"{so} không phải là số nguyên tố.");
        }
    }

    //LAP1.2
    //bài1
    static int TinhTongSoChan(int[] arr)
    {
        int tong = 0;
        foreach (int so in arr)
        {
            if (so % 2 == 0)
                tong += so;
        }
        return tong;
    }

    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5, 6 };
        Console.WriteLine("Tổng các số chẵn: " + TinhTongSoChan(arr));
    }

    //bài2
    static bool LaSoNguyenTo(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }

    static void Main()
    {
        Console.Write("Nhập số phần tử: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"arr[{i}] = ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Các phần tử là số nguyên tố:");
        for (int i = 0; i < n; i++)
        {
            if (LaSoNguyenTo(arr[i]))
                Console.WriteLine($"arr[{i}] = {arr[i]}");
        }
    }

    //bài3
    static void DemSoAmVaSoDuong(int[] arr, out int demAm, out int demDuong)
    {
        demAm = 0;
        demDuong = 0;
        foreach (int so in arr)
        {
            if (so < 0)
                demAm++;
            else if (so > 0)
                demDuong++;
        }
    }

    static void Main()
    {
        Console.Write("Nhập số phần tử: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"arr[{i}] = ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        DemSoAmVaSoDuong(arr, out int am, out int duong);
        Console.WriteLine($"Số âm: {am}, Số dương: {duong}");
    }

    //bài4
    static int TimSoLonThuHai(int[] arr)
    {
        int max = int.MinValue;
        int secondMax = int.MinValue;

        foreach (int so in arr)
        {
            if (so > max)
            {
                secondMax = max;
                max = so;
            }
            else if (so > secondMax && so < max)
            {
                secondMax = so;
            }
        }
        return secondMax;
    }

    static void Main()
    {
        Console.Write("Nhập số phần tử: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"arr[{i}] = ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        int secondMax = TimSoLonThuHai(arr);
        Console.WriteLine($"Số lớn thứ hai là: {secondMax}");
    }

    //bài5
    static void HoanVi(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    static void Main()
    {
        Console.Write("Nhập a = ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Nhập b = ");
        int b = int.Parse(Console.ReadLine());

        HoanVi(ref a, ref b);
        Console.WriteLine($"Sau khi hoán vị: a = {a}, b = {b}");
    }

    //bài6
    static void SapXepTangDan(double[] arr)
    {
        Array.Sort(arr);
    }

    static void Main()
    {
        Console.Write("Nhập số phần tử: ");
        int n = int.Parse(Console.ReadLine());

        double[] arr = new double[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"arr[{i}] = ");
            arr[i] = double.Parse(Console.ReadLine());
        }

        SapXepTangDan(arr);

        Console.WriteLine("Mảng sau khi sắp xếp tăng dần:");
        foreach (double val in arr)
        {
            Console.Write(val + " ");
        }
    }
}