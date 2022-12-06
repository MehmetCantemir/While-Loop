namespace While_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //While
            //1 den başlayarak console dan girilens ayıya kadar ortalama hesaplayıp console yazdıran program
            int sayi = Convert.ToInt32(Console.ReadLine());
            int sayac= 1;
            int toplam = 0;
            while (sayac<=sayi)
            {
                toplam += sayac;
                sayac++;
            }
            Console.WriteLine("Toplam sayının ortalaması = " + (toplam / sayi));
        }
    }
}