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
  public class IBANStatus {
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
    /// Gets or Sets Regon
    /// </summary>
    [DataMember(Name="regon", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "regon")]
    public string Regon { get; set; }

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
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

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
      sb.Append("class IBANStatus {\n");
      sb.Append("  Uid: ").Append(Uid).Append("\n");
      sb.Append("  Nip: ").Append(Nip).Append("\n");
      sb.Append("  Regon: ").Append(Regon).Append("\n");
      sb.Append("  Iban: ").Append(Iban).Append("\n");
      sb.Append("  Valid: ").Append(Valid).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
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
