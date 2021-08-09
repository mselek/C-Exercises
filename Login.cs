using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Give us a username: ");
                string adSoyad = Console.ReadLine();

                if (adSoyad == "exit")
                    break;

                if (string.IsNullOrEmpty(adSoyad))
                {
                    Console.WriteLine("Username should not be empty");
                }
                else
                {
                    string[] kelimeler = adSoyad.Split(' ');
                    int kelimeSayisi = kelimeler.Length;

                    if (kelimeSayisi >= 4)
                    {
                        Console.WriteLine("Username reached the maximum limit");
                    }
                    else
                    {
                        string ad = string.Empty;
                        string ortaAd = string.Empty;
                        string soyad = string.Empty;
                        string username = string.Empty;
                        string tamAd = string.Empty;


                        switch (kelimeSayisi)
                        {
                            case 1:
                                ad = kelimeler[0];
                                break;

                            case 2:
                                ad = kelimeler[0];
                                soyad = kelimeler[1];
                                break;

                            case 3:
                                ad = kelimeler[0];
                                ortaAd = kelimeler[1];
                                soyad = kelimeler[2];
                                break;

                            default:
                                Console.WriteLine("Something goes wrong.");
                                break;
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

                        string message = $"Hi {username} {DateTime.Now.ToShortDateString()} welcome to the system...";
                        Console.WriteLine(message);
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
