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
  public class Siedziba {
    /// <summary>
    /// Gets or Sets Kraj
    /// </summary>
    [DataMember(Name="kraj", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "kraj")]
    public string Kraj { get; set; }

    /// <summary>
    /// Gets or Sets Wojewodztwo
    /// </summary>
    [DataMember(Name="wojewodztwo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "wojewodztwo")]
    public string Wojewodztwo { get; set; }

    /// <summary>
    /// Gets or Sets Powiat
    /// </summary>
    [DataMember(Name="powiat", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "powiat")]
    public string Powiat { get; set; }

    /// <summary>
    /// Gets or Sets Gmina
    /// </summary>
    [DataMember(Name="gmina", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "gmina")]
    public string Gmina { get; set; }

    /// <summary>
    /// Gets or Sets Miejscowosc
    /// </summary>
    [DataMember(Name="miejscowosc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "miejscowosc")]
    public string Miejscowosc { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Siedziba {\n");
      sb.Append("  Kraj: ").Append(Kraj).Append("\n");
      sb.Append("  Wojewodztwo: ").Append(Wojewodztwo).Append("\n");
      sb.Append("  Powiat: ").Append(Powiat).Append("\n");
      sb.Append("  Gmina: ").Append(Gmina).Append("\n");
      sb.Append("  Miejscowosc: ").Append(Miejscowosc).Append("\n");
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
