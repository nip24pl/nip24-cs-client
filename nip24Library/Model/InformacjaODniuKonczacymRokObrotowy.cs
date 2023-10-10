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
  public class InformacjaODniuKonczacymRokObrotowy {
    /// <summary>
    /// Gets or Sets DzienKonczacyPierwszyRokObrotowy
    /// </summary>
    [DataMember(Name="dzienKonczacyPierwszyRokObrotowy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dzienKonczacyPierwszyRokObrotowy")]
    public string DzienKonczacyPierwszyRokObrotowy { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class InformacjaODniuKonczacymRokObrotowy {\n");
      sb.Append("  DzienKonczacyPierwszyRokObrotowy: ").Append(DzienKonczacyPierwszyRokObrotowy).Append("\n");
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
