using System;

class Buku
{
    public int ID;
    public string Judul;
    public string Penulis;
    public int Tahun;
    public string Status;
}

class Perpustakaan
{
    public List<Buku> daftarBuku = new List<Buku>();

    public void TambahBuku()
    {
        Buku b = new Buku();
        Console.Write("Masukkan ID buku       : "); b.ID = int.Parse(Console.ReadLine());
        Console.Write("Masukkan Judul buku    : "); b.Judul = Console.ReadLine();
        Console.Write("Masukkan Penulis buku  : "); b.Penulis = Console.ReadLine();
        Console.Write("Masukkan Tahun Terbit  : "); b.Tahun = int.Parse(Console.ReadLine());
        Console.Write("Status (tersedia/dipinjam): "); b.Status = Console.ReadLine();
        daftarBuku.Add(b);
        Console.WriteLine("Buku berhasil ditambahkan");
    }

    public void LihatBuku()
    {
        if (daftarBuku.Count == 0)
        {
            Console.WriteLine("Belum ada buku dalam perpustakaan");
            return;
        }

        for (int i = 0; i < daftarBuku.Count; i++)
        {
            Buku b = daftarBuku[i];
            Console.WriteLine($"ID: {b.ID}, Judul: {b.Judul}, Penulis: {b.Penulis}, Tahun: {b.Tahun}, Status: {b.Status}");
        }
    }

    public void UbahBuku()
    {
        Console.Write("Masukkan ID buku yang ingin diubah: ");
        int id = int.Parse(Console.ReadLine());
        bool ditemukan = false;

        for (int i = 0; i < daftarBuku.Count; i++)
        {
            if (daftarBuku[i].ID == id)
            {
                Console.Write("Judul baru   : "); daftarBuku[i].Judul = Console.ReadLine();
                Console.Write("Penulis baru : "); daftarBuku[i].Penulis = Console.ReadLine();
                Console.Write("Tahun baru   : "); daftarBuku[i].Tahun = int.Parse(Console.ReadLine());
                Console.Write("Status baru  : "); daftarBuku[i].Status = Console.ReadLine();
                Console.WriteLine("Data buku berhasil diubah");
                ditemukan = true;
                break;
            }
        }

        if (!ditemukan)
        {
            Console.WriteLine("Buku tidak ditemukan");
        }
    }

    public void HapusBuku()
    {
        Console.Write("Masukkan ID buku yang ingin dihapus: ");
        int id = int.Parse(Console.ReadLine());
        bool ditemukan = false;

        for (int i = 0; i < daftarBuku.Count; i++)
        {
            if (daftarBuku[i].ID == id)
            {
                daftarBuku.RemoveAt(i);
                Console.WriteLine("Buku berhasil dihapus.");
                ditemukan = true;
                break;
            }
        }

        if (!ditemukan)
        {
            Console.WriteLine("Buku tidak ditemukan.");
        }
    }
}

class Program
{
    static void Main()
    {
        Perpustakaan perpus = new Perpustakaan();

        while (true)
        {
            Console.WriteLine("\nMENU PERPUSTAKAAN");
            Console.WriteLine("1. Tambah Buku");
            Console.WriteLine("2. Lihat Daftar Buku");
            Console.WriteLine("3. Ubah Data Buku");
            Console.WriteLine("4. Hapus Buku");
            Console.WriteLine("5. Keluar");
            Console.Write("Pilihan Anda: ");
            string pilihan = Console.ReadLine();

            switch (pilihan)
            {
                case "1": perpus.TambahBuku(); break;
                case "2": perpus.LihatBuku(); break;
                case "3": perpus.UbahBuku(); break;
                case "4": perpus.HapusBuku(); break;
                case "5": return;
                default: Console.WriteLine("Pilihan tidak tersedia"); break;
            }
        }
    }
}
