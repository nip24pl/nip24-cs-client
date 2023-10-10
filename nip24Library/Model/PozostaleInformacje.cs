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
  public class PozostaleInformacje {
    /// <summary>
    /// Gets or Sets CzasNaJakiUtworzonyZostalPodmiot
    /// </summary>
    [DataMember(Name="czasNaJakiUtworzonyZostalPodmiot", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "czasNaJakiUtworzonyZostalPodmiot")]
    public string CzasNaJakiUtworzonyZostalPodmiot { get; set; }

    /// <summary>
    /// Gets or Sets InformacjaOLiczbieUdzialow
    /// </summary>
    [DataMember(Name="informacjaOLiczbieUdzialow", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "informacjaOLiczbieUdzialow")]
    public string InformacjaOLiczbieUdzialow { get; set; }

    /// <summary>
    /// Gets or Sets CzyUmowaStatutPrzyznajeUprawnieniaOsobiste
    /// </summary>
    [DataMember(Name="czyUmowaStatutPrzyznajeUprawnieniaOsobiste", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "czyUmowaStatutPrzyznajeUprawnieniaOsobiste")]
    public bool? CzyUmowaStatutPrzyznajeUprawnieniaOsobiste { get; set; }

    /// <summary>
    /// Gets or Sets CzyObligatoriuszeMajaPrawoDoUdzialuWZysku
    /// </summary>
    [DataMember(Name="czyObligatoriuszeMajaPrawoDoUdzialuWZysku", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "czyObligatoriuszeMajaPrawoDoUdzialuWZysku")]
    public bool? CzyObligatoriuszeMajaPrawoDoUdzialuWZysku { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PozostaleInformacje {\n");
      sb.Append("  CzasNaJakiUtworzonyZostalPodmiot: ").Append(CzasNaJakiUtworzonyZostalPodmiot).Append("\n");
      sb.Append("  InformacjaOLiczbieUdzialow: ").Append(InformacjaOLiczbieUdzialow).Append("\n");
      sb.Append("  CzyUmowaStatutPrzyznajeUprawnieniaOsobiste: ").Append(CzyUmowaStatutPrzyznajeUprawnieniaOsobiste).Append("\n");
      sb.Append("  CzyObligatoriuszeMajaPrawoDoUdzialuWZysku: ").Append(CzyObligatoriuszeMajaPrawoDoUdzialuWZysku).Append("\n");
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
