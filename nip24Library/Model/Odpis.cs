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
  public class Odpis {
    /// <summary>
    /// Gets or Sets Rodzaj
    /// </summary>
    [DataMember(Name="rodzaj", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rodzaj")]
    public RodzajOdpisu Rodzaj { get; set; }

    /// <summary>
    /// Gets or Sets NaglowekA
    /// </summary>
    [DataMember(Name="naglowekA", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "naglowekA")]
    public NaglowekA NaglowekA { get; set; }

    /// <summary>
    /// Gets or Sets Dane
    /// </summary>
    [DataMember(Name="dane", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dane")]
    public Dane Dane { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Odpis {\n");
      sb.Append("  Rodzaj: ").Append(Rodzaj).Append("\n");
      sb.Append("  NaglowekA: ").Append(NaglowekA).Append("\n");
      sb.Append("  Dane: ").Append(Dane).Append("\n");
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
