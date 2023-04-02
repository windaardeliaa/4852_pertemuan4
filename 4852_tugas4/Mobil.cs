using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4852tugas4
{
    internal class Mobil
    {
        //field
        private string _warna;
        private int _jumlahpintu;
        private string _merek;
        private string _model;
        private int _tahunkeluaran;
        private string _suara;
        private int _kecepatan;


        //properties
        public string Warna
        {
            get
            {
                return _warna;
            }
            set
            {
                _warna = value;
            }
        }
        public int JumlahPintu
        {
            get
            {
                return _jumlahpintu;
            }
            set
            {
                _jumlahpintu = value;
            }
        }
        public string Merek
        {
            get
            {
                return _merek;
            }
            set
            {
                _merek = value;
            }
        }
        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;
            }
        }
        public int TahunKeluaran
        {
            get
            {
                return _tahunkeluaran;
            }
            set
            {
                _tahunkeluaran = value;

            }
        }
        public string Suara
        {
            get
            {
                return _suara;
            }
            set
            {
                _suara = value;
            }
        }
        public int Kecepatan
        {
            get
            {
                return _kecepatan;
            }
            set
            {
                _kecepatan = value;
            }
        }


        //method
        public void Gas()
        {
            Console.WriteLine($"Mobil {Model}, kecepatan {Kecepatan} Km/jam");
        }

        public void Klakson()
        {
            Console.WriteLine($"Suara Klakson {Suara}");
        }

        public void TampilkanInfo()
        {
            Console.WriteLine($"Mobil saya berwarna {Warna}, Merk {Merek}, Model {Model}, Keluaran tahun {TahunKeluaran}, dengan jumlah pintu sebanyak {JumlahPintu}");

        }
    }
}

