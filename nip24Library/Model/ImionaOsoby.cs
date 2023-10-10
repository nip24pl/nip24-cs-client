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
  public class ImionaOsoby {
    /// <summary>
    /// Gets or Sets Imie
    /// </summary>
    [DataMember(Name="imie", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "imie")]
    public string Imie { get; set; }

    /// <summary>
    /// Gets or Sets ImieDrugie
    /// </summary>
    [DataMember(Name="imieDrugie", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "imieDrugie")]
    public string ImieDrugie { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ImionaOsoby {\n");
      sb.Append("  Imie: ").Append(Imie).Append("\n");
      sb.Append("  ImieDrugie: ").Append(ImieDrugie).Append("\n");
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
