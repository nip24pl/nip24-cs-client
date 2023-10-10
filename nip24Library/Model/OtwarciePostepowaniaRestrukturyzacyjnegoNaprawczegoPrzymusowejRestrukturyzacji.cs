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
  public class OtwarciePostepowaniaRestrukturyzacyjnegoNaprawczegoPrzymusowejRestrukturyzacji {
    /// <summary>
    /// Gets or Sets OrganWydajacy
    /// </summary>
    [DataMember(Name="organWydajacy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "organWydajacy")]
    public string OrganWydajacy { get; set; }

    /// <summary>
    /// Gets or Sets Sygnatura
    /// </summary>
    [DataMember(Name="sygnatura", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sygnatura")]
    public string Sygnatura { get; set; }

    /// <summary>
    /// Gets or Sets DataNadaniaKlauzuliWykonalnosci
    /// </summary>
    [DataMember(Name="dataNadaniaKlauzuliWykonalnosci", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dataNadaniaKlauzuliWykonalnosci")]
    public string DataNadaniaKlauzuliWykonalnosci { get; set; }

    /// <summary>
    /// Gets or Sets RodzajPostepowania
    /// </summary>
    [DataMember(Name="rodzajPostepowania", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rodzajPostepowania")]
    public string RodzajPostepowania { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OtwarciePostepowaniaRestrukturyzacyjnegoNaprawczegoPrzymusowejRestrukturyzacji {\n");
      sb.Append("  OrganWydajacy: ").Append(OrganWydajacy).Append("\n");
      sb.Append("  Sygnatura: ").Append(Sygnatura).Append("\n");
      sb.Append("  DataNadaniaKlauzuliWykonalnosci: ").Append(DataNadaniaKlauzuliWykonalnosci).Append("\n");
      sb.Append("  RodzajPostepowania: ").Append(RodzajPostepowania).Append("\n");
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
