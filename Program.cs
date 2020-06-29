using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OPP_Collection_2._0.KelasInduk;
using OPP_Collection_2._0.KelasAnak;

namespace OPP_Collection_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Karyawan> ListKaryawan = new List<Karyawan>();
            void Tampil()
            {
                int nomer1 = 1;
                foreach (Karyawan karyawan in ListKaryawan )
                {
                    Console.WriteLine("|{0}. |Nama = {1} |NIK = {2} |Gaji = {3}|",
                        nomer1, karyawan.nama, karyawan.nik, karyawan.Gaji());
                    nomer1++;
                }

            }
            void TambahKaryawaTetap(string nama, string nik, double gaji)
            {
                ListKaryawan.Add(new KaryawanTetap {nama = nama, nik = nik, gajibulanan = gaji});
            }
            void TambahKaryawanHarian (string nama, string nik, double upahperjam, double jamkerja)
            {
                ListKaryawan.Add(new KaryawanTetap { nama = nama, nik = nik, upahperjam = upahperjam, jumlahjamkerja = jamkerja});
            }
            void TambahSales (string nama, String nik, double penjualan, double komisi)
            {
                ListKaryawan.Add(new KaryawanTetap { nama = nama, nik = nik, jumlahpenjualan = penjualan, komisi = komisi});
            }
            void Hapus()
            {
                int nomer2 = 1;
                int jumlahkaryawan = 1;

                foreach (Karyawan karyawan in ListKaryawan)
                {
                    Console.WriteLine("{0}. ,NIK = {1}", nomer2, karyawan.nik);
                    nomer2++;
                    jumlahkaryawan += 1;
                }
                Console.Write("\nPilih NIK Karyawan yang akan dihapus [1 - ");
                Console.Write(jumlahkaryawan);
                Console.Write("1] : ");
                int nik_karyawan = int.Parse(Console.ReadLine());
                nik_karyawan = nik_karyawan - 1;

                ListKaryawan.RemoveAt(nik_karyawan);
                Console.WriteLine("Data karyawan berhasil dihapus...");

            }
            int pilA;
            do
            {
                Console.WriteLine("=== MENU PROGRAM KARYAWAN ===\n");
                Console.WriteLine("1. Tambah karyawan baru\n2. Hapus Karyawan\n3. Tampilkan data karyawan\n4. keluar");
                Console.Write("\nMasukkan pilihan [1...4] : ");
                pilA = int.Parse(Console.ReadLine());

                if (pilA == 1)
                {

                    Console.WriteLine("|1. Karyawan Tetap | 2. karyawan Harian | 3. Sales|");
                    Console.Write("Masukkan Pilihan [1...3] : ");
                    int pilB = int.Parse(Console.ReadLine());
                    if (pilB == 1)
                    {
                        Console.Write("NIK  : "); string nik = Console.ReadLine();
                        Console.Write("Nama : "); string nama = Console.ReadLine();
                        Console.Write("Gaji : "); double gajibulanan = double.Parse(Console.ReadLine());
                        TambahKaryawaTetap(nik, nama, gajibulanan);

                    }
                    else if (pilB == 2)
                    {                        
                        Console.Write("NIK          : "); string nik = Console.ReadLine();
                        Console.Write("Nama         : "); string nama = Console.ReadLine();
                        Console.Write("Jam Kerja    : "); double upahperjam = double.Parse(Console.ReadLine());
                        Console.Write("Upah per jam : "); double jamkerja  = double.Parse(Console.ReadLine());
                        TambahKaryawanHarian(nik, nama, upahperjam, jamkerja);  
                    }
                    else if (pilB == 3)
                    {

                      
                        Console.Write("NIK              : "); string nik = Console.ReadLine();
                        Console.Write("Nama             : "); string nama = Console.ReadLine();
                        Console.Write("Jumlah pejualan  : "); double jumlahpenjualan = double.Parse(Console.ReadLine());
                        Console.Write("Komisi           : "); double komisi = double.Parse(Console.ReadLine());
                        TambahSales(nik, nama, jumlahpenjualan, komisi);
                    }
                    else
                    {
                        Console.WriteLine("Pilihan tidak ada...");
                    }

                }
                else if (pilA == 2)
                {
                    Hapus();
                    Console.WriteLine("------------------------------");
                }
                else if (pilA == 3)
                {
                    Console.WriteLine("=== Data Karyawan ===");
                    Tampil();
                    Console.WriteLine("-----------------------------");
                }
                else
                {
                    Console.WriteLine("Pilihan tidak tersedia...");
                }

                Console.ReadKey();

            }
            while (pilA != 4);



        }
    }
}
