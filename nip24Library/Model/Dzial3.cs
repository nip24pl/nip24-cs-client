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
  public class Dzial3 {
    /// <summary>
    /// Gets or Sets CelDzialaniaOrganizacji
    /// </summary>
    [DataMember(Name="celDzialaniaOrganizacji", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "celDzialaniaOrganizacji")]
    public CelDzialaniaOrganizacji CelDzialaniaOrganizacji { get; set; }

    /// <summary>
    /// Gets or Sets InformacjaODniuKonczacymRokObrotowy
    /// </summary>
    [DataMember(Name="informacjaODniuKonczacymRokObrotowy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "informacjaODniuKonczacymRokObrotowy")]
    public InformacjaODniuKonczacymRokObrotowy InformacjaODniuKonczacymRokObrotowy { get; set; }

    /// <summary>
    /// Gets or Sets PrzedmiotDzialalnosci
    /// </summary>
    [DataMember(Name="przedmiotDzialalnosci", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "przedmiotDzialalnosci")]
    public PrzedmiotDzialalnosci PrzedmiotDzialalnosci { get; set; }

    /// <summary>
    /// Gets or Sets PrzedmiotDzialalnosciOPP
    /// </summary>
    [DataMember(Name="przedmiotDzialalnosciOPP", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "przedmiotDzialalnosciOPP")]
    public PrzedmiotDzialalnosciOPP PrzedmiotDzialalnosciOPP { get; set; }

    /// <summary>
    /// Gets or Sets SprawozdaniaGrupyKapitalowej
    /// </summary>
    [DataMember(Name="sprawozdaniaGrupyKapitalowej", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sprawozdaniaGrupyKapitalowej")]
    public SprawozdaniaGrupyKapitalowej SprawozdaniaGrupyKapitalowej { get; set; }

    /// <summary>
    /// Gets or Sets WzmiankiOZlozonychDokumentach
    /// </summary>
    [DataMember(Name="wzmiankiOZlozonychDokumentach", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "wzmiankiOZlozonychDokumentach")]
    public WzmiankiOZlozonychDokumentach WzmiankiOZlozonychDokumentach { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Dzial3 {\n");
      sb.Append("  CelDzialaniaOrganizacji: ").Append(CelDzialaniaOrganizacji).Append("\n");
      sb.Append("  InformacjaODniuKonczacymRokObrotowy: ").Append(InformacjaODniuKonczacymRokObrotowy).Append("\n");
      sb.Append("  PrzedmiotDzialalnosci: ").Append(PrzedmiotDzialalnosci).Append("\n");
      sb.Append("  PrzedmiotDzialalnosciOPP: ").Append(PrzedmiotDzialalnosciOPP).Append("\n");
      sb.Append("  SprawozdaniaGrupyKapitalowej: ").Append(SprawozdaniaGrupyKapitalowej).Append("\n");
      sb.Append("  WzmiankiOZlozonychDokumentach: ").Append(WzmiankiOZlozonychDokumentach).Append("\n");
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
