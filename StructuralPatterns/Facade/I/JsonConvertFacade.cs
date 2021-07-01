using Newtonsoft.Json;

namespace WPCSharp.StructuralPatterns.Facade.I
{
    public static class JsonConvertFacade
    {
        public static JsonSerializerSettings Settings { get; } = new JsonSerializerSettings()
        {
            Formatting = Formatting.Indented,
            NullValueHandling = NullValueHandling.Ignore,
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
            DateFormatString = "yy MMM d"
        };

        public static string Serialize<T>(T @object)
        {
            return JsonConvert.SerializeObject(@object, Settings);
        }

        public static T Deserialize<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json, Settings);
        }
    }
}
