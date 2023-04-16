using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Data data = new Data();

            data.NIM = "22.11.4836";
            data.NAMA = "Fisan Syafa Nayoma";
            data.ALAMAT = "IF05";
            data.KELAS = "Argorejo, Sedayu, Bantul, D.I.Yogyakarta";
            data.IPK = 3.76f;

            data.outdata();

            Console.Write("Press C to close this program ");
            while (Console.ReadKey().Key != ConsoleKey.C) { }
        }
    }
}
