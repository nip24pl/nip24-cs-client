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
  public class WzmiankaOPodjeciuUchwalyOEmisjachObligacjiZamiennych {
    /// <summary>
    /// Gets or Sets DataPodjeciaUchwaly
    /// </summary>
    [DataMember(Name="dataPodjeciaUchwaly", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dataPodjeciaUchwaly")]
    public string DataPodjeciaUchwaly { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class WzmiankaOPodjeciuUchwalyOEmisjachObligacjiZamiennych {\n");
      sb.Append("  DataPodjeciaUchwaly: ").Append(DataPodjeciaUchwaly).Append("\n");
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
