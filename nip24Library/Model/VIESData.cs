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
  public class VIESData {
    /// <summary>
    /// Gets or Sets Uid
    /// </summary>
    [DataMember(Name="uid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "uid")]
    public string Uid { get; set; }

    /// <summary>
    /// Gets or Sets CountryCode
    /// </summary>
    [DataMember(Name="countryCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "countryCode")]
    public string CountryCode { get; set; }

    /// <summary>
    /// Gets or Sets VatNumber
    /// </summary>
    [DataMember(Name="vatNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vatNumber")]
    public string VatNumber { get; set; }

    /// <summary>
    /// Gets or Sets Valid
    /// </summary>
    [DataMember(Name="valid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "valid")]
    public bool? Valid { get; set; }

    /// <summary>
    /// Gets or Sets TraderName
    /// </summary>
    [DataMember(Name="traderName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "traderName")]
    public string TraderName { get; set; }

    /// <summary>
    /// Gets or Sets TraderCompanyType
    /// </summary>
    [DataMember(Name="traderCompanyType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "traderCompanyType")]
    public string TraderCompanyType { get; set; }

    /// <summary>
    /// Gets or Sets TraderAddress
    /// </summary>
    [DataMember(Name="traderAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "traderAddress")]
    public string TraderAddress { get; set; }

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
      sb.Append("class VIESData {\n");
      sb.Append("  Uid: ").Append(Uid).Append("\n");
      sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
      sb.Append("  VatNumber: ").Append(VatNumber).Append("\n");
      sb.Append("  Valid: ").Append(Valid).Append("\n");
      sb.Append("  TraderName: ").Append(TraderName).Append("\n");
      sb.Append("  TraderCompanyType: ").Append(TraderCompanyType).Append("\n");
      sb.Append("  TraderAddress: ").Append(TraderAddress).Append("\n");
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
