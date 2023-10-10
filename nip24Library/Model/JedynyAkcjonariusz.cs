using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace NIP24.Model {

  /// <summary>
  /// Tylko dla spółki S.A. może wystąpić atrybut
  /// </summary>
  [DataContract]
  public class JedynyAkcjonariusz {
    /// <summary>
    /// Gets or Sets Nazwa
    /// </summary>
    [DataMember(Name="nazwa", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nazwa")]
    public string Nazwa { get; set; }

    /// <summary>
    /// Gets or Sets Krs
    /// </summary>
    [DataMember(Name="krs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "krs")]
    public DaneKrs Krs { get; set; }

    /// <summary>
    /// Gets or Sets CzyPosiadaCaloscAkcji
    /// </summary>
    [DataMember(Name="czyPosiadaCaloscAkcji", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "czyPosiadaCaloscAkcji")]
    public bool? CzyPosiadaCaloscAkcji { get; set; }

    /// <summary>
    /// Gets or Sets Identyfikator
    /// </summary>
    [DataMember(Name="identyfikator", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "identyfikator")]
    public IdentyfikatoryPodmiotu Identyfikator { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class JedynyAkcjonariusz {\n");
      sb.Append("  Nazwa: ").Append(Nazwa).Append("\n");
      sb.Append("  Krs: ").Append(Krs).Append("\n");
      sb.Append("  CzyPosiadaCaloscAkcji: ").Append(CzyPosiadaCaloscAkcji).Append("\n");
      sb.Append("  Identyfikator: ").Append(Identyfikator).Append("\n");
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
