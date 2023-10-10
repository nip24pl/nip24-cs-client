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
  public class DaneSyndyka {
    /// <summary>
    /// Gets or Sets Nazwisko
    /// </summary>
    [DataMember(Name="nazwisko", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nazwisko")]
    public NazwiskoOsoby Nazwisko { get; set; }

    /// <summary>
    /// Gets or Sets Imiona
    /// </summary>
    [DataMember(Name="imiona", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "imiona")]
    public ImionaOsoby Imiona { get; set; }

    /// <summary>
    /// Gets or Sets Identyfikator
    /// </summary>
    [DataMember(Name="identyfikator", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "identyfikator")]
    public IdentyfikatorOsoby Identyfikator { get; set; }

    /// <summary>
    /// Gets or Sets Podmiot
    /// </summary>
    [DataMember(Name="podmiot", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "podmiot")]
    public Podmioty Podmiot { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DaneSyndyka {\n");
      sb.Append("  Nazwisko: ").Append(Nazwisko).Append("\n");
      sb.Append("  Imiona: ").Append(Imiona).Append("\n");
      sb.Append("  Identyfikator: ").Append(Identyfikator).Append("\n");
      sb.Append("  Podmiot: ").Append(Podmiot).Append("\n");
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
