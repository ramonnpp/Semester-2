using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pertemuan1
{
    internal class Mahasiswa
    {
        public string Nama { get; set; }
        public string NIM { get; set; }
        public string Jurusan { get; set; }
        public int Angkatan { get; set; }

        public Mahasiswa(string nama, string nim, string jurusan, int angkatan)
        {
            Nama = nama;
            NIM = nim;
            Jurusan = jurusan;
            Angkatan = angkatan;
        }
        public void PrintInfo()
        {
            Console.WriteLine("Nama\t : " + Nama);
            Console.WriteLine("NIM\t : " + NIM);
            Console.WriteLine("Jurusan\t : " + Jurusan);
            Console.WriteLine("Angkatan\t : " + Angkatan);
            Console.WriteLine();
        }
    }
      
}
