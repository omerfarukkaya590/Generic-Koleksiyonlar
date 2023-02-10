// See https://aka.ms/new-console-template for more information
//List<T> class syntax
//System.Collections.Generic altından gelir
//T-> object türündedir 

List<int> sayiListesi = new List<int>();

sayiListesi.Add(23);
sayiListesi.Add(10);
sayiListesi.Add(4);
sayiListesi.Add(5);
sayiListesi.Add(10);
sayiListesi.Add(14);
sayiListesi.Add(21);

List<string> renkListesi = new List<string>();

renkListesi.Add("Kırmızı");
renkListesi.Add("mavi");
renkListesi.Add("turuncu");
renkListesi.Add("sarı");
renkListesi.Add("kahverengi");
renkListesi.Add("yeşil");

//Count 
Console.WriteLine(renkListesi.Count);

foreach(var sayi in sayiListesi)
{
    Console.WriteLine(sayi);
}
foreach(var renk in renkListesi)
{
    Console.WriteLine(renk);
}
sayiListesi.ForEach(sayi => Console.WriteLine(sayi));

//Remove
sayiListesi.Remove(4);
renkListesi.Remove("yeşil");

//REmoveAt index
sayiListesi.RemoveAt(0);
renkListesi.RemoveAt(1);

//liste içi arama 
if(sayiListesi.Contains(10)){
    Console.Write("10 liste içerisinde bulundu");
}

//Eleman ile index'e erişme 
Console.Write(renkListesi.BinarySearch("sarı"));

//Diziyi list'e çevirme 
string[] hayvanlar = {"Kedi","Köpek","Kuş"};
List<string> hayvanListe = new List<string>(hayvanlar);

//Listeyi temizleme
hayvanListe.Clear();

//liste içerisinde nesne tutmak
List<Kullanicilar> kullaniciListesi = new List<Kullanicilar>();
Kullanicilar kullanici1 = new Kullanicilar();
kullanici1.Isim="Ayşe";
kullanici1.Soyisim="Yılmaz";
kullanici1.Yas=26;

Kullanicilar kullanici2 = new Kullanicilar();
kullanici2.Isim="fatma";
kullanici2.Soyisim="çlk";
kullanici2.Yas=26;
//2. yol
List<Kullanicilar> yeniListe = new List<Kullanicilar>();
yeniListe.Add(new Kullanicilar(){
    Isim="deniz",
    Soyisim="arda",
    Yas=5
});

public class Kullanicilar{
    string isim;
    string soyisim;

    int yas;

    public string Isim { get => isim; set => isim = value;}
    public string Soyisim { get => soyisim; set => soyisim = value;}
    public int Yas { get => yas; set => yas = value;}

}
