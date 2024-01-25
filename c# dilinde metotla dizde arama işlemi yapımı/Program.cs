using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__dilinde_metotla_dizde_arama_işlemi_yapımı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("dizide değer arma işlemleri");
            int[] d = new int[15];
            Değerata(d, 1, 20);
            DiziYazdır(d);
            Console.WriteLine("\naradığnız sayıyı giriniz");
            int aranan = Convert.ToInt32(Console.ReadLine());
            int sonuc = Elamanara(d, aranan);
            if (sonuc == -1)
            {
                Console.WriteLine($"{aranan} elamanı dizide bulunmadı");
            }
            else
            {
                Console.WriteLine($"{aranan} elamanı dizini {sonuc}indesindedir.");
            }
            Console.ReadLine();

        }
        static void Değerata(int[] dizi, int bas, int son)
        {
            Random rnd = new Random();
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rnd.Next(bas, son);
            }

        }
        static void DiziYazdır(int[] dizi)
        {
            Console.Write("[");
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write(dizi[i] + " ");
            }
            Console.Write("]");
        }
        static int Elamanara(int[] d, int ArananElaman)
        {
            int indis = -1;
            for (int i = 0; i < d.Length; i++)
            {
                if (d[i] == ArananElaman)
                {
                    indis = i;
                    break;

                }
            }
            return indis;
        }
    }
    }

