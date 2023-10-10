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
  public class IdentyfikatorOsoby {
    /// <summary>
    /// Gets or Sets Pesel
    /// </summary>
    [DataMember(Name="pesel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pesel")]
    public string Pesel { get; set; }

    /// <summary>
    /// Gets or Sets NumerPaszportu
    /// </summary>
    [DataMember(Name="numerPaszportu", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "numerPaszportu")]
    public string NumerPaszportu { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IdentyfikatorOsoby {\n");
      sb.Append("  Pesel: ").Append(Pesel).Append("\n");
      sb.Append("  NumerPaszportu: ").Append(NumerPaszportu).Append("\n");
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
