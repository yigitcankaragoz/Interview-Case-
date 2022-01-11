using System;
using System.IO;
using System.Net;

namespace yigitcankaragoz
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = { "Mercedes c200d","Gölbaşında Daire","Yeşilpınar Daire"};// Bu kısımda ilan isimleri için bir dizi oluşturdum.Dizi içerisine ilan isimlerini girdim.
            int[] price = {500000,500000,500000};//Bu kısımda ilan fiyatları için dizi oluşturdum ilan fiyatlarına dizi içerisini girdim.
            int length=price.Length;//Burda ilan fiyatları dizisinin uzunluğunu aldım ilan fiyatlarının ortalamasını alırken kullanmak için.
            int total = price[0]+price[1]+price[2];//Burda ilan fiyatlarının ortalamasını almak için ilan fiyatlarını toplayıp total değişkenine atıyorum.
            int ort = total / length;//Bu kısımda ilan fiyatlarının ortalamsını alıyorum

            //Aşağıdaki kısımda ilan adlarını ve ilan fiyatlarını listeliyorum.
            Console.WriteLine("İlan Adı : " +name[0]+"İlan Fiyat : "+price[0]);
            Console.WriteLine("İlan Adı : " +name[1]+"İlan Fiyat : "+price[1]);
            Console.WriteLine("İlan Adı : " +name[2]+"İlan Fiyat : "+price[2]);
            Console.WriteLine("Oratalama"+ort);//Bu kısımda fiyat ortalamasını ekrana yazdırıyorum.

            //Aşağıdaki kısımda listelenen verileri data.txt dosyasına kayıt ediyorum.
            string fname = @"C:\Users\asus\Desktop\data.txt";
            string text = name[0]+"Fiyat" + price[0] +"  " + name[1] + "Fiyat" + price[1]  + "  " + name[2] + "Fiyat" + price[2];
            FileStream filesave = new FileStream(fname, FileMode.OpenOrCreate, FileAccess.Write);
            filesave.Close();
            File.AppendAllText(fname, Environment.NewLine + text);
        }
    }
}
