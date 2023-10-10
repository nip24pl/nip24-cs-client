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
  public class RozwiazanieUniewaznienie {
    /// <summary>
    /// Gets or Sets OkreslenieOkolicznosci
    /// </summary>
    [DataMember(Name="okreslenieOkolicznosci", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "okreslenieOkolicznosci")]
    public string OkreslenieOkolicznosci { get; set; }

    /// <summary>
    /// Gets or Sets InformacjaORozwiazaniuUniewaznieniu
    /// </summary>
    [DataMember(Name="informacjaORozwiazaniuUniewaznieniu", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "informacjaORozwiazaniuUniewaznieniu")]
    public string InformacjaORozwiazaniuUniewaznieniu { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RozwiazanieUniewaznienie {\n");
      sb.Append("  OkreslenieOkolicznosci: ").Append(OkreslenieOkolicznosci).Append("\n");
      sb.Append("  InformacjaORozwiazaniuUniewaznieniu: ").Append(InformacjaORozwiazaniuUniewaznieniu).Append("\n");
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
