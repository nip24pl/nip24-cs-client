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
  public class PostepowanieRestrukturyzacyjneNaprawczePrzymusowaRestrukturyzacja {
    /// <summary>
    /// Gets or Sets UchylenieUkladu
    /// </summary>
    [DataMember(Name="uchylenieUkladu", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "uchylenieUkladu")]
    public string UchylenieUkladu { get; set; }

    /// <summary>
    /// Gets or Sets OtwarciePostepowaniaRestrukturyzacyjnegoNaprawczegoPrzymusowejRestrukturyzacji
    /// </summary>
    [DataMember(Name="otwarciePostepowaniaRestrukturyzacyjnegoNaprawczegoPrzymusowejRestrukturyzacji", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "otwarciePostepowaniaRestrukturyzacyjnegoNaprawczegoPrzymusowejRestrukturyzacji")]
    public OtwarciePostepowaniaRestrukturyzacyjnegoNaprawczegoPrzymusowejRestrukturyzacji OtwarciePostepowaniaRestrukturyzacyjnegoNaprawczegoPrzymusowejRestrukturyzacji { get; set; }

    /// <summary>
    /// Gets or Sets ZakonczeniePostepowaniaRestrukturyzacyjnegoNaprawczegoPrzymusowejRestrukturyzacji
    /// </summary>
    [DataMember(Name="zakonczeniePostepowaniaRestrukturyzacyjnegoNaprawczegoPrzymusowejRestrukturyzacji", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "zakonczeniePostepowaniaRestrukturyzacyjnegoNaprawczegoPrzymusowejRestrukturyzacji")]
    public ZakonczeniePostepowaniaRestrukturyzacyjnegoNaprawczegoPrzymusowejRestrukturyzacji ZakonczeniePostepowaniaRestrukturyzacyjnegoNaprawczegoPrzymusowejRestrukturyzacji { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PostepowanieRestrukturyzacyjneNaprawczePrzymusowaRestrukturyzacja {\n");
      sb.Append("  UchylenieUkladu: ").Append(UchylenieUkladu).Append("\n");
      sb.Append("  OtwarciePostepowaniaRestrukturyzacyjnegoNaprawczegoPrzymusowejRestrukturyzacji: ").Append(OtwarciePostepowaniaRestrukturyzacyjnegoNaprawczegoPrzymusowejRestrukturyzacji).Append("\n");
      sb.Append("  ZakonczeniePostepowaniaRestrukturyzacyjnegoNaprawczegoPrzymusowejRestrukturyzacji: ").Append(ZakonczeniePostepowaniaRestrukturyzacyjnegoNaprawczegoPrzymusowejRestrukturyzacji).Append("\n");
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
