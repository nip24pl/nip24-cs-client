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
  public class PrzedmiotDzialalnosci {
    /// <summary>
    /// Gets or Sets PrzedmiotPrzewazajacejDzialalnosci
    /// </summary>
    [DataMember(Name="przedmiotPrzewazajacejDzialalnosci", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "przedmiotPrzewazajacejDzialalnosci")]
    public List<Dzialalnosci> PrzedmiotPrzewazajacejDzialalnosci { get; set; }

    /// <summary>
    /// Gets or Sets PrzedmiotPozostalejDzialalnosci
    /// </summary>
    [DataMember(Name="przedmiotPozostalejDzialalnosci", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "przedmiotPozostalejDzialalnosci")]
    public List<Dzialalnosci> PrzedmiotPozostalejDzialalnosci { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PrzedmiotDzialalnosci {\n");
      sb.Append("  PrzedmiotPrzewazajacejDzialalnosci: ").Append(PrzedmiotPrzewazajacejDzialalnosci).Append("\n");
      sb.Append("  PrzedmiotPozostalejDzialalnosci: ").Append(PrzedmiotPozostalejDzialalnosci).Append("\n");
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
