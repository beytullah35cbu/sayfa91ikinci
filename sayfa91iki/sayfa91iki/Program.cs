using System;

namespace or220
{
    class Program
    { //Yukarıdaki programı, dizi değerleri dışarıdan girilecek şekilde düzenleyiniz.
        public static void Main(string[] args)
        {
            Console.Write("Dizi Uzunluğunu Giriniz: ");
            int uzunluk = Convert.ToInt32(Console.ReadLine());

            int[] dizi = new int[uzunluk];

            // Kullanıcıdan dizi değerlerini alma
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write($"dizi[{i}] Değerini Giriniz: ");
                dizi[i] = Convert.ToInt32(Console.ReadLine());
            }
            //--------------------------------------------------------------------
            int enYakinIndex = 1;

            for (int index = 2; index < dizi.Length; index++)
            {
                if (Math.Abs(dizi[0] - dizi[index]) < Math.Abs(dizi[0] - dizi[enYakinIndex]))
                {
                    enYakinIndex = index;
                }
            }

            Console.WriteLine("İlk Sayıya En Yakın Sayı = " + dizi[enYakinIndex]);
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}



/*
 
 
 using System;
namespace or220
{ class Program
{ public static void Main(string[] args) {
int sayi, a, e=1;
int []B={36,78,18,41,165,75,55,40,125,91};
for(a=2;a<B.Length;a++)
{
if(Math.Abs(B[0]-B[a])<Math.Abs(B[0]-B[e])) e=a;
}
Console.WriteLine("İlk Sayıya En Yakın Sayı = "+B[e]);
Console.Write("Press any key to continue . . . ");
Console.ReadKey(true); } } }
 */