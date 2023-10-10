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
  public class WhitelistStatus {
    /// <summary>
    /// Gets or Sets Uid
    /// </summary>
    [DataMember(Name="uid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "uid")]
    public string Uid { get; set; }

    /// <summary>
    /// Gets or Sets Nip
    /// </summary>
    [DataMember(Name="nip", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nip")]
    public string Nip { get; set; }

    /// <summary>
    /// Gets or Sets Iban
    /// </summary>
    [DataMember(Name="iban", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "iban")]
    public string Iban { get; set; }

    /// <summary>
    /// Gets or Sets Valid
    /// </summary>
    [DataMember(Name="valid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "valid")]
    public bool? Valid { get; set; }

    /// <summary>
    /// Gets or Sets _Virtual
    /// </summary>
    [DataMember(Name="virtual", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "virtual")]
    public bool? _Virtual { get; set; }

    /// <summary>
    /// Gets or Sets VatStatus
    /// </summary>
    [DataMember(Name="vatStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vatStatus")]
    public int? VatStatus { get; set; }

    /// <summary>
    /// Gets or Sets VatResult
    /// </summary>
    [DataMember(Name="vatResult", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vatResult")]
    public string VatResult { get; set; }

    /// <summary>
    /// Gets or Sets HashIndex
    /// </summary>
    [DataMember(Name="hashIndex", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hashIndex")]
    public long? HashIndex { get; set; }

    /// <summary>
    /// Gets or Sets MaskIndex
    /// </summary>
    [DataMember(Name="maskIndex", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maskIndex")]
    public long? MaskIndex { get; set; }

    /// <summary>
    /// Gets or Sets Date
    /// </summary>
    [DataMember(Name="date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "date")]
    public DateTime? Date { get; set; }

    /// <summary>
    /// Gets or Sets Source
    /// </summary>
    [DataMember(Name="source", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "source")]
    public string Source { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class WhitelistStatus {\n");
      sb.Append("  Uid: ").Append(Uid).Append("\n");
      sb.Append("  Nip: ").Append(Nip).Append("\n");
      sb.Append("  Iban: ").Append(Iban).Append("\n");
      sb.Append("  Valid: ").Append(Valid).Append("\n");
      sb.Append("  _Virtual: ").Append(_Virtual).Append("\n");
      sb.Append("  VatStatus: ").Append(VatStatus).Append("\n");
      sb.Append("  VatResult: ").Append(VatResult).Append("\n");
      sb.Append("  HashIndex: ").Append(HashIndex).Append("\n");
      sb.Append("  MaskIndex: ").Append(MaskIndex).Append("\n");
      sb.Append("  Date: ").Append(Date).Append("\n");
      sb.Append("  Source: ").Append(Source).Append("\n");
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
