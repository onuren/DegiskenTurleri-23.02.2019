using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegiskenTurleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //Yorum Satırı
            //değişken türü, değişken adı, atama operatörü, değer

            //0 ile 255 arasında değer alır
            //8 bitlik yer kaplar
            //byte byt = 256;
            byte byt = 255;
            Console.WriteLine(byt);

            //8 bitlik yer kaplar
            //-128 ile 127 arasında değer alır
            sbyte sbyt = 127;
            Console.WriteLine(sbyt);

            //16 bitlik yer kaplar
            //-32768 ile 32767 arasında değer alır
            short shrt = -6547;
            Console.WriteLine(shrt);

            //32 bitlik yer kaplar
            //-2147483648 ile 2147483647 arasında değer alır
            int sayi = 35698;
            Console.WriteLine(sayi);


            //64 bitlik yer kaplar
            //-9223372036854775808 ile 9223372036854775807
            long lng = 65465;
            Console.WriteLine(lng);

            //16 bitlik yer kaplar
            //0 ile 65535 arasında değer alır
            ushort ushrt = 10;
            Console.WriteLine(ushrt);

            //32 bitlik yer kaplar
            //0 ile 4294967295 arasında değer alır
            uint pozitifsayi = 10;
            Console.WriteLine(pozitifsayi);

            //64 bitlik yer kaplar
            //0 ile 18446744073709551615 arasında değer alır
            ulong ulng = 10;
            Console.WriteLine(ulng);

            //ONDALIK SAYI DEĞİŞKENLERİ
            //32 bitlik yer kaplar
            float bilimsel = 12.9f;
            Console.WriteLine(bilimsel);

            //64 bitlik yer kaplar
            double ondalik = 12.9;
            Console.WriteLine(ondalik);

            //128 bitlik yer kaplar
            decimal parasal = 12.9m;
            Console.WriteLine(parasal);

            //16 bitlik yer kaplar
            //65-90 büyük karakterler
            //97-122 küçük karakterler
            char karakter = 'A';
            Console.WriteLine(karakter);

            //string değişken olarak kullanılan bir karakter dizisidir.
            string metinsel = "Merhaba Dünya";
            Console.WriteLine(metinsel);

            bool tamammi = true;//false
            Console.WriteLine(tamammi);

            Console.ReadLine();
        }
    }
}
