using System.Reflection.Metadata.Ecma335;

using System.Collections.Generic;
using System.Text.Json.Serialization;

public class FeatureCollection
{
    [JsonPropertyName("type")]
    public string Type { get; set; } // "FeatureCollection"

    [JsonPropertyName("metadata")]
    public Metadata Metadata { get; set; }

    [JsonPropertyName("bbox")]
    public List<double> Bbox { get; set; }

    [JsonPropertyName("features")]
    public List<Feature> Features { get; set; }
}

public class Metadata
{
    [JsonPropertyName("generated")]
    public long? Generated { get; set; }

    [JsonPropertyName("url")]
    public string Url { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("api")]
    public string Api { get; set; }

    [JsonPropertyName("count")]
    public int? Count { get; set; }

    [JsonPropertyName("status")]
    public int? Status { get; set; }
}

public class Feature
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("properties")]
    public Properties Properties { get; set; }

    [JsonPropertyName("geometry")]
    public Geometry Geometry { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }
}

public class Properties
{
    [JsonPropertyName("mag")]
    public decimal? Mag { get; set; }

    [JsonPropertyName("place")]
    public string Place { get; set; }

    [JsonPropertyName("time")]
    public long? Time { get; set; }

    [JsonPropertyName("updated")]
    public long? Updated { get; set; }

    [JsonPropertyName("tz")]
    public int? TimeZone { get; set; }

    [JsonPropertyName("url")]
    public string Url { get; set; }

    [JsonPropertyName("detail")]
    public string Detail { get; set; }

    [JsonPropertyName("felt")]
    public int? Felt { get; set; }

    [JsonPropertyName("cdi")]
    public decimal? Cdi { get; set; }

    [JsonPropertyName("mmi")]
    public decimal? Mmi { get; set; }

    [JsonPropertyName("alert")]
    public string Alert { get; set; }

    [JsonPropertyName("status")]
    public string Status { get; set; }

    [JsonPropertyName("tsunami")]
    public int? Tsunami { get; set; }

    [JsonPropertyName("sig")]
    public int? Sig { get; set; }

    [JsonPropertyName("net")]
    public string Net { get; set; }

    [JsonPropertyName("code")]
    public string Code { get; set; }

    [JsonPropertyName("ids")]
    public string Ids { get; set; }

    [JsonPropertyName("sources")]
    public string Sources { get; set; }

    [JsonPropertyName("types")]
    public string Types { get; set; }

    [JsonPropertyName("nst")]
    public int? Nst { get; set; }

    [JsonPropertyName("dmin")]
    public decimal? Dmin { get; set; }

    [JsonPropertyName("rms")]
    public decimal? Rms { get; set; }

    [JsonPropertyName("gap")]
    public decimal? Gap { get; set; }

    [JsonPropertyName("magtype")]
    public string MagType { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }
}

public class Geometry
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("coordinates")]
    public List<double> Coordinates { get; set; }
}
