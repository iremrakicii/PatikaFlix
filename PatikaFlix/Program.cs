using PatikaFlix;
class Program
{


    static void Main(string[] args)
    {

        List<Series> series = new List<Series>();
        string cevap;
        Console.WriteLine("Kaç dizi eklemek istiyorsunuz?");
        int diziSayisi = Convert.ToInt32(Console.ReadLine());


        do
        {
            Console.WriteLine("Dizi için bilgileri giriniz:");

            Console.Write("Dizi Adı: ");
            string _seriesName = Console.ReadLine();

            Console.Write("Yapım Yılı: ");
            int _publicYear = int.Parse(Console.ReadLine());

            Console.Write("Tür: ");
            string _seriesType = Console.ReadLine();

            Console.Write("Yayınlanmaya Başlama Yılı: ");
            int _releaseYear = int.Parse(Console.ReadLine());

            Console.Write("Yönetmen: ");
            string _director = Console.ReadLine();

            Console.Write("Platform: ");
            string _releasePlatform = Console.ReadLine();

            series.Add(new Series(_seriesName, _publicYear, _seriesType, _releaseYear, _director, _releasePlatform));

            Console.WriteLine("Yeni bir dizi eklemek ister misiniz? evet/hayır");
            cevap = Console.ReadLine().ToLower();

        } while (cevap == "evet");

        Console.WriteLine("\nEklediğiniz diziler:");
        foreach (var item in series)
        {
            Console.WriteLine(item);
        }

        List<ComedySeries._ComedySeries> comedySeriesList = series
            .Where(series => series.SeriesType.ToLower() == "komedi")
            .Select(series => new ComedySeries._ComedySeries(series.SeriesName, series.SeriesType, series.Director))
            .OrderBy(series => series.ArraysName)
            .ThenBy(series => series.Director)
            .ToList();

        Console.WriteLine("\nKomedi Dizileri:");
        foreach (var comedy in comedySeriesList)
        {
            Console.WriteLine(comedy);
        }


    }

}