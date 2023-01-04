// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Methodlar instance= new Methodlar();

int a=10; int b=20;
int result;

instance.Topla(a,b,out result);
Console.WriteLine(result);

int ifade=999;
instance.EkranaYazdir(ifade);

class Methodlar{

    public void Topla (int deger1, int deger2, out int toplam){

        toplam= deger1 + deger2;
    }

    public void EkranaYazdir (string veri){

        Console.WriteLine(veri);
    }

    public void EkranaYazdir (int veri){

        Console.WriteLine(veri);
    }


}


