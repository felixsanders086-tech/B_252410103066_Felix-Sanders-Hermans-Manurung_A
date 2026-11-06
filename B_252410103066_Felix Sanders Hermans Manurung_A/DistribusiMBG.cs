interface DapatDidistribusikan
{
    void KirimPaket();
}

class DistribusiMBG : DapatDidistribusikan
{
    public Sekolah Sekolah { get; }
    public PaketMBG Paket { get; }
    public int Jumlah { get; }

    public DistribusiMBG(Sekolah sekolah, PaketMBG paket, int jumlah)
    {
        Sekolah = sekolah;
        Paket = paket;
        Jumlah = jumlah;
    }

    public void KirimPaket()
    {
        if (Sekolah == nul)
        {
            Console.WriteLine("Distribusi gagal: sekolah tujuan belum ditentukan.");
            return;
        }

        if (Paket == null)
        {
            Console.WriteLine("Distribusi gagal: paket makanan belum ditentukan.");
            return;
        }

        if (Jumlah <= 0)
        {
            Console.WriteLine("Distribusi gagal: jumlah paket harus lebih dari 0.");
            return;
        }

        if (Jumlah > Paket.StokDapur)
        {
            Console.WriteLine("Distribusi gagal: jumlah paket melebihi stok dapur yang tersedia.");
            return;
        }

        Paket.KurangiStok(Jumlah);
        Sekolah.jumlahPaketDiterima += Jumlah;

        Console.WriteLine($"Distribusi MBG berhasil! Sebanyak {Jumlah} paket makanan telah dikirim ke sekolah {Sekolah.namaSekolah}.");
    }
}