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
  public class NazwiskoOsoby {
    /// <summary>
    /// Gets or Sets NazwiskoICzlon
    /// </summary>
    [DataMember(Name="nazwiskoICzlon", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nazwiskoICzlon")]
    public string NazwiskoICzlon { get; set; }

    /// <summary>
    /// Gets or Sets NazwiskoIICzlon
    /// </summary>
    [DataMember(Name="nazwiskoIICzlon", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nazwiskoIICzlon")]
    public string NazwiskoIICzlon { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class NazwiskoOsoby {\n");
      sb.Append("  NazwiskoICzlon: ").Append(NazwiskoICzlon).Append("\n");
      sb.Append("  NazwiskoIICzlon: ").Append(NazwiskoIICzlon).Append("\n");
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
