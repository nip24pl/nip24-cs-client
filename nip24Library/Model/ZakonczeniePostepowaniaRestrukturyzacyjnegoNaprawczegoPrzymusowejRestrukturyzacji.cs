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
  public class ZakonczeniePostepowaniaRestrukturyzacyjnegoNaprawczegoPrzymusowejRestrukturyzacji {
    /// <summary>
    /// Gets or Sets Data
    /// </summary>
    [DataMember(Name="data", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "data")]
    public string Data { get; set; }

    /// <summary>
    /// Gets or Sets Opis
    /// </summary>
    [DataMember(Name="opis", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "opis")]
    public string Opis { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ZakonczeniePostepowaniaRestrukturyzacyjnegoNaprawczegoPrzymusowejRestrukturyzacji {\n");
      sb.Append("  Data: ").Append(Data).Append("\n");
      sb.Append("  Opis: ").Append(Opis).Append("\n");
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
