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
  public class Dzialalnosci {
    /// <summary>
    /// Gets or Sets Opis
    /// </summary>
    [DataMember(Name="opis", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "opis")]
    public string Opis { get; set; }

    /// <summary>
    /// Gets or Sets KodDzial
    /// </summary>
    [DataMember(Name="kodDzial", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "kodDzial")]
    public string KodDzial { get; set; }

    /// <summary>
    /// Gets or Sets KodKlasa
    /// </summary>
    [DataMember(Name="kodKlasa", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "kodKlasa")]
    public string KodKlasa { get; set; }

    /// <summary>
    /// Gets or Sets KodPodklasa
    /// </summary>
    [DataMember(Name="kodPodklasa", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "kodPodklasa")]
    public string KodPodklasa { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Dzialalnosci {\n");
      sb.Append("  Opis: ").Append(Opis).Append("\n");
      sb.Append("  KodDzial: ").Append(KodDzial).Append("\n");
      sb.Append("  KodKlasa: ").Append(KodKlasa).Append("\n");
      sb.Append("  KodPodklasa: ").Append(KodPodklasa).Append("\n");
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
