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
  public class BillingPlanRequests {
    /// <summary>
    /// Gets or Sets InvoiceData
    /// </summary>
    [DataMember(Name="invoiceData", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoiceData")]
    public int? InvoiceData { get; set; }

    /// <summary>
    /// Gets or Sets AllData
    /// </summary>
    [DataMember(Name="allData", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "allData")]
    public int? AllData { get; set; }

    /// <summary>
    /// Gets or Sets FirmStatus
    /// </summary>
    [DataMember(Name="firmStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "firmStatus")]
    public int? FirmStatus { get; set; }

    /// <summary>
    /// Gets or Sets VatStatus
    /// </summary>
    [DataMember(Name="vatStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vatStatus")]
    public int? VatStatus { get; set; }

    /// <summary>
    /// Gets or Sets ViesStatus
    /// </summary>
    [DataMember(Name="viesStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "viesStatus")]
    public int? ViesStatus { get; set; }

    /// <summary>
    /// Gets or Sets IbanStatus
    /// </summary>
    [DataMember(Name="ibanStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ibanStatus")]
    public int? IbanStatus { get; set; }

    /// <summary>
    /// Gets or Sets WlStatus
    /// </summary>
    [DataMember(Name="wlStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "wlStatus")]
    public int? WlStatus { get; set; }

    /// <summary>
    /// Gets or Sets SearchVAT
    /// </summary>
    [DataMember(Name="searchVAT", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "searchVAT")]
    public int? SearchVAT { get; set; }

    /// <summary>
    /// Gets or Sets Total
    /// </summary>
    [DataMember(Name="total", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total")]
    public int? Total { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BillingPlanRequests {\n");
      sb.Append("  InvoiceData: ").Append(InvoiceData).Append("\n");
      sb.Append("  AllData: ").Append(AllData).Append("\n");
      sb.Append("  FirmStatus: ").Append(FirmStatus).Append("\n");
      sb.Append("  VatStatus: ").Append(VatStatus).Append("\n");
      sb.Append("  ViesStatus: ").Append(ViesStatus).Append("\n");
      sb.Append("  IbanStatus: ").Append(IbanStatus).Append("\n");
      sb.Append("  WlStatus: ").Append(WlStatus).Append("\n");
      sb.Append("  SearchVAT: ").Append(SearchVAT).Append("\n");
      sb.Append("  Total: ").Append(Total).Append("\n");
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
