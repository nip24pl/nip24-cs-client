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
  public class CzescKapitaluWplaconegoPokrytego {
    /// <summary>
    /// Gets or Sets Wartosc
    /// </summary>
    [DataMember(Name="wartosc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "wartosc")]
    public string Wartosc { get; set; }

    /// <summary>
    /// Gets or Sets Waluta
    /// </summary>
    [DataMember(Name="waluta", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "waluta")]
    public string Waluta { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CzescKapitaluWplaconegoPokrytego {\n");
      sb.Append("  Wartosc: ").Append(Wartosc).Append("\n");
      sb.Append("  Waluta: ").Append(Waluta).Append("\n");
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
