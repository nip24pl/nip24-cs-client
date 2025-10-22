using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.Runtime.InteropServices;

namespace NIP24.Model {

    #region interface

    /// <summary>
    /// 
    /// </summary>
    [Guid("ECCC5106-4EC0-4FDE-AC94-D23CB7337A90")]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [ComVisible(true)]
    public interface IInformacjaOOgloszeniuUpadlosci
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
        /// Gets or Sets Data
        /// </summary>
        [DispId(3)]
        string Data { get; set; }

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
    [Guid("A8E9CD4B-BABE-46D1-BDE8-76A51C255B97")]
    [ClassInterface(ClassInterfaceType.None)]
    [ComVisible(true)]
    [DataContract]
    public class InformacjaOOgloszeniuUpadlosci : IInformacjaOOgloszeniuUpadlosci
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
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "data")]
        public string Data { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InformacjaOOgloszeniuUpadlosci {\n");
            sb.Append("  OrganWydajacy: ").Append(OrganWydajacy).Append("\n");
            sb.Append("  Sygnatura: ").Append(Sygnatura).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
