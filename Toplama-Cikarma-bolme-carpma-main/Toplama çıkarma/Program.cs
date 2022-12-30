
using System;
float sayi1, sayi2, topla, cikar, carp, bol;
Console.Write("1. Sayiyi giriniz");
sayi1 = Convert.ToInt32(Console.ReadLine());
Console.Write("2. sayiyi giriniz");
sayi2 = Convert.ToInt32(Console.ReadLine());

topla = sayi1 + sayi2;
cikar = sayi1 - sayi2;
carp = sayi1 * sayi2;
bol = sayi1 / sayi2;



Console.WriteLine("Toplama Sonucu : " + topla  );
Console.WriteLine("Cikarma Sonucu : " + cikar );
Console.WriteLine("Carpma Sonucu : " + carp );
Console.WriteLine("Bolme Sonucu : " + bol );


