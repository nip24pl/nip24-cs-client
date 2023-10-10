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
  public class DanePodmiotu {
    /// <summary>
    /// Gets or Sets FormaPrawna
    /// </summary>
    [DataMember(Name="formaPrawna", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "formaPrawna")]
    public string FormaPrawna { get; set; }

    /// <summary>
    /// Gets or Sets Nazwa
    /// </summary>
    [DataMember(Name="nazwa", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nazwa")]
    public string Nazwa { get; set; }

    /// <summary>
    /// Gets or Sets CzyProwadziDzialalnoscZInnymiPodmiotami
    /// </summary>
    [DataMember(Name="czyProwadziDzialalnoscZInnymiPodmiotami", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "czyProwadziDzialalnoscZInnymiPodmiotami")]
    public bool? CzyProwadziDzialalnoscZInnymiPodmiotami { get; set; }

    /// <summary>
    /// Gets or Sets CzyPosiadaStatusOPP
    /// </summary>
    [DataMember(Name="czyPosiadaStatusOPP", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "czyPosiadaStatusOPP")]
    public bool? CzyPosiadaStatusOPP { get; set; }

    /// <summary>
    /// Gets or Sets Identyfikatory
    /// </summary>
    [DataMember(Name="identyfikatory", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "identyfikatory")]
    public IdentyfikatoryPodmiotu Identyfikatory { get; set; }

    /// <summary>
    /// Gets or Sets DaneOWczesniejszejRejestracji
    /// </summary>
    [DataMember(Name="daneOWczesniejszejRejestracji", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "daneOWczesniejszejRejestracji")]
    public DaneOWczesniejszejRejestracji DaneOWczesniejszejRejestracji { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DanePodmiotu {\n");
      sb.Append("  FormaPrawna: ").Append(FormaPrawna).Append("\n");
      sb.Append("  Nazwa: ").Append(Nazwa).Append("\n");
      sb.Append("  CzyProwadziDzialalnoscZInnymiPodmiotami: ").Append(CzyProwadziDzialalnoscZInnymiPodmiotami).Append("\n");
      sb.Append("  CzyPosiadaStatusOPP: ").Append(CzyPosiadaStatusOPP).Append("\n");
      sb.Append("  Identyfikatory: ").Append(Identyfikatory).Append("\n");
      sb.Append("  DaneOWczesniejszejRejestracji: ").Append(DaneOWczesniejszejRejestracji).Append("\n");
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
