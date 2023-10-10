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
  public class PrzedmiotDzialalnosciOPP {
    /// <summary>
    /// Gets or Sets NieodplatnyPkd
    /// </summary>
    [DataMember(Name="nieodplatnyPkd", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nieodplatnyPkd")]
    public List<Dzialalnosci> NieodplatnyPkd { get; set; }

    /// <summary>
    /// Gets or Sets OdplatnyPkd
    /// </summary>
    [DataMember(Name="odplatnyPkd", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "odplatnyPkd")]
    public List<Dzialalnosci> OdplatnyPkd { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PrzedmiotDzialalnosciOPP {\n");
      sb.Append("  NieodplatnyPkd: ").Append(NieodplatnyPkd).Append("\n");
      sb.Append("  OdplatnyPkd: ").Append(OdplatnyPkd).Append("\n");
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
