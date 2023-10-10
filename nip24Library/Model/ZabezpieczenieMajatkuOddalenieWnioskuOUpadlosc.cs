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
  public class ZabezpieczenieMajatkuOddalenieWnioskuOUpadlosc {
    /// <summary>
    /// Gets or Sets OddalenieWnioskuOUpadlosc
    /// </summary>
    [DataMember(Name="oddalenieWnioskuOUpadlosc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "oddalenieWnioskuOUpadlosc")]
    public string OddalenieWnioskuOUpadlosc { get; set; }

    /// <summary>
    /// Gets or Sets DalszePelnienieFunkcjiPoUkonczeniuPostepowaniaRestrukturyzacyjnego
    /// </summary>
    [DataMember(Name="dalszePelnienieFunkcjiPoUkonczeniuPostepowaniaRestrukturyzacyjnego", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dalszePelnienieFunkcjiPoUkonczeniuPostepowaniaRestrukturyzacyjnego")]
    public string DalszePelnienieFunkcjiPoUkonczeniuPostepowaniaRestrukturyzacyjnego { get; set; }

    /// <summary>
    /// Gets or Sets ZabezpieczenieMajatkuDluznikaWPostepowaniuUpadlosciowym
    /// </summary>
    [DataMember(Name="zabezpieczenieMajatkuDluznikaWPostepowaniuUpadlosciowym", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "zabezpieczenieMajatkuDluznikaWPostepowaniuUpadlosciowym")]
    public ZabezpieczenieMajatkuDluznikaWPostepowaniuUpadlosciowym ZabezpieczenieMajatkuDluznikaWPostepowaniuUpadlosciowym { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ZabezpieczenieMajatkuOddalenieWnioskuOUpadlosc {\n");
      sb.Append("  OddalenieWnioskuOUpadlosc: ").Append(OddalenieWnioskuOUpadlosc).Append("\n");
      sb.Append("  DalszePelnienieFunkcjiPoUkonczeniuPostepowaniaRestrukturyzacyjnego: ").Append(DalszePelnienieFunkcjiPoUkonczeniuPostepowaniaRestrukturyzacyjnego).Append("\n");
      sb.Append("  ZabezpieczenieMajatkuDluznikaWPostepowaniuUpadlosciowym: ").Append(ZabezpieczenieMajatkuDluznikaWPostepowaniuUpadlosciowym).Append("\n");
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
