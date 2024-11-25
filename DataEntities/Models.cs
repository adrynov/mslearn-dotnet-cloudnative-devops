using System.Text.Json.Serialization;

namespace DataEntities;

public class Fruit
{
  [JsonPropertyName("id")]
  public int Id { get; set; }

  [JsonPropertyName("name")]
  public string? Name { get; set; }

  [JsonPropertyName("description")]
  public string? Description { get; set; }

  [JsonPropertyName("price")]
  public decimal Price { get; set; }

  [JsonPropertyName("imageUrl")]
  public string? ImageUrl { get; set; }
}


[JsonSerializable(typeof(List<Fruit>))]
public sealed partial class FruitSerializerContext : JsonSerializerContext
{
}
