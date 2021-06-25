using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen tam adınızı giriniz: ");
            string adSoyad = Console.ReadLine();
            

            if (string.IsNullOrEmpty(adSoyad))
            {
                Console.WriteLine("Adınızı boş giremezsiniz");
            }
            else
            {
                string[] kelimeler = adSoyad.Split(' ');
                int kelimeSayisi = kelimeler.Length;

                if (kelimeSayisi >= 4)
                {
                    Console.WriteLine("Kullanıcı adınız 3 kelimeden fazla olamaz.");
                }
                else
                {
                    string ad = string.Empty;
                    string ortaAd = string.Empty;
                    string soyad = string.Empty;
                    string username = string.Empty;
                    string tamAd = string.Empty;


                    if (kelimeSayisi == 1)
                    {
                        ad = kelimeler[0];
                    }
                    else if (kelimeSayisi == 2)
                    {
                        ad = kelimeler[0];
                        soyad = kelimeler[1];
                    }
                    else if (kelimeSayisi == 3)
                    {
                        ad = kelimeler[0];
                        ortaAd = kelimeler[1];
                        soyad = kelimeler[2];
                    }

                    ad = string.Concat(ad[0].ToString().ToUpper(), ad.Substring(1).ToLower());

                    if (!string.IsNullOrEmpty(ortaAd))
                    {
                        ortaAd = string.Concat(ortaAd[0].ToString().ToUpper(), ortaAd.Substring(1).ToLower());
                        tamAd = string.Concat(ad, "_", ortaAd);
                    }
                    else
                    {
                        tamAd = ad;
                    }

                    if (!string.IsNullOrEmpty(soyad))
                    {
                        soyad = soyad.ToUpper();
                        username = string.Join("_", tamAd, soyad);
                    }
                    else
                    {
                        username = tamAd;
                    }

                    

                    string message = $"Merhaba {username} {DateTime.Now.ToShortDateString()} hoşgeldiniz...";
                    Console.WriteLine(message);
                }                
            }
                 
            
           
            

            Console.ReadLine();
        }
    }

}
