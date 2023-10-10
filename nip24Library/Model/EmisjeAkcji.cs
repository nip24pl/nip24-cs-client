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
  public class EmisjeAkcji {
    /// <summary>
    /// Gets or Sets NazwaSeriiAkcji
    /// </summary>
    [DataMember(Name="nazwaSeriiAkcji", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nazwaSeriiAkcji")]
    public string NazwaSeriiAkcji { get; set; }

    /// <summary>
    /// Gets or Sets LiczbaAkcjiWSerii
    /// </summary>
    [DataMember(Name="liczbaAkcjiWSerii", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "liczbaAkcjiWSerii")]
    public string LiczbaAkcjiWSerii { get; set; }

    /// <summary>
    /// Gets or Sets CzyAkcjeUprzywilejowaneLiczbaAkcjiRodzajUprzywilejowania
    /// </summary>
    [DataMember(Name="czyAkcjeUprzywilejowaneLiczbaAkcjiRodzajUprzywilejowania", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "czyAkcjeUprzywilejowaneLiczbaAkcjiRodzajUprzywilejowania")]
    public string CzyAkcjeUprzywilejowaneLiczbaAkcjiRodzajUprzywilejowania { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class EmisjeAkcji {\n");
      sb.Append("  NazwaSeriiAkcji: ").Append(NazwaSeriiAkcji).Append("\n");
      sb.Append("  LiczbaAkcjiWSerii: ").Append(LiczbaAkcjiWSerii).Append("\n");
      sb.Append("  CzyAkcjeUprzywilejowaneLiczbaAkcjiRodzajUprzywilejowania: ").Append(CzyAkcjeUprzywilejowaneLiczbaAkcjiRodzajUprzywilejowania).Append("\n");
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
