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
  public class IdentyfikatoryPodmiotu {
    /// <summary>
    /// Gets or Sets Nip
    /// </summary>
    [DataMember(Name="nip", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nip")]
    public string Nip { get; set; }

    /// <summary>
    /// Gets or Sets Regon
    /// </summary>
    [DataMember(Name="regon", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "regon")]
    public string Regon { get; set; }

    /// <summary>
    /// Gets or Sets Krs
    /// </summary>
    [DataMember(Name="krs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "krs")]
    public string Krs { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IdentyfikatoryPodmiotu {\n");
      sb.Append("  Nip: ").Append(Nip).Append("\n");
      sb.Append("  Regon: ").Append(Regon).Append("\n");
      sb.Append("  Krs: ").Append(Krs).Append("\n");
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
