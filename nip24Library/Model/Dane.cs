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
  public class Dane {
    /// <summary>
    /// Gets or Sets Dzial1
    /// </summary>
    [DataMember(Name="dzial1", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dzial1")]
    public Dzial1 Dzial1 { get; set; }

    /// <summary>
    /// Gets or Sets Dzial2
    /// </summary>
    [DataMember(Name="dzial2", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dzial2")]
    public Dzial2 Dzial2 { get; set; }

    /// <summary>
    /// Gets or Sets Dzial3
    /// </summary>
    [DataMember(Name="dzial3", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dzial3")]
    public Dzial3 Dzial3 { get; set; }

    /// <summary>
    /// Gets or Sets Dzial4
    /// </summary>
    [DataMember(Name="dzial4", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dzial4")]
    public Dzial4 Dzial4 { get; set; }

    /// <summary>
    /// Gets or Sets Dzial5
    /// </summary>
    [DataMember(Name="dzial5", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dzial5")]
    public Dzial5 Dzial5 { get; set; }

    /// <summary>
    /// Gets or Sets Dzial6
    /// </summary>
    [DataMember(Name="dzial6", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dzial6")]
    public Dzial6 Dzial6 { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Dane {\n");
      sb.Append("  Dzial1: ").Append(Dzial1).Append("\n");
      sb.Append("  Dzial2: ").Append(Dzial2).Append("\n");
      sb.Append("  Dzial3: ").Append(Dzial3).Append("\n");
      sb.Append("  Dzial4: ").Append(Dzial4).Append("\n");
      sb.Append("  Dzial5: ").Append(Dzial5).Append("\n");
      sb.Append("  Dzial6: ").Append(Dzial6).Append("\n");
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
