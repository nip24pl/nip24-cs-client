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
  public class ZawieszenieWznowienie {
    /// <summary>
    /// Gets or Sets DataZawieszenia
    /// </summary>
    [DataMember(Name="dataZawieszenia", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dataZawieszenia")]
    public string DataZawieszenia { get; set; }

    /// <summary>
    /// Gets or Sets DataWznowienia
    /// </summary>
    [DataMember(Name="dataWznowienia", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dataWznowienia")]
    public string DataWznowienia { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ZawieszenieWznowienie {\n");
      sb.Append("  DataZawieszenia: ").Append(DataZawieszenia).Append("\n");
      sb.Append("  DataWznowienia: ").Append(DataWznowienia).Append("\n");
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
