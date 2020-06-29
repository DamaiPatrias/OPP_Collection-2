using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OPP_Collection_2._0.KelasInduk;

namespace OPP_Collection_2._0.KelasAnak
{

    
        public class Sales : Karyawan
        {
            public double jumlahpenjualan { get; internal set; }
            public double komisi { get; internal set; }
            public override double Gaji()
            {
                return jumlahpenjualan * komisi;
            }
        }
    
}
