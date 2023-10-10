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
  public class NaglowekA {
    /// <summary>
    /// Gets or Sets Rejestr
    /// </summary>
    [DataMember(Name="rejestr", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rejestr")]
    public Rejestr Rejestr { get; set; }

    /// <summary>
    /// Gets or Sets NumerKRS
    /// </summary>
    [DataMember(Name="numerKRS", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "numerKRS")]
    public string NumerKRS { get; set; }

    /// <summary>
    /// Gets or Sets DataCzasOdpisu
    /// </summary>
    [DataMember(Name="dataCzasOdpisu", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dataCzasOdpisu")]
    public string DataCzasOdpisu { get; set; }

    /// <summary>
    /// Gets or Sets StanZDnia
    /// </summary>
    [DataMember(Name="stanZDnia", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stanZDnia")]
    public string StanZDnia { get; set; }

    /// <summary>
    /// Gets or Sets DataRejestracjiWKRS
    /// </summary>
    [DataMember(Name="dataRejestracjiWKRS", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dataRejestracjiWKRS")]
    public string DataRejestracjiWKRS { get; set; }

    /// <summary>
    /// Gets or Sets NumerOstatniegoWpisu
    /// </summary>
    [DataMember(Name="numerOstatniegoWpisu", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "numerOstatniegoWpisu")]
    public int? NumerOstatniegoWpisu { get; set; }

    /// <summary>
    /// Gets or Sets DataOstatniegoWpisu
    /// </summary>
    [DataMember(Name="dataOstatniegoWpisu", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dataOstatniegoWpisu")]
    public string DataOstatniegoWpisu { get; set; }

    /// <summary>
    /// Gets or Sets SygnaturaAktSprawyDotyczacejOstatniegoWpisu
    /// </summary>
    [DataMember(Name="sygnaturaAktSprawyDotyczacejOstatniegoWpisu", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sygnaturaAktSprawyDotyczacejOstatniegoWpisu")]
    public string SygnaturaAktSprawyDotyczacejOstatniegoWpisu { get; set; }

    /// <summary>
    /// Gets or Sets OznaczenieSaduDokonujacegoOstatniegoWpisu
    /// </summary>
    [DataMember(Name="oznaczenieSaduDokonujacegoOstatniegoWpisu", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "oznaczenieSaduDokonujacegoOstatniegoWpisu")]
    public string OznaczenieSaduDokonujacegoOstatniegoWpisu { get; set; }

    /// <summary>
    /// Gets or Sets StanPozycji
    /// </summary>
    [DataMember(Name="stanPozycji", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stanPozycji")]
    public int? StanPozycji { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class NaglowekA {\n");
      sb.Append("  Rejestr: ").Append(Rejestr).Append("\n");
      sb.Append("  NumerKRS: ").Append(NumerKRS).Append("\n");
      sb.Append("  DataCzasOdpisu: ").Append(DataCzasOdpisu).Append("\n");
      sb.Append("  StanZDnia: ").Append(StanZDnia).Append("\n");
      sb.Append("  DataRejestracjiWKRS: ").Append(DataRejestracjiWKRS).Append("\n");
      sb.Append("  NumerOstatniegoWpisu: ").Append(NumerOstatniegoWpisu).Append("\n");
      sb.Append("  DataOstatniegoWpisu: ").Append(DataOstatniegoWpisu).Append("\n");
      sb.Append("  SygnaturaAktSprawyDotyczacejOstatniegoWpisu: ").Append(SygnaturaAktSprawyDotyczacejOstatniegoWpisu).Append("\n");
      sb.Append("  OznaczenieSaduDokonujacegoOstatniegoWpisu: ").Append(OznaczenieSaduDokonujacegoOstatniegoWpisu).Append("\n");
      sb.Append("  StanPozycji: ").Append(StanPozycji).Append("\n");
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
