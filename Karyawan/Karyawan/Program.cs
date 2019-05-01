using System;

namespace Karyawan
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan a = new Karyawan();

            a.Nik = "18112270";
            a.Nama = "Gusti";
            a.GajiBulanan = 3000000;

            Karyawan b = new Karyawan();

            b.Nik = "18112290";
            b.Nama = "Paijo";
            b.GajiBulanan = 2000000;

            Console.WriteLine("============================================================");
            Console.WriteLine("No.\tNik\tNama\t\tGaji Bulanan");
            Console.WriteLine("============================================================");
            Console.WriteLine("1.\t{0}  {1}\t\t{2}", a.Nik, a.Nama, a.GajiBulanan);
            Console.WriteLine("2.\t{0}  {1}\t\t{2}", b.Nik, b.Nama, b.GajiBulanan);

            Console.WriteLine("============================================================");
            Console.WriteLine("\n");
            Console.WriteLine("Kenaikan Gaji Sebesar 10%");
            Console.WriteLine("============================================================");
            Console.WriteLine("No.\tNik\tNama\t\tGaji Bulanan");
            Console.WriteLine("============================================================");
            Console.WriteLine("1.\t{0}  {1}\t\t\t{2}", a.Nik, a.Nama, a.GajiBulanan + (a.GajiBulanan * 0.10));
            Console.WriteLine("2.\t{0}  {1}\t\t\t{2}", b.Nik, b.Nama, b.GajiBulanan + (b.GajiBulanan * 0.10));
            Console.WriteLine("============================================================");
            Console.ReadKey();
        }
    }
}
