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
  public class VATEntity {
    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Nip
    /// </summary>
    [DataMember(Name="nip", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nip")]
    public string Nip { get; set; }

    /// <summary>
    /// Gets or Sets Regon
    /// </summary>
    [DataMember(Name="regon", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "regon")]
    public string Regon { get; set; }

    /// <summary>
    /// Gets or Sets Krs
    /// </summary>
    [DataMember(Name="krs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "krs")]
    public string Krs { get; set; }

    /// <summary>
    /// Gets or Sets ResidenceAddress
    /// </summary>
    [DataMember(Name="residenceAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "residenceAddress")]
    public string ResidenceAddress { get; set; }

    /// <summary>
    /// Gets or Sets WorkingAddress
    /// </summary>
    [DataMember(Name="workingAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "workingAddress")]
    public string WorkingAddress { get; set; }

    /// <summary>
    /// Gets or Sets Vat
    /// </summary>
    [DataMember(Name="vat", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vat")]
    public VATEntityStatus Vat { get; set; }

    /// <summary>
    /// Gets or Sets Representatives
    /// </summary>
    [DataMember(Name="representatives", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "representatives")]
    public List<VATPerson> Representatives { get; set; }

    /// <summary>
    /// Gets or Sets AuthorizedClerks
    /// </summary>
    [DataMember(Name="authorizedClerks", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "authorizedClerks")]
    public List<VATPerson> AuthorizedClerks { get; set; }

    /// <summary>
    /// Gets or Sets Partners
    /// </summary>
    [DataMember(Name="partners", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "partners")]
    public List<VATPerson> Partners { get; set; }

    /// <summary>
    /// Gets or Sets Ibans
    /// </summary>
    [DataMember(Name="ibans", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ibans")]
    public List<string> Ibans { get; set; }

    /// <summary>
    /// Gets or Sets HasVirtualAccounts
    /// </summary>
    [DataMember(Name="hasVirtualAccounts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hasVirtualAccounts")]
    public bool? HasVirtualAccounts { get; set; }

    /// <summary>
    /// Gets or Sets RegistrationLegalDate
    /// </summary>
    [DataMember(Name="registrationLegalDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "registrationLegalDate")]
    public DateTime? RegistrationLegalDate { get; set; }

    /// <summary>
    /// Gets or Sets RegistrationDenialDate
    /// </summary>
    [DataMember(Name="registrationDenialDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "registrationDenialDate")]
    public DateTime? RegistrationDenialDate { get; set; }

    /// <summary>
    /// Gets or Sets RegistrationDenialBasis
    /// </summary>
    [DataMember(Name="registrationDenialBasis", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "registrationDenialBasis")]
    public string RegistrationDenialBasis { get; set; }

    /// <summary>
    /// Gets or Sets RestorationDate
    /// </summary>
    [DataMember(Name="restorationDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "restorationDate")]
    public DateTime? RestorationDate { get; set; }

    /// <summary>
    /// Gets or Sets RestorationBasis
    /// </summary>
    [DataMember(Name="restorationBasis", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "restorationBasis")]
    public string RestorationBasis { get; set; }

    /// <summary>
    /// Gets or Sets RemovalDate
    /// </summary>
    [DataMember(Name="removalDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "removalDate")]
    public DateTime? RemovalDate { get; set; }

    /// <summary>
    /// Gets or Sets RemovalBasis
    /// </summary>
    [DataMember(Name="removalBasis", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "removalBasis")]
    public string RemovalBasis { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class VATEntity {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Nip: ").Append(Nip).Append("\n");
      sb.Append("  Regon: ").Append(Regon).Append("\n");
      sb.Append("  Krs: ").Append(Krs).Append("\n");
      sb.Append("  ResidenceAddress: ").Append(ResidenceAddress).Append("\n");
      sb.Append("  WorkingAddress: ").Append(WorkingAddress).Append("\n");
      sb.Append("  Vat: ").Append(Vat).Append("\n");
      sb.Append("  Representatives: ").Append(Representatives).Append("\n");
      sb.Append("  AuthorizedClerks: ").Append(AuthorizedClerks).Append("\n");
      sb.Append("  Partners: ").Append(Partners).Append("\n");
      sb.Append("  Ibans: ").Append(Ibans).Append("\n");
      sb.Append("  HasVirtualAccounts: ").Append(HasVirtualAccounts).Append("\n");
      sb.Append("  RegistrationLegalDate: ").Append(RegistrationLegalDate).Append("\n");
      sb.Append("  RegistrationDenialDate: ").Append(RegistrationDenialDate).Append("\n");
      sb.Append("  RegistrationDenialBasis: ").Append(RegistrationDenialBasis).Append("\n");
      sb.Append("  RestorationDate: ").Append(RestorationDate).Append("\n");
      sb.Append("  RestorationBasis: ").Append(RestorationBasis).Append("\n");
      sb.Append("  RemovalDate: ").Append(RemovalDate).Append("\n");
      sb.Append("  RemovalBasis: ").Append(RemovalBasis).Append("\n");
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
