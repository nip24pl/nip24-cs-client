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
  public class Prokurenci {
    /// <summary>
    /// Gets or Sets RodzajProkury
    /// </summary>
    [DataMember(Name="rodzajProkury", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rodzajProkury")]
    public string RodzajProkury { get; set; }

    /// <summary>
    /// Gets or Sets Osoba
    /// </summary>
    [DataMember(Name="osoba", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "osoba")]
    public Osoba Osoba { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Prokurenci {\n");
      sb.Append("  RodzajProkury: ").Append(RodzajProkury).Append("\n");
      sb.Append("  Osoba: ").Append(Osoba).Append("\n");
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
