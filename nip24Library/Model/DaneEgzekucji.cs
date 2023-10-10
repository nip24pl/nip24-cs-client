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
  public class DaneEgzekucji {
    /// <summary>
    /// Gets or Sets OrganProwadzacyEgzekucje
    /// </summary>
    [DataMember(Name="organProwadzacyEgzekucje", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "organProwadzacyEgzekucje")]
    public string OrganProwadzacyEgzekucje { get; set; }

    /// <summary>
    /// Gets or Sets SygnaturaSprawy
    /// </summary>
    [DataMember(Name="sygnaturaSprawy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sygnaturaSprawy")]
    public string SygnaturaSprawy { get; set; }

    /// <summary>
    /// Gets or Sets DataPostanowienia
    /// </summary>
    [DataMember(Name="dataPostanowienia", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dataPostanowienia")]
    public string DataPostanowienia { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DaneEgzekucji {\n");
      sb.Append("  OrganProwadzacyEgzekucje: ").Append(OrganProwadzacyEgzekucje).Append("\n");
      sb.Append("  SygnaturaSprawy: ").Append(SygnaturaSprawy).Append("\n");
      sb.Append("  DataPostanowienia: ").Append(DataPostanowienia).Append("\n");
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
