using System.Runtime.CompilerServices;

abstract class PaketMBG
{
    public abstract void HitungBiaya (int jumlah)
    {
        Console.WriteLine("Menghitung biaya paket MBG");
    }

    private string idPaket { get; set; }
    private string namaPaket { get; set; }
    private int stokDapur { get; set; }

    public int StokDapur
    {
        get { return stokDapur; }
    }

    public void TambahStok(int jumlah)
    {
        if (stokDapur >= 0)
        {
            stokDapur += jumlah;
        }
        else
        {
            Console.WriteLine("Stok tidak boleh negatif.");
        }
    }

    public void KurangiStok(int jumlah)
    {
        if (stokDapur < jumlah)
        {
            Console.WriteLine("Stok tidak mencukupi.");
        }
        else
        {
            stokDapur -= jumlah;
        }
    }

    public void TampilInfo()
    {
        Console.WriteLine("ID Paket: " + idPaket);
        Console.WriteLine("Nama Paket: " + namaPaket);
        Console.WriteLine("Stok Dapur: " + stokDapur);
    }
}

//class PaketMBG
//{ 
//    public virtual void HitungBiaya(int jumlah)
//    {
//        Console.WriteLine("Menghitung biaya paket MBG");
//    }

//    private string idPaket { get; set; }
//    private string namaPaket { get; set; }
//    private int stokDapur { get; set; }

//    public int StokDapur
//    {
//            get { return stokDapur; }
//        }

//    public void TambahStok(int jumlah)
//    {
//        if (stokDapur >= 0)
//        {
//            stokDapur += jumlah;
//        }
//        else
//        {
//            Console.WriteLine("Stok tidak boleh negatif.");
//        }
//    }

//    public void KurangiStok(int jumlah)
//    {
//        if (stokDapur < jumlah)
//        {
//            Console.WriteLine("Stok tidak mencukupi.");
//        }
//        else
//        {
//            stokDapur -= jumlah;
//        }
//    }

//    public void TampilInfo()
//    {
//        Console.WriteLine("ID Paket: " + idPaket);
//        Console.WriteLine("Nama Paket: " + namaPaket);
//        Console.WriteLine("Stok Dapur: " + stokDapur);
//    }
//}

class PaketReguler : PaketMBG
{
    public override void HitungBiaya(int jumlah)
    { 
        int totalBiaya = 15000 * jumlah;
        Console.WriteLine("Total Biaya Paket Reguler: Rp " + totalBiaya);
    }
    public void TampilInfo()
    { 
        Console.WriteLine("Harga: Rp 15.000");
        Console.WriteLine("Isi Paket: Nasi, Ayam, Sayur, Buah");
    }

}

class PaketKhusus : PaketMBG
{
    public override void HitungBiaya(int jumlah)
    {
            int totalBiaya = 20000 * jumlah;
            Console.WriteLine("Total Biaya Paket Khusus: Rp " + totalBiaya);    
    }
    public string jenisDiet()
    {
        Console.WriteLine("Rendah Gula, Vegetarian, atau Bebas Gluten");
        Console.WriteLine("Harga: Rp 20.000");
        return "Rendah Gula, Vegetarian, atau Bebas Gluten";
    }
}


class program
{
    static void Main(string[] args)
    {
       PaketReguler paket1 = new PaketReguler();
       PaketKhusus paket2 = new PaketKhusus();

       paket1.TampilInfo();
       paket2.TampilInfo();
       paket2.jenisDiet();

       paket1.HitungBiaya(3);
       paket2.HitungBiaya(5);

    }
}



