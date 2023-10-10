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
  public class Dzial1 {
    /// <summary>
    /// Gets or Sets OrganSprawujacyNadzor
    /// </summary>
    [DataMember(Name="organSprawujacyNadzor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "organSprawujacyNadzor")]
    public OrganSprawujacyNadzor OrganSprawujacyNadzor { get; set; }

    /// <summary>
    /// Gets or Sets DanePodmiotu
    /// </summary>
    [DataMember(Name="danePodmiotu", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "danePodmiotu")]
    public DanePodmiotu DanePodmiotu { get; set; }

    /// <summary>
    /// Gets or Sets SiedzibaIAdres
    /// </summary>
    [DataMember(Name="siedzibaIAdres", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "siedzibaIAdres")]
    public SiedzibaIAdres SiedzibaIAdres { get; set; }

    /// <summary>
    /// Gets or Sets JednostkiTerenoweOddzialy
    /// </summary>
    [DataMember(Name="jednostkiTerenoweOddzialy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "jednostkiTerenoweOddzialy")]
    public List<JednostkiTerenoweOddzialy> JednostkiTerenoweOddzialy { get; set; }

    /// <summary>
    /// Gets or Sets UmowaStatut
    /// </summary>
    [DataMember(Name="umowaStatut", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "umowaStatut")]
    public UmowaStatut UmowaStatut { get; set; }

    /// <summary>
    /// Gets or Sets PozostaleInformacje
    /// </summary>
    [DataMember(Name="pozostaleInformacje", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pozostaleInformacje")]
    public PozostaleInformacje PozostaleInformacje { get; set; }

    /// <summary>
    /// Gets or Sets WspolnicySpzoo
    /// </summary>
    [DataMember(Name="wspolnicySpzoo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "wspolnicySpzoo")]
    public List<WspolnicySpzoo> WspolnicySpzoo { get; set; }

    /// <summary>
    /// Gets or Sets JedynyAkcjonariusz
    /// </summary>
    [DataMember(Name="jedynyAkcjonariusz", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "jedynyAkcjonariusz")]
    public List<JedynyAkcjonariusz> JedynyAkcjonariusz { get; set; }

    /// <summary>
    /// Gets or Sets SposobPowstaniaPodmiotu
    /// </summary>
    [DataMember(Name="sposobPowstaniaPodmiotu", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sposobPowstaniaPodmiotu")]
    public SposobPowstaniaPodmiotu SposobPowstaniaPodmiotu { get; set; }

    /// <summary>
    /// Gets or Sets Kapital
    /// </summary>
    [DataMember(Name="kapital", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "kapital")]
    public Kapital Kapital { get; set; }

    /// <summary>
    /// Gets or Sets EmisjeAkcji
    /// </summary>
    [DataMember(Name="emisjeAkcji", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "emisjeAkcji")]
    public List<EmisjeAkcji> EmisjeAkcji { get; set; }

    /// <summary>
    /// Gets or Sets WzmiankaOPodjeciuUchwalyOEmisjachObligacjiZamiennych
    /// </summary>
    [DataMember(Name="wzmiankaOPodjeciuUchwalyOEmisjachObligacjiZamiennych", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "wzmiankaOPodjeciuUchwalyOEmisjachObligacjiZamiennych")]
    public WzmiankaOPodjeciuUchwalyOEmisjachObligacjiZamiennych WzmiankaOPodjeciuUchwalyOEmisjachObligacjiZamiennych { get; set; }

    /// <summary>
    /// Gets or Sets WzmiankaOUpowaznieniuDoEmisjiWarrantowSubskrypcyjnych
    /// </summary>
    [DataMember(Name="wzmiankaOUpowaznieniuDoEmisjiWarrantowSubskrypcyjnych", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "wzmiankaOUpowaznieniuDoEmisjiWarrantowSubskrypcyjnych")]
    public WzmiankaOUpowaznieniuDoEmisjiWarrantowSubskrypcyjnych WzmiankaOUpowaznieniuDoEmisjiWarrantowSubskrypcyjnych { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Dzial1 {\n");
      sb.Append("  OrganSprawujacyNadzor: ").Append(OrganSprawujacyNadzor).Append("\n");
      sb.Append("  DanePodmiotu: ").Append(DanePodmiotu).Append("\n");
      sb.Append("  SiedzibaIAdres: ").Append(SiedzibaIAdres).Append("\n");
      sb.Append("  JednostkiTerenoweOddzialy: ").Append(JednostkiTerenoweOddzialy).Append("\n");
      sb.Append("  UmowaStatut: ").Append(UmowaStatut).Append("\n");
      sb.Append("  PozostaleInformacje: ").Append(PozostaleInformacje).Append("\n");
      sb.Append("  WspolnicySpzoo: ").Append(WspolnicySpzoo).Append("\n");
      sb.Append("  JedynyAkcjonariusz: ").Append(JedynyAkcjonariusz).Append("\n");
      sb.Append("  SposobPowstaniaPodmiotu: ").Append(SposobPowstaniaPodmiotu).Append("\n");
      sb.Append("  Kapital: ").Append(Kapital).Append("\n");
      sb.Append("  EmisjeAkcji: ").Append(EmisjeAkcji).Append("\n");
      sb.Append("  WzmiankaOPodjeciuUchwalyOEmisjachObligacjiZamiennych: ").Append(WzmiankaOPodjeciuUchwalyOEmisjachObligacjiZamiennych).Append("\n");
      sb.Append("  WzmiankaOUpowaznieniuDoEmisjiWarrantowSubskrypcyjnych: ").Append(WzmiankaOUpowaznieniuDoEmisjiWarrantowSubskrypcyjnych).Append("\n");
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
