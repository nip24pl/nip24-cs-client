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
  public class Dzial4 {
    /// <summary>
    /// Gets or Sets ZabezpieczenieMajatkuOddalenieWnioskuOUpadlosc
    /// </summary>
    [DataMember(Name="zabezpieczenieMajatkuOddalenieWnioskuOUpadlosc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "zabezpieczenieMajatkuOddalenieWnioskuOUpadlosc")]
    public List<ZabezpieczenieMajatkuOddalenieWnioskuOUpadlosc> ZabezpieczenieMajatkuOddalenieWnioskuOUpadlosc { get; set; }

    /// <summary>
    /// Gets or Sets Zaleglosci
    /// </summary>
    [DataMember(Name="zaleglosci", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "zaleglosci")]
    public List<Zaleglosci> Zaleglosci { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Dzial4 {\n");
      sb.Append("  ZabezpieczenieMajatkuOddalenieWnioskuOUpadlosc: ").Append(ZabezpieczenieMajatkuOddalenieWnioskuOUpadlosc).Append("\n");
      sb.Append("  Zaleglosci: ").Append(Zaleglosci).Append("\n");
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
