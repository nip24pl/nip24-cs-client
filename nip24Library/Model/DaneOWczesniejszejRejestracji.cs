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
  public class DaneOWczesniejszejRejestracji {
    /// <summary>
    /// Gets or Sets NazwaPoprzedniegoRejestru
    /// </summary>
    [DataMember(Name="nazwaPoprzedniegoRejestru", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nazwaPoprzedniegoRejestru")]
    public string NazwaPoprzedniegoRejestru { get; set; }

    /// <summary>
    /// Gets or Sets NumerWPoprzednimRejestrze
    /// </summary>
    [DataMember(Name="numerWPoprzednimRejestrze", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "numerWPoprzednimRejestrze")]
    public string NumerWPoprzednimRejestrze { get; set; }

    /// <summary>
    /// Gets or Sets SadProwadzacyRejestr
    /// </summary>
    [DataMember(Name="sadProwadzacyRejestr", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sadProwadzacyRejestr")]
    public string SadProwadzacyRejestr { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DaneOWczesniejszejRejestracji {\n");
      sb.Append("  NazwaPoprzedniegoRejestru: ").Append(NazwaPoprzedniegoRejestru).Append("\n");
      sb.Append("  NumerWPoprzednimRejestrze: ").Append(NumerWPoprzednimRejestrze).Append("\n");
      sb.Append("  SadProwadzacyRejestr: ").Append(SadProwadzacyRejestr).Append("\n");
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
