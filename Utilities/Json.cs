
using CornerStoneNUnit.JsonData;
using Newtonsoft.Json;

namespace CornerStoneNUnit.Utilities
{
    public static class Json
    {
        public static Data GetData()
        {
            var Json = File.ReadAllText("JsonData/JsonReader.json");
            return JsonConvert.DeserializeObject<Data>(Json);
        }

    }
}
