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
  public class CelDzialaniaOrganizacji {
    /// <summary>
    /// Gets or Sets CelDzialania
    /// </summary>
    [DataMember(Name="celDzialania", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "celDzialania")]
    public string CelDzialania { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CelDzialaniaOrganizacji {\n");
      sb.Append("  CelDzialania: ").Append(CelDzialania).Append("\n");
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
