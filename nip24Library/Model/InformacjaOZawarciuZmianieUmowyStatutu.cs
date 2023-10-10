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
  public class InformacjaOZawarciuZmianieUmowyStatutu {
    /// <summary>
    /// Gets or Sets ZawarcieZmianaUmowyStatutu
    /// </summary>
    [DataMember(Name="zawarcieZmianaUmowyStatutu", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "zawarcieZmianaUmowyStatutu")]
    public string ZawarcieZmianaUmowyStatutu { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class InformacjaOZawarciuZmianieUmowyStatutu {\n");
      sb.Append("  ZawarcieZmianaUmowyStatutu: ").Append(ZawarcieZmianaUmowyStatutu).Append("\n");
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
