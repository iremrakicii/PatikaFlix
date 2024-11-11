namespace PatikaFlix
{


    public class Series
    {
        public string SeriesName { get; set; }
        public int PublicYear { get; set; }
        public string SeriesType { get; set; }
        public int ReleaseYear { get; set; }
        public string Director { get; set; }
        public string ReleasePlatform { get; set; }

        public Series(string _seriesName, int _publicYear, string _seriesType, int _releaseYear, string _director, string _releasePlatform)
        {
            SeriesName = _seriesName;
            PublicYear = _publicYear;
            SeriesType = _seriesType;
            ReleaseYear = _releaseYear;
            Director = _director;
            ReleasePlatform = _releasePlatform;

        }
        public override string ToString()
        {
            return $"Dizi Adı: {SeriesName}, Yapım Yılı: {PublicYear}, Tür: {SeriesType}, Yayınlanmaya Başlama Yılı: {ReleaseYear}, Yönetmen: {Director}, Platform: {ReleasePlatform}";
        }
    }

}
