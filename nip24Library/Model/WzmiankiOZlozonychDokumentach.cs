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
  public class WzmiankiOZlozonychDokumentach {
    /// <summary>
    /// Gets or Sets WzmiankaOZlozeniuOpiniiBieglegoRewidentaSprawozdaniaZBadania
    /// </summary>
    [DataMember(Name="wzmiankaOZlozeniuOpiniiBieglegoRewidentaSprawozdaniaZBadania", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "wzmiankaOZlozeniuOpiniiBieglegoRewidentaSprawozdaniaZBadania")]
    public List<Wzmianka> WzmiankaOZlozeniuOpiniiBieglegoRewidentaSprawozdaniaZBadania { get; set; }

    /// <summary>
    /// Gets or Sets WzmiankaOZlozeniuRocznegoSprawozdaniaFinansowego
    /// </summary>
    [DataMember(Name="wzmiankaOZlozeniuRocznegoSprawozdaniaFinansowego", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "wzmiankaOZlozeniuRocznegoSprawozdaniaFinansowego")]
    public List<Wzmianka> WzmiankaOZlozeniuRocznegoSprawozdaniaFinansowego { get; set; }

    /// <summary>
    /// Gets or Sets WzmiankaOZlozeniuUchwalyPostanowieniaOZatwierdzeniuRocznegoSprawozdaniaFinansowego
    /// </summary>
    [DataMember(Name="wzmiankaOZlozeniuUchwalyPostanowieniaOZatwierdzeniuRocznegoSprawozdaniaFinansowego", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "wzmiankaOZlozeniuUchwalyPostanowieniaOZatwierdzeniuRocznegoSprawozdaniaFinansowego")]
    public List<Wzmianka> WzmiankaOZlozeniuUchwalyPostanowieniaOZatwierdzeniuRocznegoSprawozdaniaFinansowego { get; set; }

    /// <summary>
    /// Gets or Sets WzmiankaOZlozeniuSprawozdaniaZDzialalnosci
    /// </summary>
    [DataMember(Name="wzmiankaOZlozeniuSprawozdaniaZDzialalnosci", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "wzmiankaOZlozeniuSprawozdaniaZDzialalnosci")]
    public List<Wzmianka> WzmiankaOZlozeniuSprawozdaniaZDzialalnosci { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class WzmiankiOZlozonychDokumentach {\n");
      sb.Append("  WzmiankaOZlozeniuOpiniiBieglegoRewidentaSprawozdaniaZBadania: ").Append(WzmiankaOZlozeniuOpiniiBieglegoRewidentaSprawozdaniaZBadania).Append("\n");
      sb.Append("  WzmiankaOZlozeniuRocznegoSprawozdaniaFinansowego: ").Append(WzmiankaOZlozeniuRocznegoSprawozdaniaFinansowego).Append("\n");
      sb.Append("  WzmiankaOZlozeniuUchwalyPostanowieniaOZatwierdzeniuRocznegoSprawozdaniaFinansowego: ").Append(WzmiankaOZlozeniuUchwalyPostanowieniaOZatwierdzeniuRocznegoSprawozdaniaFinansowego).Append("\n");
      sb.Append("  WzmiankaOZlozeniuSprawozdaniaZDzialalnosci: ").Append(WzmiankaOZlozeniuSprawozdaniaZDzialalnosci).Append("\n");
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
