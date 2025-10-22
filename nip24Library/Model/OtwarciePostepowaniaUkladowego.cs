using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.Runtime.InteropServices;

namespace NIP24.Model {

    #region interface

    [Guid("89F48615-1B64-4CD2-BE19-180B68C2C3B2")]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [ComVisible(true)]
    public interface IOtwarciePostepowaniaUkladowego
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
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        [DispId(4)]
        string ToString();
    }

    #endregion

    #region implementation

    /// <summary>
    /// 
    /// </summary>
    [Guid("6FADF52C-05CE-431F-A07F-295B0F0D62DC")]
    [ClassInterface(ClassInterfaceType.None)]
    [ComVisible(true)]
    [DataContract]
    public class OtwarciePostepowaniaUkladowego : IOtwarciePostepowaniaUkladowego
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
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OtwarciePostepowaniaUkladowego {\n");
            sb.Append("  OrganWydajacy: ").Append(OrganWydajacy).Append("\n");
            sb.Append("  Sygnatura: ").Append(Sygnatura).Append("\n");
            sb.Append("  DataNadaniaKlauzuliWykonalnosci: ").Append(DataNadaniaKlauzuliWykonalnosci).Append("\n");
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
