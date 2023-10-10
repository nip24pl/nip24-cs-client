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
  public class SiedzibaIAdres {
    /// <summary>
    /// Gets or Sets AdresPocztyElektronicznej
    /// </summary>
    [DataMember(Name="adresPocztyElektronicznej", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "adresPocztyElektronicznej")]
    public string AdresPocztyElektronicznej { get; set; }

    /// <summary>
    /// Gets or Sets AdresStronyInternetowej
    /// </summary>
    [DataMember(Name="adresStronyInternetowej", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "adresStronyInternetowej")]
    public string AdresStronyInternetowej { get; set; }

    /// <summary>
    /// Gets or Sets Siedziba
    /// </summary>
    [DataMember(Name="siedziba", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "siedziba")]
    public Siedziba Siedziba { get; set; }

    /// <summary>
    /// Gets or Sets Adres
    /// </summary>
    [DataMember(Name="adres", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "adres")]
    public Adres Adres { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SiedzibaIAdres {\n");
      sb.Append("  AdresPocztyElektronicznej: ").Append(AdresPocztyElektronicznej).Append("\n");
      sb.Append("  AdresStronyInternetowej: ").Append(AdresStronyInternetowej).Append("\n");
      sb.Append("  Siedziba: ").Append(Siedziba).Append("\n");
      sb.Append("  Adres: ").Append(Adres).Append("\n");
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
