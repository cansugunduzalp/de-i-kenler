using System;

namespace KullaniciBilgiAlma
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan verilerin alınması
            Console.Write("17365985652: ");
            string tcKimlikNo = Console.ReadLine();  // T.C. Kimlik No alındı

            Console.Write("Ardıç: ");
            string ad = Console.ReadLine();  // Ad alındı

            Console.Write("Süner: ");
            string soyad = Console.ReadLine();  // Soyad alındı

            Console.Write("056598565: ");
            string telefonNo = Console.ReadLine();  // Telefon No alındı

            Console.Write("25: ");
            int yas;
            while (!int.TryParse(Console.ReadLine(), out yas) || yas <= 0)
            {
                Console.Write("Geçersiz yaş girdiniz. Lütfen tekrar giriniz: ");
            }  // Yaş alındı ve geçersiz girişler kontrol edildi

            Console.("İlk Aldığınız Ürünün Fiyatını Giriniz: ");
            double urunFiyat1;
            while (!double.TryParse(Console.ReadLine(), out urunFiyat1) || urunFiyat1 <= 0)
            {
                Console.Write("Geçersiz fiyat girdiniz. Lütfen tekrar giriniz: ");
            }  // İlk ürün fiyatı alındı ve geçersiz girişler kontrol edildi

            Console.Write("İkinci Aldığınız Ürünün Fiyatını Giriniz: ");
            double urunFiyat2;
            while (!double.TryParse(Console.ReadLine(), out urunFiyat2) || urunFiyat2 <= 0)
            {
                Console.Write("Geçersiz fiyat girdiniz. Lütfen tekrar giriniz: ");
            }  // İkinci ürün fiyatı alındı ve geçersiz girişler kontrol edildi

            // Kullanıcı bilgilerini ekrana yazdırma
            Console.WriteLine("\n--- Girilen Bilgiler ---");
            Console.WriteLine($"T.C. Kimlik Numarası: {tcKimlikNo}");
            Console.WriteLine($"Adı: {ad}");
            Console.WriteLine($"Soyadı: {soyad}");
            Console.WriteLine($"Telefon Numarası: {telefonNo}");
            Console.WriteLine($"Yaşı: {yas}");

            // Ürün fiyatına göre mesaj gösterme
            double toplamFiyat = urunFiyat1 + urunFiyat2;

            if (toplamFiyat > 1000)
            {
                Console.WriteLine("\nToplam alışveriş tutarınız 1000 TL'den fazla. Lütfen dikkatli alışveriş yapınız.");
            }
            else if (toplamFiyat > 500)
            {
                Console.WriteLine("\nToplam alışveriş tutarınız 500 TL ile 1000 TL arasında. İyi alışverişler!");
            }
            else
            {
                Console.WriteLine("\nToplam alışveriş tutarınız 500 TL'den az. Ekstra indirim fırsatlarını kaçırmayın!");
            }

            Console.WriteLine("\nİyi günler dileriz!");
        }
    }
}
