namespace pertemuan1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>();

            string jawaban;
            do
            {
                Console.Write("Apakah anda ingin menambahkan data mahasiswa (y/n)");
                jawaban = Console.ReadLine();

                if (jawaban.ToLower() == "y")
                {
                    Console.Write("Masukkan nama Mahasiswa: ");
                    string nama = Console.ReadLine();
                    Console.Write("Masukkan nim Mahasiswa: ");
                    string nim = Console.ReadLine();
                    Console.Write("Masukkan jurusan Mahasiswa: ");
                    string jurusan = Console.ReadLine();
                     Console.Write("Masukkan tahun angkatan Mahasiswa: ");
                    int angkatan = int.Parse( Console.ReadLine());

                    //Console.Write("Masukkan tahun angkatan Mahasiswa: ");
                    //int angkatan = Console.ReadLine();

                    Mahasiswa mhs = new Mahasiswa(nama, nim, jurusan,angkatan);
                    daftarMahasiswa.Add(mhs);
                }
            } while (jawaban.ToLower() != "n");
            Console.WriteLine("\nDaftar Mahasiswa: ");

            foreach (Mahasiswa mhs in daftarMahasiswa)
            {
                mhs.PrintInfo();
            }
            Console.WriteLine("\nTerima kasih telah menggunakan program ini.");
            Console.ReadKey();
        }
    }
}