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
  public class OrganNadzoru {
    /// <summary>
    /// Gets or Sets Nazwa
    /// </summary>
    [DataMember(Name="nazwa", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nazwa")]
    public string Nazwa { get; set; }

    /// <summary>
    /// Gets or Sets Sklad
    /// </summary>
    [DataMember(Name="sklad", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sklad")]
    public List<Sklad> Sklad { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OrganNadzoru {\n");
      sb.Append("  Nazwa: ").Append(Nazwa).Append("\n");
      sb.Append("  Sklad: ").Append(Sklad).Append("\n");
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
