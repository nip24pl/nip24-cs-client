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
  public class SprawozdaniaGrupyKapitalowej {
    /// <summary>
    /// Gets or Sets WzmiankaOZlozeniuOpiniiBieglegoRewidentaSprawozdaniaZBadania
    /// </summary>
    [DataMember(Name="wzmiankaOZlozeniuOpiniiBieglegoRewidentaSprawozdaniaZBadania", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "wzmiankaOZlozeniuOpiniiBieglegoRewidentaSprawozdaniaZBadania")]
    public List<Wzmianka> WzmiankaOZlozeniuOpiniiBieglegoRewidentaSprawozdaniaZBadania { get; set; }

    /// <summary>
    /// Gets or Sets WzmiankaOZlozeniuSkonsolidowanegoRocznegoSprawozdaniaFinansowego
    /// </summary>
    [DataMember(Name="wzmiankaOZlozeniuSkonsolidowanegoRocznegoSprawozdaniaFinansowego", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "wzmiankaOZlozeniuSkonsolidowanegoRocznegoSprawozdaniaFinansowego")]
    public List<Wzmianka> WzmiankaOZlozeniuSkonsolidowanegoRocznegoSprawozdaniaFinansowego { get; set; }

    /// <summary>
    /// Gets or Sets WzmiankaOZlozeniuSkonsolidowanegoSprawozdaniaZPlatnosciNaRzeczAdministracjiPublicznej
    /// </summary>
    [DataMember(Name="wzmiankaOZlozeniuSkonsolidowanegoSprawozdaniaZPlatnosciNaRzeczAdministracjiPublicznej", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "wzmiankaOZlozeniuSkonsolidowanegoSprawozdaniaZPlatnosciNaRzeczAdministracjiPublicznej")]
    public List<Wzmianka> WzmiankaOZlozeniuSkonsolidowanegoSprawozdaniaZPlatnosciNaRzeczAdministracjiPublicznej { get; set; }

    /// <summary>
    /// Gets or Sets WzmiankaOZlozeniuSprawozdaniaZDzialalnosciSpolkiDominujacej
    /// </summary>
    [DataMember(Name="wzmiankaOZlozeniuSprawozdaniaZDzialalnosciSpolkiDominujacej", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "wzmiankaOZlozeniuSprawozdaniaZDzialalnosciSpolkiDominujacej")]
    public List<Wzmianka> WzmiankaOZlozeniuSprawozdaniaZDzialalnosciSpolkiDominujacej { get; set; }

    /// <summary>
    /// Gets or Sets WzmiankaOZlozeniuUchwalyPostanowieniaOZatwierdzeniuSkonsolidowanegoRocznegoSprawozdaniaFinansowego
    /// </summary>
    [DataMember(Name="wzmiankaOZlozeniuUchwalyPostanowieniaOZatwierdzeniuSkonsolidowanegoRocznegoSprawozdaniaFinansowego", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "wzmiankaOZlozeniuUchwalyPostanowieniaOZatwierdzeniuSkonsolidowanegoRocznegoSprawozdaniaFinansowego")]
    public List<Wzmianka> WzmiankaOZlozeniuUchwalyPostanowieniaOZatwierdzeniuSkonsolidowanegoRocznegoSprawozdaniaFinansowego { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SprawozdaniaGrupyKapitalowej {\n");
      sb.Append("  WzmiankaOZlozeniuOpiniiBieglegoRewidentaSprawozdaniaZBadania: ").Append(WzmiankaOZlozeniuOpiniiBieglegoRewidentaSprawozdaniaZBadania).Append("\n");
      sb.Append("  WzmiankaOZlozeniuSkonsolidowanegoRocznegoSprawozdaniaFinansowego: ").Append(WzmiankaOZlozeniuSkonsolidowanegoRocznegoSprawozdaniaFinansowego).Append("\n");
      sb.Append("  WzmiankaOZlozeniuSkonsolidowanegoSprawozdaniaZPlatnosciNaRzeczAdministracjiPublicznej: ").Append(WzmiankaOZlozeniuSkonsolidowanegoSprawozdaniaZPlatnosciNaRzeczAdministracjiPublicznej).Append("\n");
      sb.Append("  WzmiankaOZlozeniuSprawozdaniaZDzialalnosciSpolkiDominujacej: ").Append(WzmiankaOZlozeniuSprawozdaniaZDzialalnosciSpolkiDominujacej).Append("\n");
      sb.Append("  WzmiankaOZlozeniuUchwalyPostanowieniaOZatwierdzeniuSkonsolidowanegoRocznegoSprawozdaniaFinansowego: ").Append(WzmiankaOZlozeniuUchwalyPostanowieniaOZatwierdzeniuSkonsolidowanegoRocznegoSprawozdaniaFinansowego).Append("\n");
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
