using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_ile_basit_hesap_makinesi_836
{
    internal class Hesapmk
    {
        public int sayi1;
        public int sayi2;

        public double topla()
        {
            return sayi1 + sayi2;
        }

        public double cikar()
        {
            return sayi1- sayi2;
        }

        public double carp()
        {
            return sayi1 * sayi2;
        }

        public double bol()
        {
            return sayi1 / sayi2;
        }

    }
}
