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
  public class Kapital {
    /// <summary>
    /// Gets or Sets WniesioneAporty
    /// </summary>
    [DataMember(Name="wniesioneAporty", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "wniesioneAporty")]
    public Object WniesioneAporty { get; set; }

    /// <summary>
    /// Gets or Sets LacznaLiczbaAkcjiUdzialow
    /// </summary>
    [DataMember(Name="lacznaLiczbaAkcjiUdzialow", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lacznaLiczbaAkcjiUdzialow")]
    public string LacznaLiczbaAkcjiUdzialow { get; set; }

    /// <summary>
    /// Gets or Sets WysokoscKapitaluZakladowego
    /// </summary>
    [DataMember(Name="wysokoscKapitaluZakladowego", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "wysokoscKapitaluZakladowego")]
    public WysokoscKapitaluZakladowego WysokoscKapitaluZakladowego { get; set; }

    /// <summary>
    /// Gets or Sets WartoscJednejAkcji
    /// </summary>
    [DataMember(Name="wartoscJednejAkcji", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "wartoscJednejAkcji")]
    public WartoscJednejAkcji WartoscJednejAkcji { get; set; }

    /// <summary>
    /// Gets or Sets CzescKapitaluWplaconegoPokrytego
    /// </summary>
    [DataMember(Name="czescKapitaluWplaconegoPokrytego", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "czescKapitaluWplaconegoPokrytego")]
    public CzescKapitaluWplaconegoPokrytego CzescKapitaluWplaconegoPokrytego { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Kapital {\n");
      sb.Append("  WniesioneAporty: ").Append(WniesioneAporty).Append("\n");
      sb.Append("  LacznaLiczbaAkcjiUdzialow: ").Append(LacznaLiczbaAkcjiUdzialow).Append("\n");
      sb.Append("  WysokoscKapitaluZakladowego: ").Append(WysokoscKapitaluZakladowego).Append("\n");
      sb.Append("  WartoscJednejAkcji: ").Append(WartoscJednejAkcji).Append("\n");
      sb.Append("  CzescKapitaluWplaconegoPokrytego: ").Append(CzescKapitaluWplaconegoPokrytego).Append("\n");
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
