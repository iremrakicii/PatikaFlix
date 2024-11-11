namespace PatikaFlix
{
    public class ComedySeries
    {
        public class _ComedySeries
        {
            public string ArraysName { get; set; }
            public string ArrayType { get; set; }
            public string Director { get; set; }

            public _ComedySeries(string _arraysName, string _arrayType, string _director)
            {
                ArraysName = _arraysName;
                ArrayType = _arrayType;
                Director = _director;
            }

            public override string ToString()
            {
                return $"Dizi Adı: {ArraysName}, Tür: {ArrayType}, Yönetmen: {Director}";
            }
        }
    }
}
