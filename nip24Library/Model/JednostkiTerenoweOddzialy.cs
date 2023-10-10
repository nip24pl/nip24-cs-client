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
  public class JednostkiTerenoweOddzialy {
    /// <summary>
    /// Gets or Sets Nazwa
    /// </summary>
    [DataMember(Name="nazwa", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nazwa")]
    public string Nazwa { get; set; }

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
      sb.Append("class JednostkiTerenoweOddzialy {\n");
      sb.Append("  Nazwa: ").Append(Nazwa).Append("\n");
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
