using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.Runtime.InteropServices;

namespace NIP24.Model {

    #region interface

    [Guid("67E213C7-68EF-47F4-B8C8-51C084DAFC3A")]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [ComVisible(true)]
    public interface IUchylenieUkladu
    {
        /// <summary>
        /// Gets or Sets OrganUchylajacy
        /// </summary>
        [DispId(1)]
        string OrganUchylajacy { get; set; }

        /// <summary>
        /// Gets or Sets DataUchylenia
        /// </summary>
        [DispId(2)]
        string DataUchylenia { get; set; }

        /// <summary>
        /// Gets or Sets Sygnatura
        /// </summary>
        [DispId(3)]
        string Sygnatura { get; set; }

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
    [Guid("806A5B01-9D4D-4284-BD38-AE5E596A38DF")]
    [ClassInterface(ClassInterfaceType.None)]
    [ComVisible(true)]
    [DataContract]
    public class UchylenieUkladu : IUchylenieUkladu
    {
        /// <summary>
        /// Gets or Sets OrganUchylajacy
        /// </summary>
        [DataMember(Name = "organUchylajacy", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "organUchylajacy")]
        public string OrganUchylajacy { get; set; }

        /// <summary>
        /// Gets or Sets DataUchylenia
        /// </summary>
        [DataMember(Name = "dataUchylenia", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "dataUchylenia")]
        public string DataUchylenia { get; set; }

        /// <summary>
        /// Gets or Sets Sygnatura
        /// </summary>
        [DataMember(Name = "sygnatura", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sygnatura")]
        public string Sygnatura { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UchylenieUkladu {\n");
            sb.Append("  OrganUchylajacy: ").Append(OrganUchylajacy).Append("\n");
            sb.Append("  DataUchylenia: ").Append(DataUchylenia).Append("\n");
            sb.Append("  Sygnatura: ").Append(Sygnatura).Append("\n");
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
