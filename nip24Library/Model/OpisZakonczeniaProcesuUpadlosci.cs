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
  public class OpisZakonczeniaProcesuUpadlosci {
    /// <summary>
    /// Gets or Sets OpisSposobuZakonczeniaPostepowania
    /// </summary>
    [DataMember(Name="opisSposobuZakonczeniaPostepowania", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "opisSposobuZakonczeniaPostepowania")]
    public string OpisSposobuZakonczeniaPostepowania { get; set; }

    /// <summary>
    /// Gets or Sets DataZakonczeniaPostepowania
    /// </summary>
    [DataMember(Name="dataZakonczeniaPostepowania", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dataZakonczeniaPostepowania")]
    public string DataZakonczeniaPostepowania { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OpisZakonczeniaProcesuUpadlosci {\n");
      sb.Append("  OpisSposobuZakonczeniaPostepowania: ").Append(OpisSposobuZakonczeniaPostepowania).Append("\n");
      sb.Append("  DataZakonczeniaPostepowania: ").Append(DataZakonczeniaPostepowania).Append("\n");
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
