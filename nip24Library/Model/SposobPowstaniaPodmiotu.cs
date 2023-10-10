using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace NIP24.Model {

  /// <summary>
  /// Tylko dla spółki S.A. występuje atrybut
  /// </summary>
  [DataContract]
  public class SposobPowstaniaPodmiotu {
    /// <summary>
    /// Gets or Sets OkolicznosciPowstania
    /// </summary>
    [DataMember(Name="okolicznosciPowstania", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "okolicznosciPowstania")]
    public string OkolicznosciPowstania { get; set; }

    /// <summary>
    /// Gets or Sets OpisSposobuPowstaniaInformacjaOUchwale
    /// </summary>
    [DataMember(Name="opisSposobuPowstaniaInformacjaOUchwale", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "opisSposobuPowstaniaInformacjaOUchwale")]
    public string OpisSposobuPowstaniaInformacjaOUchwale { get; set; }

    /// <summary>
    /// Gets or Sets NrDataDecyzjiPrezesaUOKiK
    /// </summary>
    [DataMember(Name="nrDataDecyzjiPrezesaUOKiK", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nrDataDecyzjiPrezesaUOKiK")]
    public string NrDataDecyzjiPrezesaUOKiK { get; set; }

    /// <summary>
    /// Gets or Sets Podmioty
    /// </summary>
    [DataMember(Name="podmioty", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "podmioty")]
    public List<Podmioty> Podmioty { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SposobPowstaniaPodmiotu {\n");
      sb.Append("  OkolicznosciPowstania: ").Append(OkolicznosciPowstania).Append("\n");
      sb.Append("  OpisSposobuPowstaniaInformacjaOUchwale: ").Append(OpisSposobuPowstaniaInformacjaOUchwale).Append("\n");
      sb.Append("  NrDataDecyzjiPrezesaUOKiK: ").Append(NrDataDecyzjiPrezesaUOKiK).Append("\n");
      sb.Append("  Podmioty: ").Append(Podmioty).Append("\n");
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
