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
  public class Dzial2 {
    /// <summary>
    /// Gets or Sets OrganNadzoru
    /// </summary>
    [DataMember(Name="organNadzoru", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "organNadzoru")]
    public List<OrganNadzoru> OrganNadzoru { get; set; }

    /// <summary>
    /// Gets or Sets Reprezentacja
    /// </summary>
    [DataMember(Name="reprezentacja", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reprezentacja")]
    public Reprezentacja Reprezentacja { get; set; }

    /// <summary>
    /// Gets or Sets Prokurenci
    /// </summary>
    [DataMember(Name="prokurenci", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "prokurenci")]
    public List<Prokurenci> Prokurenci { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Dzial2 {\n");
      sb.Append("  OrganNadzoru: ").Append(OrganNadzoru).Append("\n");
      sb.Append("  Reprezentacja: ").Append(Reprezentacja).Append("\n");
      sb.Append("  Prokurenci: ").Append(Prokurenci).Append("\n");
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
