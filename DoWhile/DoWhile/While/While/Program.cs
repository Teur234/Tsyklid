//Console.WriteLine("Joonistan sulle kolmnurga");
//int kolmnurgaSuurus = int.Parse(Console.ReadLine());

//int i = 1;
//while(i <= kolmnurgaSuurus)
//{
//    Console.WriteLine();
//    int j = 1;
//    while (j <= i)
//    {
//        Console.Write("_");
//        j++;
//    }
//    i++;
//}

Console.WriteLine("Tere tulemast MobiFix parandusautomaati! Kuidas saan aidata");
Console.WriteLine("0 - headaega\n1 - tahan telefoni parandada");
int kasutajaValik = int.Parse(Console.ReadLine());
while (kasutajaValik > 0 && kasutajaValik > 1)
{
    Console.WriteLine("Palun tee oma valik kirjutades vastav arv");
    kasutajaValik = int.Parse(Console.ReadLine());
}
if (kasutajaValik == 0)
{
    Console.WriteLine("Headaega, tulge jälle.");
}
else
{
    Console.WriteLine("Palun sisesta oma telefoni mudel, mida parandada soovid");
    Console.WriteLine("1-Iphone\n2-Xiaomi\n3-Huawei\n4-Samsung");
    Console.WriteLine("Palun tee oma valik, kirjutades vastav arv");
    int kasutajatelefon = int.Parse(Console.ReadLine());
    while(kasutajatelefon < 1 && kasutajatelefon > 4)
    {
        kasutajatelefon = int.Parse(Console.ReadLine());
        Console.WriteLine("Palun tee oma valik, kirjutades vastav arv");
        switch (kasutajatelefon)
        {
            case 1:
                Console.WriteLine("Aitäh, oma Iphone saad tagasi 1 nädala pärast");
                break;
            case 2:
                Console.WriteLine("Aitäh sinu Xiaomi on valmis 1 kuu pärats");
                break;
            case 3:
                Console.WriteLine("Kahjuks me Huaweid ei teninda");
                break;
            case 4:
                Console.WriteLine("Sinu samsung saab valmis 2 päeva pärast");
                break;
            default:
                break;
        
        
        }
    }
}