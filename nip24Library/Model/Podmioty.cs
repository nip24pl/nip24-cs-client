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
  public class Podmioty {
    /// <summary>
    /// Gets or Sets Nazwa
    /// </summary>
    [DataMember(Name="nazwa", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nazwa")]
    public string Nazwa { get; set; }

    /// <summary>
    /// Gets or Sets KrajNazwaRejestruEwidencji
    /// </summary>
    [DataMember(Name="krajNazwaRejestruEwidencji", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "krajNazwaRejestruEwidencji")]
    public string KrajNazwaRejestruEwidencji { get; set; }

    /// <summary>
    /// Gets or Sets NumerWRejestrzeAlboEwidencji
    /// </summary>
    [DataMember(Name="numerWRejestrzeAlboEwidencji", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "numerWRejestrzeAlboEwidencji")]
    public string NumerWRejestrzeAlboEwidencji { get; set; }

    /// <summary>
    /// Gets or Sets NazwaSaduOrganuProwadzacegoRejestrEwidencje
    /// </summary>
    [DataMember(Name="nazwaSaduOrganuProwadzacegoRejestrEwidencje", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nazwaSaduOrganuProwadzacegoRejestrEwidencje")]
    public string NazwaSaduOrganuProwadzacegoRejestrEwidencje { get; set; }

    /// <summary>
    /// Gets or Sets Identyfikatory
    /// </summary>
    [DataMember(Name="identyfikatory", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "identyfikatory")]
    public IdentyfikatoryPodmiotu Identyfikatory { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Podmioty {\n");
      sb.Append("  Nazwa: ").Append(Nazwa).Append("\n");
      sb.Append("  KrajNazwaRejestruEwidencji: ").Append(KrajNazwaRejestruEwidencji).Append("\n");
      sb.Append("  NumerWRejestrzeAlboEwidencji: ").Append(NumerWRejestrzeAlboEwidencji).Append("\n");
      sb.Append("  NazwaSaduOrganuProwadzacegoRejestrEwidencje: ").Append(NazwaSaduOrganuProwadzacegoRejestrEwidencje).Append("\n");
      sb.Append("  Identyfikatory: ").Append(Identyfikatory).Append("\n");
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
