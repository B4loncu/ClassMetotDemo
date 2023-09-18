using ClassMetotDemo;

internal class Program
{
     static void Main(string[] args)
    {
        Musteri musteri1 = new Musteri();
        musteri1.Id = "1000";
        musteri1.Name = "Ahmat Muhsin";
        musteri1.Description = "Arabic petrol rich!";
        musteri1.Age = 30;
        Musteri musteri2 = new Musteri();
        musteri2.Id = "1001";
        musteri2.Name = "Cenk Tosun";
        musteri2.Description = "Futball player";
        musteri2.Age = 27;
        Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };


        MusteriManager musteriManager = new MusteriManager();
        musteriManager.Add(musteri1);
        musteriManager.Remove(musteri2);
        musteriManager.Liste(musteri1);
        


    }
}