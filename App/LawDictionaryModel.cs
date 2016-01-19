using System;

namespace LawDictionary
{
    [Serializable]
    public class LawDictionaryModel
    {
        public LawDictionaryModel()
        {
        }

        public LawDictionaryModel(string code, string document, string type, string year, string nGO, string description)
        {
            ID = Guid.NewGuid();
            Code = code;
            Document = document;
            Type = type;
            Year = year;
            NGO = nGO;
            Description = description;
        }

        public Guid ID { get; set; }
        public string Code { get; set; }
        public string Document { get; set; }
        public string Type { get; set; }
        public string Year { get; set; }
        public string NGO { get; set; }
        public string Description { get; set; }

        public int OrderType
        {
            get
            {
                if (Type.StartsWith("រដ្ឋធម្ម"))
                {
                    return -1;
                }
                if (Type.StartsWith("សន្ធិសញ្ញា"))
                {
                    return 0;
                }
                if (Type.StartsWith("ច្បាប់"))
                {
                    return 1;
                }
                if (Type.StartsWith("អនុក្រឹត្យ"))
                {
                    return 2;
                }
                if (Type.StartsWith("ប្រកាស"))
                {
                    return 3;
                }
                if (Type.StartsWith("សារា"))
                {
                    return 4;
                }
                
                if (Type.StartsWith("សេចក្តីជូនដំណឹង"))
                {
                    return 5;
                }
                if (Type.StartsWith("សេចក្តីណែនាំ"))
                {
                    return 6;
                }
                if (Type.StartsWith("សេចក្តីសម្រេច"))
                {
                    return 7;
                }
                return 8;
            }
        }
    }
}