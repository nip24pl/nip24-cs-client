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
  public class WszczecieEgzekucji {
    /// <summary>
    /// Gets or Sets OrganWydajacyTytulWykonawczy
    /// </summary>
    [DataMember(Name="organWydajacyTytulWykonawczy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "organWydajacyTytulWykonawczy")]
    public string OrganWydajacyTytulWykonawczy { get; set; }

    /// <summary>
    /// Gets or Sets NumerTytuluWykonawczego
    /// </summary>
    [DataMember(Name="numerTytuluWykonawczego", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "numerTytuluWykonawczego")]
    public string NumerTytuluWykonawczego { get; set; }

    /// <summary>
    /// Gets or Sets DataWszczeciaEgzekucji
    /// </summary>
    [DataMember(Name="dataWszczeciaEgzekucji", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dataWszczeciaEgzekucji")]
    public string DataWszczeciaEgzekucji { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class WszczecieEgzekucji {\n");
      sb.Append("  OrganWydajacyTytulWykonawczy: ").Append(OrganWydajacyTytulWykonawczy).Append("\n");
      sb.Append("  NumerTytuluWykonawczego: ").Append(NumerTytuluWykonawczego).Append("\n");
      sb.Append("  DataWszczeciaEgzekucji: ").Append(DataWszczeciaEgzekucji).Append("\n");
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
