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
  public class BillingPlan {
    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets SubscriptionPrice
    /// </summary>
    [DataMember(Name="subscriptionPrice", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subscriptionPrice")]
    public double? SubscriptionPrice { get; set; }

    /// <summary>
    /// Gets or Sets ItemPrice
    /// </summary>
    [DataMember(Name="itemPrice", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "itemPrice")]
    public double? ItemPrice { get; set; }

    /// <summary>
    /// Gets or Sets ItemPriceCheckStatus
    /// </summary>
    [DataMember(Name="itemPriceCheckStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "itemPriceCheckStatus")]
    public double? ItemPriceCheckStatus { get; set; }

    /// <summary>
    /// Gets or Sets ItemPriceInvoiceData
    /// </summary>
    [DataMember(Name="itemPriceInvoiceData", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "itemPriceInvoiceData")]
    public double? ItemPriceInvoiceData { get; set; }

    /// <summary>
    /// Gets or Sets ItemPriceAllData
    /// </summary>
    [DataMember(Name="itemPriceAllData", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "itemPriceAllData")]
    public double? ItemPriceAllData { get; set; }

    /// <summary>
    /// Gets or Sets ItemPriceIBANStatus
    /// </summary>
    [DataMember(Name="itemPriceIBANStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "itemPriceIBANStatus")]
    public double? ItemPriceIBANStatus { get; set; }

    /// <summary>
    /// Gets or Sets ItemPriceWLStatus
    /// </summary>
    [DataMember(Name="itemPriceWLStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "itemPriceWLStatus")]
    public double? ItemPriceWLStatus { get; set; }

    /// <summary>
    /// Gets or Sets ItemPriceSearchVAT
    /// </summary>
    [DataMember(Name="itemPriceSearchVAT", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "itemPriceSearchVAT")]
    public double? ItemPriceSearchVAT { get; set; }

    /// <summary>
    /// Gets or Sets Limit
    /// </summary>
    [DataMember(Name="limit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "limit")]
    public int? Limit { get; set; }

    /// <summary>
    /// Gets or Sets RequestDelay
    /// </summary>
    [DataMember(Name="requestDelay", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "requestDelay")]
    public int? RequestDelay { get; set; }

    /// <summary>
    /// Gets or Sets DomainLimit
    /// </summary>
    [DataMember(Name="domainLimit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "domainLimit")]
    public int? DomainLimit { get; set; }

    /// <summary>
    /// Gets or Sets OverplanAllowed
    /// </summary>
    [DataMember(Name="overplanAllowed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "overplanAllowed")]
    public bool? OverplanAllowed { get; set; }

    /// <summary>
    /// Gets or Sets TerytCodes
    /// </summary>
    [DataMember(Name="terytCodes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "terytCodes")]
    public bool? TerytCodes { get; set; }

    /// <summary>
    /// Gets or Sets ExcelAddin
    /// </summary>
    [DataMember(Name="excelAddin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "excelAddin")]
    public bool? ExcelAddin { get; set; }

    /// <summary>
    /// Gets or Sets JpkVat
    /// </summary>
    [DataMember(Name="jpkVat", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "jpkVat")]
    public bool? JpkVat { get; set; }

    /// <summary>
    /// Gets or Sets Cli
    /// </summary>
    [DataMember(Name="cli", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cli")]
    public bool? Cli { get; set; }

    /// <summary>
    /// Gets or Sets Stats
    /// </summary>
    [DataMember(Name="stats", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stats")]
    public bool? Stats { get; set; }

    /// <summary>
    /// Gets or Sets NipMonitor
    /// </summary>
    [DataMember(Name="nipMonitor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nipMonitor")]
    public bool? NipMonitor { get; set; }

    /// <summary>
    /// Gets or Sets SearchByNip
    /// </summary>
    [DataMember(Name="searchByNip", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "searchByNip")]
    public bool? SearchByNip { get; set; }

    /// <summary>
    /// Gets or Sets SearchByRegon
    /// </summary>
    [DataMember(Name="searchByRegon", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "searchByRegon")]
    public bool? SearchByRegon { get; set; }

    /// <summary>
    /// Gets or Sets SearchByKrs
    /// </summary>
    [DataMember(Name="searchByKrs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "searchByKrs")]
    public bool? SearchByKrs { get; set; }

    /// <summary>
    /// Gets or Sets FuncIsActive
    /// </summary>
    [DataMember(Name="funcIsActive", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "funcIsActive")]
    public bool? FuncIsActive { get; set; }

    /// <summary>
    /// Gets or Sets FuncGetInvoiceData
    /// </summary>
    [DataMember(Name="funcGetInvoiceData", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "funcGetInvoiceData")]
    public bool? FuncGetInvoiceData { get; set; }

    /// <summary>
    /// Gets or Sets FuncGetAllData
    /// </summary>
    [DataMember(Name="funcGetAllData", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "funcGetAllData")]
    public bool? FuncGetAllData { get; set; }

    /// <summary>
    /// Gets or Sets FuncGetVIESData
    /// </summary>
    [DataMember(Name="funcGetVIESData", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "funcGetVIESData")]
    public bool? FuncGetVIESData { get; set; }

    /// <summary>
    /// Gets or Sets FuncGetVATStatus
    /// </summary>
    [DataMember(Name="funcGetVATStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "funcGetVATStatus")]
    public bool? FuncGetVATStatus { get; set; }

    /// <summary>
    /// Gets or Sets FuncGetIBANStatus
    /// </summary>
    [DataMember(Name="funcGetIBANStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "funcGetIBANStatus")]
    public bool? FuncGetIBANStatus { get; set; }

    /// <summary>
    /// Gets or Sets FuncGetWLStatus
    /// </summary>
    [DataMember(Name="funcGetWLStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "funcGetWLStatus")]
    public bool? FuncGetWLStatus { get; set; }

    /// <summary>
    /// Gets or Sets FuncSearchVAT
    /// </summary>
    [DataMember(Name="funcSearchVAT", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "funcSearchVAT")]
    public bool? FuncSearchVAT { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BillingPlan {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  SubscriptionPrice: ").Append(SubscriptionPrice).Append("\n");
      sb.Append("  ItemPrice: ").Append(ItemPrice).Append("\n");
      sb.Append("  ItemPriceCheckStatus: ").Append(ItemPriceCheckStatus).Append("\n");
      sb.Append("  ItemPriceInvoiceData: ").Append(ItemPriceInvoiceData).Append("\n");
      sb.Append("  ItemPriceAllData: ").Append(ItemPriceAllData).Append("\n");
      sb.Append("  ItemPriceIBANStatus: ").Append(ItemPriceIBANStatus).Append("\n");
      sb.Append("  ItemPriceWLStatus: ").Append(ItemPriceWLStatus).Append("\n");
      sb.Append("  ItemPriceSearchVAT: ").Append(ItemPriceSearchVAT).Append("\n");
      sb.Append("  Limit: ").Append(Limit).Append("\n");
      sb.Append("  RequestDelay: ").Append(RequestDelay).Append("\n");
      sb.Append("  DomainLimit: ").Append(DomainLimit).Append("\n");
      sb.Append("  OverplanAllowed: ").Append(OverplanAllowed).Append("\n");
      sb.Append("  TerytCodes: ").Append(TerytCodes).Append("\n");
      sb.Append("  ExcelAddin: ").Append(ExcelAddin).Append("\n");
      sb.Append("  JpkVat: ").Append(JpkVat).Append("\n");
      sb.Append("  Cli: ").Append(Cli).Append("\n");
      sb.Append("  Stats: ").Append(Stats).Append("\n");
      sb.Append("  NipMonitor: ").Append(NipMonitor).Append("\n");
      sb.Append("  SearchByNip: ").Append(SearchByNip).Append("\n");
      sb.Append("  SearchByRegon: ").Append(SearchByRegon).Append("\n");
      sb.Append("  SearchByKrs: ").Append(SearchByKrs).Append("\n");
      sb.Append("  FuncIsActive: ").Append(FuncIsActive).Append("\n");
      sb.Append("  FuncGetInvoiceData: ").Append(FuncGetInvoiceData).Append("\n");
      sb.Append("  FuncGetAllData: ").Append(FuncGetAllData).Append("\n");
      sb.Append("  FuncGetVIESData: ").Append(FuncGetVIESData).Append("\n");
      sb.Append("  FuncGetVATStatus: ").Append(FuncGetVATStatus).Append("\n");
      sb.Append("  FuncGetIBANStatus: ").Append(FuncGetIBANStatus).Append("\n");
      sb.Append("  FuncGetWLStatus: ").Append(FuncGetWLStatus).Append("\n");
      sb.Append("  FuncSearchVAT: ").Append(FuncSearchVAT).Append("\n");
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
