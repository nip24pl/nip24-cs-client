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
  public class AccountStatus {
    /// <summary>
    /// Gets or Sets Uid
    /// </summary>
    [DataMember(Name="uid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "uid")]
    public string Uid { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Gets or Sets ValidTo
    /// </summary>
    [DataMember(Name="validTo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "validTo")]
    public DateTime? ValidTo { get; set; }

    /// <summary>
    /// Gets or Sets BillingPlan
    /// </summary>
    [DataMember(Name="billingPlan", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "billingPlan")]
    public BillingPlan BillingPlan { get; set; }

    /// <summary>
    /// Gets or Sets Requests
    /// </summary>
    [DataMember(Name="requests", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "requests")]
    public BillingPlanRequests Requests { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AccountStatus {\n");
      sb.Append("  Uid: ").Append(Uid).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  ValidTo: ").Append(ValidTo).Append("\n");
      sb.Append("  BillingPlan: ").Append(BillingPlan).Append("\n");
      sb.Append("  Requests: ").Append(Requests).Append("\n");
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
