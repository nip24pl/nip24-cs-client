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
  public class Likwidacja {
    /// <summary>
    /// Gets or Sets OtwarcieLikwidacji
    /// </summary>
    [DataMember(Name="otwarcieLikwidacji", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "otwarcieLikwidacji")]
    public string OtwarcieLikwidacji { get; set; }

    /// <summary>
    /// Gets or Sets SposobReprezentacjiPodmiotuPrzezLikwidatorow
    /// </summary>
    [DataMember(Name="sposobReprezentacjiPodmiotuPrzezLikwidatorow", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sposobReprezentacjiPodmiotuPrzezLikwidatorow")]
    public string SposobReprezentacjiPodmiotuPrzezLikwidatorow { get; set; }

    /// <summary>
    /// Gets or Sets Likwidatorzy
    /// </summary>
    [DataMember(Name="likwidatorzy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "likwidatorzy")]
    public List<Osoba> Likwidatorzy { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Likwidacja {\n");
      sb.Append("  OtwarcieLikwidacji: ").Append(OtwarcieLikwidacji).Append("\n");
      sb.Append("  SposobReprezentacjiPodmiotuPrzezLikwidatorow: ").Append(SposobReprezentacjiPodmiotuPrzezLikwidatorow).Append("\n");
      sb.Append("  Likwidatorzy: ").Append(Likwidatorzy).Append("\n");
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
