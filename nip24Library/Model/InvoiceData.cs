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
  public class InvoiceData {
    /// <summary>
    /// Gets or Sets Uid
    /// </summary>
    [DataMember(Name="uid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "uid")]
    public string Uid { get; set; }

    /// <summary>
    /// Gets or Sets Nip
    /// </summary>
    [DataMember(Name="nip", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nip")]
    public string Nip { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Firstname
    /// </summary>
    [DataMember(Name="firstname", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "firstname")]
    public string Firstname { get; set; }

    /// <summary>
    /// Gets or Sets Lastname
    /// </summary>
    [DataMember(Name="lastname", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastname")]
    public string Lastname { get; set; }

    /// <summary>
    /// Gets or Sets Street
    /// </summary>
    [DataMember(Name="street", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "street")]
    public string Street { get; set; }

    /// <summary>
    /// Gets or Sets StreetNumber
    /// </summary>
    [DataMember(Name="streetNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "streetNumber")]
    public string StreetNumber { get; set; }

    /// <summary>
    /// Gets or Sets HouseNumber
    /// </summary>
    [DataMember(Name="houseNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "houseNumber")]
    public string HouseNumber { get; set; }

    /// <summary>
    /// Gets or Sets City
    /// </summary>
    [DataMember(Name="city", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "city")]
    public string City { get; set; }

    /// <summary>
    /// Gets or Sets PostCode
    /// </summary>
    [DataMember(Name="postCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "postCode")]
    public string PostCode { get; set; }

    /// <summary>
    /// Gets or Sets PostCity
    /// </summary>
    [DataMember(Name="postCity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "postCity")]
    public string PostCity { get; set; }

    /// <summary>
    /// Gets or Sets Phone
    /// </summary>
    [DataMember(Name="phone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "phone")]
    public string Phone { get; set; }

    /// <summary>
    /// Gets or Sets Email
    /// </summary>
    [DataMember(Name="email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email")]
    public string Email { get; set; }

    /// <summary>
    /// Gets or Sets Www
    /// </summary>
    [DataMember(Name="www", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "www")]
    public string Www { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class InvoiceData {\n");
      sb.Append("  Uid: ").Append(Uid).Append("\n");
      sb.Append("  Nip: ").Append(Nip).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Firstname: ").Append(Firstname).Append("\n");
      sb.Append("  Lastname: ").Append(Lastname).Append("\n");
      sb.Append("  Street: ").Append(Street).Append("\n");
      sb.Append("  StreetNumber: ").Append(StreetNumber).Append("\n");
      sb.Append("  HouseNumber: ").Append(HouseNumber).Append("\n");
      sb.Append("  City: ").Append(City).Append("\n");
      sb.Append("  PostCode: ").Append(PostCode).Append("\n");
      sb.Append("  PostCity: ").Append(PostCity).Append("\n");
      sb.Append("  Phone: ").Append(Phone).Append("\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
      sb.Append("  Www: ").Append(Www).Append("\n");
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
