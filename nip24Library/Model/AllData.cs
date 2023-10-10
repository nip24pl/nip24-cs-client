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
  public class AllData : InvoiceData {
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Gets or Sets Regon
    /// </summary>
    [DataMember(Name="regon", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "regon")]
    public string Regon { get; set; }

    /// <summary>
    /// Gets or Sets Shortname
    /// </summary>
    [DataMember(Name="shortname", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shortname")]
    public string Shortname { get; set; }

    /// <summary>
    /// Gets or Sets Secondname
    /// </summary>
    [DataMember(Name="secondname", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "secondname")]
    public string Secondname { get; set; }

    /// <summary>
    /// Gets or Sets StreetCode
    /// </summary>
    [DataMember(Name="streetCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "streetCode")]
    public string StreetCode { get; set; }

    /// <summary>
    /// Gets or Sets CityCode
    /// </summary>
    [DataMember(Name="cityCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cityCode")]
    public string CityCode { get; set; }

    /// <summary>
    /// Gets or Sets Community
    /// </summary>
    [DataMember(Name="community", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "community")]
    public string Community { get; set; }

    /// <summary>
    /// Gets or Sets CommunityCode
    /// </summary>
    [DataMember(Name="communityCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "communityCode")]
    public string CommunityCode { get; set; }

    /// <summary>
    /// Gets or Sets County
    /// </summary>
    [DataMember(Name="county", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "county")]
    public string County { get; set; }

    /// <summary>
    /// Gets or Sets CountyCode
    /// </summary>
    [DataMember(Name="countyCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "countyCode")]
    public string CountyCode { get; set; }

    /// <summary>
    /// Gets or Sets State
    /// </summary>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public string State { get; set; }

    /// <summary>
    /// Gets or Sets StateCode
    /// </summary>
    [DataMember(Name="stateCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stateCode")]
    public string StateCode { get; set; }

    /// <summary>
    /// Gets or Sets CreationDate
    /// </summary>
    [DataMember(Name="creationDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "creationDate")]
    public DateTime? CreationDate { get; set; }

    /// <summary>
    /// Gets or Sets StartDate
    /// </summary>
    [DataMember(Name="startDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "startDate")]
    public DateTime? StartDate { get; set; }

    /// <summary>
    /// Gets or Sets RegistrationDate
    /// </summary>
    [DataMember(Name="registrationDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "registrationDate")]
    public DateTime? RegistrationDate { get; set; }

    /// <summary>
    /// Gets or Sets HoldDate
    /// </summary>
    [DataMember(Name="holdDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "holdDate")]
    public DateTime? HoldDate { get; set; }

    /// <summary>
    /// Gets or Sets RenevalDate
    /// </summary>
    [DataMember(Name="renevalDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "renevalDate")]
    public DateTime? RenevalDate { get; set; }

    /// <summary>
    /// Gets or Sets LastUpdateDate
    /// </summary>
    [DataMember(Name="lastUpdateDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastUpdateDate")]
    public DateTime? LastUpdateDate { get; set; }

    /// <summary>
    /// Gets or Sets EndDate
    /// </summary>
    [DataMember(Name="endDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "endDate")]
    public DateTime? EndDate { get; set; }

    /// <summary>
    /// Gets or Sets RegistryEntity
    /// </summary>
    [DataMember(Name="registryEntity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "registryEntity")]
    public AllDataEntity RegistryEntity { get; set; }

    /// <summary>
    /// Gets or Sets Registry
    /// </summary>
    [DataMember(Name="registry", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "registry")]
    public AllDataEntity Registry { get; set; }

    /// <summary>
    /// Gets or Sets Record
    /// </summary>
    [DataMember(Name="record", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "record")]
    public AllDataRecord Record { get; set; }

    /// <summary>
    /// Gets or Sets BasicLegalForm
    /// </summary>
    [DataMember(Name="basicLegalForm", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "basicLegalForm")]
    public AllDataEntity BasicLegalForm { get; set; }

    /// <summary>
    /// Gets or Sets SpecificLegalForm
    /// </summary>
    [DataMember(Name="specificLegalForm", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "specificLegalForm")]
    public AllDataEntity SpecificLegalForm { get; set; }

    /// <summary>
    /// Gets or Sets OwnershipForm
    /// </summary>
    [DataMember(Name="ownershipForm", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ownershipForm")]
    public AllDataEntity OwnershipForm { get; set; }

    /// <summary>
    /// Gets or Sets PKDs
    /// </summary>
    [DataMember(Name="PKDs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PKDs")]
    public List<PKD> PKDs { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AllData {\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Regon: ").Append(Regon).Append("\n");
      sb.Append("  Shortname: ").Append(Shortname).Append("\n");
      sb.Append("  Secondname: ").Append(Secondname).Append("\n");
      sb.Append("  StreetCode: ").Append(StreetCode).Append("\n");
      sb.Append("  CityCode: ").Append(CityCode).Append("\n");
      sb.Append("  Community: ").Append(Community).Append("\n");
      sb.Append("  CommunityCode: ").Append(CommunityCode).Append("\n");
      sb.Append("  County: ").Append(County).Append("\n");
      sb.Append("  CountyCode: ").Append(CountyCode).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  StateCode: ").Append(StateCode).Append("\n");
      sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
      sb.Append("  StartDate: ").Append(StartDate).Append("\n");
      sb.Append("  RegistrationDate: ").Append(RegistrationDate).Append("\n");
      sb.Append("  HoldDate: ").Append(HoldDate).Append("\n");
      sb.Append("  RenevalDate: ").Append(RenevalDate).Append("\n");
      sb.Append("  LastUpdateDate: ").Append(LastUpdateDate).Append("\n");
      sb.Append("  EndDate: ").Append(EndDate).Append("\n");
      sb.Append("  RegistryEntity: ").Append(RegistryEntity).Append("\n");
      sb.Append("  Registry: ").Append(Registry).Append("\n");
      sb.Append("  Record: ").Append(Record).Append("\n");
      sb.Append("  BasicLegalForm: ").Append(BasicLegalForm).Append("\n");
      sb.Append("  SpecificLegalForm: ").Append(SpecificLegalForm).Append("\n");
      sb.Append("  OwnershipForm: ").Append(OwnershipForm).Append("\n");
      sb.Append("  PKDs: ").Append(PKDs).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public  new string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
