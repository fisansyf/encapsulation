using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation
{
    internal class Data
    {
        //field
        private string nim;
        private string nama;
        private float ipk;
        public string alamat; 
        public string kelas;

        //properties
        public string NIM
        {
            get
            {
                return nim;
            }
            set
            {
                nim = value;
            }
        }
        public string NAMA
        {
            get
            {
                return nama;
            }
            set
            {
                nama = value;
            }
        }
        public float IPK
        {
            get
            {
                return ipk;
            }
            set
            {
                ipk = value;
            }
        }

        /*
        private string NIM { get; set; }   
        private string NAMA { get; set; }
        private float IPK { get; set; }
        */

        public string ALAMAT
        {
            get
            {
                return alamat;
            }
            set
            {
                alamat = value;
            }
        }
        public string KELAS
        {
            get
            {
                return kelas;
            }
            set
            {
                kelas = value;
            }
        }
        
        /*    
        public string ALAMAT { get; set; }
        public string KELAS { get; set; }
        */

        //method
        public void outdata()
        {
            Console.WriteLine("NIM      : {0}", nim);
            Console.WriteLine("NAMA     : {0}", nama);
            Console.WriteLine("KELAS    : {0}", kelas);
            Console.WriteLine("ALAMAT   : {0}", alamat);
            Console.WriteLine("IPK      : {0}", ipk);
            if(ipk < 2) 
            {
                Console.WriteLine("Maaf, {0} dengan NIM {1} kelas {2} harus mengulang.", nama, nim, kelas);
            }
            else
            {
                Console.WriteLine("Selamat, {0} dengan NIM {1} kelas {2} lulus!!!", nama, nim, kelas);
            }
        }
    }
}
