using System;

namespace Yanacaq_Doldurma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Degisken tanimlama
            double dizel = 3.12, benzin = 3.28, lpg = 1.78;
            double dizeltank = 1000, benzintank = 1000,lpgtank = 1000;
            double satismiktari = 0;
            char anamenusecim = '0', altmenusecim = '0', akaryakitfiyatguncelle = '0', akaryakitsatistipi = '0';
            //Ana Menu Olusturma
            MENU:
            Console.WriteLine("AKaryakit Satis Takip");
            Console.WriteLine(".....................");
            Console.WriteLine("1-Birim Fiyat Göstergesi");
            Console.WriteLine("2-Birim Fiyat Güncelle");
            Console.WriteLine("3-AKaryakıt Satışı Yap");
            Console.WriteLine("4-Depo Durumunu Göster");
            Console.WriteLine("5-Toplam Satışları Göster");
            Console.WriteLine("6-Çıkış");

            Console.WriteLine("Seciminiz Yapiniz [1,2,3,4,5,6];");
            anamenusecim = Convert.ToChar(Console.ReadLine());
            if (anamenusecim=='1')
            {
                Console.Clear();
                Console.WriteLine(">>Seciminiz:1");
                Console.WriteLine("---Birim Fiyatlari Listesi---");
                Console.WriteLine("Dizel (D):{0} TL/litre",dizel);
                Console.WriteLine("Benzin (D):{0} TL/litre", benzin);
                Console.WriteLine("LPG (D):{0} TL/litre", lpg);
                ALTMENU:
                Console.WriteLine("Sseçiminizi yapın[1: Ana Menuye Don 2:Programi Kapat]:");
                altmenusecim= Convert.ToChar(Console.ReadLine());
                if (altmenusecim=='1')
                {
                    Console.Clear();
                    goto MENU;
                }
                else if (altmenusecim=='2')
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("1-2 Seçenekleri Dışında Yanlış Seçim Yaptınız!");
                    goto ALTMENU;
                }

            }
            else if (anamenusecim=='2')
            {
                Console.Clear();
                Console.WriteLine(">>Seçiminiz:2");
                Console.WriteLine("--Birim Fiyatlar Guncelleme---");
                AKARYAKITTIPI:
                Console.WriteLine("Akaryakit Tipini Secin [D,B,L]");
                akaryakitfiyatguncelle = Convert.ToChar(Console.ReadLine());
                if (akaryakitfiyatguncelle=='D' || akaryakitfiyatguncelle=='d')
                {
                    Console.WriteLine("Dizel (D):{0} TL/Litre", dizel);
                    Console.Write("Dizel Yakit Icin Yeni Fiyat Giriniz:");
                    dizel = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Degisiklik Yapilmistir");
                    Console.WriteLine("Dizel (D):{0} TL/Litre",dizel);

                }
                else if (akaryakitfiyatguncelle == 'B' || akaryakitfiyatguncelle == 'b')
                {
                    Console.WriteLine("Benzin (B):{0} TL/Litre", benzin);
                    Console.Write("Benzin Yakit Icin Yeni Fiyat Giriniz:");
                    benzin = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Degisiklik Yapilmistir");
                    Console.WriteLine("Benzin (B):{0} TL/Litre", benzin);

                }
                else if (akaryakitfiyatguncelle == 'L' || akaryakitfiyatguncelle == 'l')
                {
                    Console.WriteLine("LPG (D):{0} TL/Litre", lpg);
                    Console.Write("LPG Yakit Icin Yeni Fiyat Giriniz:");
                    lpg = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Degisiklik Yapilmistir");
                    Console.WriteLine("LPG (D):{0} TL/Litre", lpg);

                }
                else
                {
                    Console.WriteLine("[D,B,L] disinda hatali secim yaptiniz!");
                    goto AKARYAKITTIPI;
                }
            ALTMENU:
                Console.WriteLine("Sseçiminizi yapın[1: Ana Menuye Don 2:Programi Kapat]:");
                altmenusecim = Convert.ToChar(Console.ReadLine());
                if (altmenusecim == '1')
                {
                    Console.Clear();
                    goto MENU;
                }
                else if (altmenusecim == '2')
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("1-2 Seçenekleri Dışında Yanlış Seçim Yaptınız!");
                    goto ALTMENU;
                }
            }
            else if (anamenusecim == '3')
            {
                Console.Clear();
                Console.WriteLine("---AKaryakit Satış İşlemleri");
            AKARYAKITSATIŞI:
                Console.WriteLine("Akaryakıt Tipini Seçin[D,B,L]");
                akaryakitsatistipi = Convert.ToChar(Console.ReadLine());
                if (akaryakitsatistipi=='D'|| akaryakitsatistipi=='d')
                {
                    if (dizeltank==0)
                    {
                        Console.WriteLine("Yakıt tankında hiç dizel yakıt kalmamışdır");
                        goto MENU;
                    }
                    else
                    {
                        Console.WriteLine("Ne kadarlık dizel yakıt alacaksınızI");
                        satismiktari= Convert.ToDouble(Console.ReadLine());
                        if (dizeltank<satismiktari)
                        {
                            Console.WriteLine("Yakıt tankında {0} litre dizel yakıt vardır! İşlem yapılmadı!",dizeltank);
                            goto MENU;
                        }
                        else if (satismiktari<=dizeltank)
                        {

                        }
                    }
                }
            }


            Console.ReadKey();

        }
    }
}
