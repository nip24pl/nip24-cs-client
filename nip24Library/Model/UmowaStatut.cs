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
  public class UmowaStatut {
    /// <summary>
    /// Gets or Sets InformacjaOZawarciuZmianieUmowyStatutu
    /// </summary>
    [DataMember(Name="informacjaOZawarciuZmianieUmowyStatutu", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "informacjaOZawarciuZmianieUmowyStatutu")]
    public List<InformacjaOZawarciuZmianieUmowyStatutu> InformacjaOZawarciuZmianieUmowyStatutu { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UmowaStatut {\n");
      sb.Append("  InformacjaOZawarciuZmianieUmowyStatutu: ").Append(InformacjaOZawarciuZmianieUmowyStatutu).Append("\n");
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
