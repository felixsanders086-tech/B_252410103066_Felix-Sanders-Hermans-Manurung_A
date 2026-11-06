class Sekolah
{
    public string idSekolah;
    public string namaSekolah;
    public int jumlahPaketDiterima;

    public void TampilInfo()
    {
        Console.WriteLine("ID Sekolah: " + idSekolah);
        Console.WriteLine("Nama Sekolah: " + namaSekolah);
        Console.WriteLine("Jumlah Paket Diterima: " + jumlahPaketDiterima);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Sekolah sekolah1 = new Sekolah();
        sekolah1.idSekolah = "S1";
        sekolah1.namaSekolah = "SMAN 1 Malang";
        sekolah1.jumlahPaketDiterima = 50;

        Sekolah sekolah2 = new Sekolah();
        sekolah2.idSekolah = "S2";
        sekolah2.namaSekolah = "SMAN 2 Malang";
        sekolah2.jumlahPaketDiterima = 30;

        Console.WriteLine("Informasi Sekolah 1:");
        sekolah1.TampilInfo();
        Console.WriteLine("\nInformasi Sekolah 2:");
        sekolah2.TampilInfo();
    }
}