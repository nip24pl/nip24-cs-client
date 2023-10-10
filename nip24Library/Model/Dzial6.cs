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
  public class Dzial6 {
    /// <summary>
    /// Gets or Sets PostepowanieUpadlosciowe
    /// </summary>
    [DataMember(Name="postepowanieUpadlosciowe", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "postepowanieUpadlosciowe")]
    public List<PostepowanieUpadlosciowe> PostepowanieUpadlosciowe { get; set; }

    /// <summary>
    /// Gets or Sets PolaczeniePodzialPrzeksztalcenie
    /// </summary>
    [DataMember(Name="polaczeniePodzialPrzeksztalcenie", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "polaczeniePodzialPrzeksztalcenie")]
    public List<PolaczeniePodzialPrzeksztalcenie> PolaczeniePodzialPrzeksztalcenie { get; set; }

    /// <summary>
    /// Gets or Sets Likwidacja
    /// </summary>
    [DataMember(Name="likwidacja", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "likwidacja")]
    public List<Likwidacja> Likwidacja { get; set; }

    /// <summary>
    /// Gets or Sets RozwiazanieUniewaznienie
    /// </summary>
    [DataMember(Name="rozwiazanieUniewaznienie", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rozwiazanieUniewaznienie")]
    public List<RozwiazanieUniewaznienie> RozwiazanieUniewaznienie { get; set; }

    /// <summary>
    /// Gets or Sets ZawieszenieWznowienie
    /// </summary>
    [DataMember(Name="zawieszenieWznowienie", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "zawieszenieWznowienie")]
    public List<ZawieszenieWznowienie> ZawieszenieWznowienie { get; set; }

    /// <summary>
    /// Gets or Sets PostepowanieUkladowe
    /// </summary>
    [DataMember(Name="postepowanieUkladowe", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "postepowanieUkladowe")]
    public List<PostepowanieUkladowe> PostepowanieUkladowe { get; set; }

    /// <summary>
    /// Gets or Sets PostepowanieRestrukturyzacyjneNaprawczePrzymusowaRestrukturyzacja
    /// </summary>
    [DataMember(Name="postepowanieRestrukturyzacyjneNaprawczePrzymusowaRestrukturyzacja", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "postepowanieRestrukturyzacyjneNaprawczePrzymusowaRestrukturyzacja")]
    public List<PostepowanieRestrukturyzacyjneNaprawczePrzymusowaRestrukturyzacja> PostepowanieRestrukturyzacyjneNaprawczePrzymusowaRestrukturyzacja { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Dzial6 {\n");
      sb.Append("  PostepowanieUpadlosciowe: ").Append(PostepowanieUpadlosciowe).Append("\n");
      sb.Append("  PolaczeniePodzialPrzeksztalcenie: ").Append(PolaczeniePodzialPrzeksztalcenie).Append("\n");
      sb.Append("  Likwidacja: ").Append(Likwidacja).Append("\n");
      sb.Append("  RozwiazanieUniewaznienie: ").Append(RozwiazanieUniewaznienie).Append("\n");
      sb.Append("  ZawieszenieWznowienie: ").Append(ZawieszenieWznowienie).Append("\n");
      sb.Append("  PostepowanieUkladowe: ").Append(PostepowanieUkladowe).Append("\n");
      sb.Append("  PostepowanieRestrukturyzacyjneNaprawczePrzymusowaRestrukturyzacja: ").Append(PostepowanieRestrukturyzacyjneNaprawczePrzymusowaRestrukturyzacja).Append("\n");
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
