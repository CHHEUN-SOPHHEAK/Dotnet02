using System.Text.Json.Serialization;

namespace Dotnet02.Models
{
      [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ApiClass
    {
        Admin=1,
        user=2,
        Client=3

    }
}