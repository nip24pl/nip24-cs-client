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
  public class VATPerson {
    /// <summary>
    /// Gets or Sets CompanyName
    /// </summary>
    [DataMember(Name="companyName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "companyName")]
    public string CompanyName { get; set; }

    /// <summary>
    /// Gets or Sets FirstName
    /// </summary>
    [DataMember(Name="firstName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "firstName")]
    public string FirstName { get; set; }

    /// <summary>
    /// Gets or Sets LastName
    /// </summary>
    [DataMember(Name="lastName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastName")]
    public string LastName { get; set; }

    /// <summary>
    /// Gets or Sets Nip
    /// </summary>
    [DataMember(Name="nip", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nip")]
    public string Nip { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class VATPerson {\n");
      sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
      sb.Append("  FirstName: ").Append(FirstName).Append("\n");
      sb.Append("  LastName: ").Append(LastName).Append("\n");
      sb.Append("  Nip: ").Append(Nip).Append("\n");
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
