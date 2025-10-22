using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.Runtime.InteropServices;

namespace NIP24.Model {

    #region interface

    [Guid("5299435B-8209-41D6-A453-AC0E1E6352C3")]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [ComVisible(true)]
    public interface IOtwarciePostepowaniaRestrukturyzacyjnegoNaprawczegoPrzymusowejRestrukturyzacji
    {
        /// <summary>
        /// Gets or Sets OrganWydajacy
        /// </summary>
        [DispId(1)]
        string OrganWydajacy { get; set; }

        /// <summary>
        /// Gets or Sets Sygnatura
        /// </summary>
        [DispId(2)]
        string Sygnatura { get; set; }

        /// <summary>
        /// Gets or Sets DataNadaniaKlauzuliWykonalnosci
        /// </summary>
        [DispId(3)]
        string DataNadaniaKlauzuliWykonalnosci { get; set; }

        /// <summary>
        /// Gets or Sets RodzajPostepowania
        /// </summary>
        [DispId(4)]
        string RodzajPostepowania { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        [DispId(5)]
        string ToString();
    }

    #endregion

    #region implementation

    /// <summary>
    /// 
    /// </summary>
    [Guid("B2909B2A-5442-45D2-8E88-D853BDA5F80C")]
    [ClassInterface(ClassInterfaceType.None)]
    [ComVisible(true)]
    [DataContract]
    public class OtwarciePostepowaniaRestrukturyzacyjnegoNaprawczegoPrzymusowejRestrukturyzacji : IOtwarciePostepowaniaRestrukturyzacyjnegoNaprawczegoPrzymusowejRestrukturyzacji
    {
        /// <summary>
        /// Gets or Sets OrganWydajacy
        /// </summary>
        [DataMember(Name = "organWydajacy", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "organWydajacy")]
        public string OrganWydajacy { get; set; }

        /// <summary>
        /// Gets or Sets Sygnatura
        /// </summary>
        [DataMember(Name = "sygnatura", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sygnatura")]
        public string Sygnatura { get; set; }

        /// <summary>
        /// Gets or Sets DataNadaniaKlauzuliWykonalnosci
        /// </summary>
        [DataMember(Name = "dataNadaniaKlauzuliWykonalnosci", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "dataNadaniaKlauzuliWykonalnosci")]
        public string DataNadaniaKlauzuliWykonalnosci { get; set; }

        /// <summary>
        /// Gets or Sets RodzajPostepowania
        /// </summary>
        [DataMember(Name = "rodzajPostepowania", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "rodzajPostepowania")]
        public string RodzajPostepowania { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OtwarciePostepowaniaRestrukturyzacyjnegoNaprawczegoPrzymusowejRestrukturyzacji {\n");
            sb.Append("  OrganWydajacy: ").Append(OrganWydajacy).Append("\n");
            sb.Append("  Sygnatura: ").Append(Sygnatura).Append("\n");
            sb.Append("  DataNadaniaKlauzuliWykonalnosci: ").Append(DataNadaniaKlauzuliWykonalnosci).Append("\n");
            sb.Append("  RodzajPostepowania: ").Append(RodzajPostepowania).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Get the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }

    #endregion
}
