using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OPP_Collection_2._0.KelasInduk;

namespace OPP_Collection_2._0.KelasAnak
{
    public class KaryawanTetap : Karyawan
    {
        public double gajibulanan { get; set; }
        public double upahperjam { get; internal set; }
        public double jumlahjamkerja { get; internal set; }
        public double jumlahpenjualan { get; internal set; }
        public double komisi { get; internal set; }

        public override double Gaji()
        {
            return gajibulanan;

        }
        /*public override void Gaji()
        {
            Karyawan karyawan;

            Console.Write("Nama : "); karyawan.nama 
        }*/
    }
}
