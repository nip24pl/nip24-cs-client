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
  public class Zaleglosci {
    /// <summary>
    /// Gets or Sets CharakterZaleglosci
    /// </summary>
    [DataMember(Name="charakterZaleglosci", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "charakterZaleglosci")]
    public string CharakterZaleglosci { get; set; }

    /// <summary>
    /// Gets or Sets ZakonczenieEgzekucji
    /// </summary>
    [DataMember(Name="zakonczenieEgzekucji", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "zakonczenieEgzekucji")]
    public string ZakonczenieEgzekucji { get; set; }

    /// <summary>
    /// Gets or Sets WszczecieEgzekucji
    /// </summary>
    [DataMember(Name="wszczecieEgzekucji", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "wszczecieEgzekucji")]
    public WszczecieEgzekucji WszczecieEgzekucji { get; set; }

    /// <summary>
    /// Gets or Sets UmorzenieEgzekucji
    /// </summary>
    [DataMember(Name="umorzenieEgzekucji", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "umorzenieEgzekucji")]
    public DaneEgzekucji UmorzenieEgzekucji { get; set; }

    /// <summary>
    /// Gets or Sets WysokoscZaleglosci
    /// </summary>
    [DataMember(Name="wysokoscZaleglosci", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "wysokoscZaleglosci")]
    public WysokoscZaleglosci WysokoscZaleglosci { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Zaleglosci {\n");
      sb.Append("  CharakterZaleglosci: ").Append(CharakterZaleglosci).Append("\n");
      sb.Append("  ZakonczenieEgzekucji: ").Append(ZakonczenieEgzekucji).Append("\n");
      sb.Append("  WszczecieEgzekucji: ").Append(WszczecieEgzekucji).Append("\n");
      sb.Append("  UmorzenieEgzekucji: ").Append(UmorzenieEgzekucji).Append("\n");
      sb.Append("  WysokoscZaleglosci: ").Append(WysokoscZaleglosci).Append("\n");
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
