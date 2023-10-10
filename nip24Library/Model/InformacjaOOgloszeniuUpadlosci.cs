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
  public class InformacjaOOgloszeniuUpadlosci {
    /// <summary>
    /// Gets or Sets OrganWydajacy
    /// </summary>
    [DataMember(Name="organWydajacy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "organWydajacy")]
    public string OrganWydajacy { get; set; }

    /// <summary>
    /// Gets or Sets Sygnatura
    /// </summary>
    [DataMember(Name="sygnatura", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sygnatura")]
    public string Sygnatura { get; set; }

    /// <summary>
    /// Gets or Sets Data
    /// </summary>
    [DataMember(Name="data", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "data")]
    public string Data { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class InformacjaOOgloszeniuUpadlosci {\n");
      sb.Append("  OrganWydajacy: ").Append(OrganWydajacy).Append("\n");
      sb.Append("  Sygnatura: ").Append(Sygnatura).Append("\n");
      sb.Append("  Data: ").Append(Data).Append("\n");
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
