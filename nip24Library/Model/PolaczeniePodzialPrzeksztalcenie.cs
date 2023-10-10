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
  public class PolaczeniePodzialPrzeksztalcenie {
    /// <summary>
    /// Gets or Sets OkreslenieOkolicznosci
    /// </summary>
    [DataMember(Name="okreslenieOkolicznosci", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "okreslenieOkolicznosci")]
    public string OkreslenieOkolicznosci { get; set; }

    /// <summary>
    /// Gets or Sets OpisPolaczeniaPodzialuPrzeksztalcenia
    /// </summary>
    [DataMember(Name="opisPolaczeniaPodzialuPrzeksztalcenia", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "opisPolaczeniaPodzialuPrzeksztalcenia")]
    public string OpisPolaczeniaPodzialuPrzeksztalcenia { get; set; }

    /// <summary>
    /// Gets or Sets PodmiotyPrzejmowane
    /// </summary>
    [DataMember(Name="podmiotyPrzejmowane", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "podmiotyPrzejmowane")]
    public List<Podmioty> PodmiotyPrzejmowane { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PolaczeniePodzialPrzeksztalcenie {\n");
      sb.Append("  OkreslenieOkolicznosci: ").Append(OkreslenieOkolicznosci).Append("\n");
      sb.Append("  OpisPolaczeniaPodzialuPrzeksztalcenia: ").Append(OpisPolaczeniaPodzialuPrzeksztalcenia).Append("\n");
      sb.Append("  PodmiotyPrzejmowane: ").Append(PodmiotyPrzejmowane).Append("\n");
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
