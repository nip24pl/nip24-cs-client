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
  public class Adres {
    /// <summary>
    /// Gets or Sets Ulica
    /// </summary>
    [DataMember(Name="ulica", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ulica")]
    public string Ulica { get; set; }

    /// <summary>
    /// Gets or Sets NrDomu
    /// </summary>
    [DataMember(Name="nrDomu", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nrDomu")]
    public string NrDomu { get; set; }

    /// <summary>
    /// Gets or Sets NrLokalu
    /// </summary>
    [DataMember(Name="nrLokalu", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nrLokalu")]
    public string NrLokalu { get; set; }

    /// <summary>
    /// Gets or Sets Miejscowosc
    /// </summary>
    [DataMember(Name="miejscowosc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "miejscowosc")]
    public string Miejscowosc { get; set; }

    /// <summary>
    /// Gets or Sets KodPocztowy
    /// </summary>
    [DataMember(Name="kodPocztowy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "kodPocztowy")]
    public string KodPocztowy { get; set; }

    /// <summary>
    /// Gets or Sets Poczta
    /// </summary>
    [DataMember(Name="poczta", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "poczta")]
    public string Poczta { get; set; }

    /// <summary>
    /// Gets or Sets Kraj
    /// </summary>
    [DataMember(Name="kraj", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "kraj")]
    public string Kraj { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Adres {\n");
      sb.Append("  Ulica: ").Append(Ulica).Append("\n");
      sb.Append("  NrDomu: ").Append(NrDomu).Append("\n");
      sb.Append("  NrLokalu: ").Append(NrLokalu).Append("\n");
      sb.Append("  Miejscowosc: ").Append(Miejscowosc).Append("\n");
      sb.Append("  KodPocztowy: ").Append(KodPocztowy).Append("\n");
      sb.Append("  Poczta: ").Append(Poczta).Append("\n");
      sb.Append("  Kraj: ").Append(Kraj).Append("\n");
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
