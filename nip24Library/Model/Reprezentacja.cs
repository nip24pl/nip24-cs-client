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
  public class Reprezentacja {
    /// <summary>
    /// Gets or Sets NazwaOrganu
    /// </summary>
    [DataMember(Name="nazwaOrganu", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nazwaOrganu")]
    public string NazwaOrganu { get; set; }

    /// <summary>
    /// Gets or Sets SposobReprezentacji
    /// </summary>
    [DataMember(Name="sposobReprezentacji", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sposobReprezentacji")]
    public string SposobReprezentacji { get; set; }

    /// <summary>
    /// Gets or Sets Sklad
    /// </summary>
    [DataMember(Name="sklad", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sklad")]
    public List<Sklad> Sklad { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Reprezentacja {\n");
      sb.Append("  NazwaOrganu: ").Append(NazwaOrganu).Append("\n");
      sb.Append("  SposobReprezentacji: ").Append(SposobReprezentacji).Append("\n");
      sb.Append("  Sklad: ").Append(Sklad).Append("\n");
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
