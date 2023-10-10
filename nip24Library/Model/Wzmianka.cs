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
  public class Wzmianka {
    /// <summary>
    /// Gets or Sets DataZlozenia
    /// </summary>
    [DataMember(Name="dataZlozenia", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dataZlozenia")]
    public string DataZlozenia { get; set; }

    /// <summary>
    /// Gets or Sets ZaOkresOdDo
    /// </summary>
    [DataMember(Name="zaOkresOdDo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "zaOkresOdDo")]
    public string ZaOkresOdDo { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Wzmianka {\n");
      sb.Append("  DataZlozenia: ").Append(DataZlozenia).Append("\n");
      sb.Append("  ZaOkresOdDo: ").Append(ZaOkresOdDo).Append("\n");
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
