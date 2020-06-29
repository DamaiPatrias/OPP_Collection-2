using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_Collection_2._0.KelasInduk
{

        public abstract class Karyawan
        {
            public string nik { get; set; }
            public string nama { get; set; }
        public abstract double Gaji();
        //public abstract void Gaji();
        }

    
}
