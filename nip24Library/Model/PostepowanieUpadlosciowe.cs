using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace NIP24.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class PostepowanieUpadlosciowe {
    /// <summary>
    /// Gets or Sets SposobProwadzeniaPostepowania
    /// </summary>
    [DataMember(Name="sposobProwadzeniaPostepowania", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sposobProwadzeniaPostepowania")]
    public string SposobProwadzeniaPostepowania { get; set; }

    /// <summary>
    /// Gets or Sets InformacjaOUchyleniuUkladu
    /// </summary>
    [DataMember(Name="informacjaOUchyleniuUkladu", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "informacjaOUchyleniuUkladu")]
    public string InformacjaOUchyleniuUkladu { get; set; }

    /// <summary>
    /// Gets or Sets InformacjaOOgloszeniuUpadlosci
    /// </summary>
    [DataMember(Name="informacjaOOgloszeniuUpadlosci", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "informacjaOOgloszeniuUpadlosci")]
    public InformacjaOOgloszeniuUpadlosci InformacjaOOgloszeniuUpadlosci { get; set; }

    /// <summary>
    /// Gets or Sets OpisZakonczeniaProcesuUpadlosci
    /// </summary>
    [DataMember(Name="opisZakonczeniaProcesuUpadlosci", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "opisZakonczeniaProcesuUpadlosci")]
    public OpisZakonczeniaProcesuUpadlosci OpisZakonczeniaProcesuUpadlosci { get; set; }

    /// <summary>
    /// Gets or Sets DaneSyndyka
    /// </summary>
    [DataMember(Name="daneSyndyka", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "daneSyndyka")]
    public List<DaneSyndyka> DaneSyndyka { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PostepowanieUpadlosciowe {\n");
      sb.Append("  SposobProwadzeniaPostepowania: ").Append(SposobProwadzeniaPostepowania).Append("\n");
      sb.Append("  InformacjaOUchyleniuUkladu: ").Append(InformacjaOUchyleniuUkladu).Append("\n");
      sb.Append("  InformacjaOOgloszeniuUpadlosci: ").Append(InformacjaOOgloszeniuUpadlosci).Append("\n");
      sb.Append("  OpisZakonczeniaProcesuUpadlosci: ").Append(OpisZakonczeniaProcesuUpadlosci).Append("\n");
      sb.Append("  DaneSyndyka: ").Append(DaneSyndyka).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
