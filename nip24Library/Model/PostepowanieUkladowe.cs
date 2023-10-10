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
  public class PostepowanieUkladowe {
    /// <summary>
    /// Gets or Sets UchylenieUkladu
    /// </summary>
    [DataMember(Name="uchylenieUkladu", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "uchylenieUkladu")]
    public string UchylenieUkladu { get; set; }

    /// <summary>
    /// Gets or Sets OtwarciePostepowaniaUkladowego
    /// </summary>
    [DataMember(Name="otwarciePostepowaniaUkladowego", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "otwarciePostepowaniaUkladowego")]
    public OtwarciePostepowaniaUkladowego OtwarciePostepowaniaUkladowego { get; set; }

    /// <summary>
    /// Gets or Sets ZakonczeniePostepowaniaUkladowego
    /// </summary>
    [DataMember(Name="zakonczeniePostepowaniaUkladowego", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "zakonczeniePostepowaniaUkladowego")]
    public ZakonczeniePostepowaniaUkladowego ZakonczeniePostepowaniaUkladowego { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PostepowanieUkladowe {\n");
      sb.Append("  UchylenieUkladu: ").Append(UchylenieUkladu).Append("\n");
      sb.Append("  OtwarciePostepowaniaUkladowego: ").Append(OtwarciePostepowaniaUkladowego).Append("\n");
      sb.Append("  ZakonczeniePostepowaniaUkladowego: ").Append(ZakonczeniePostepowaniaUkladowego).Append("\n");
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
