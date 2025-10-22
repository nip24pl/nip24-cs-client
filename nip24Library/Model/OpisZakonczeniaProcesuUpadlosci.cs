using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.Runtime.InteropServices;

namespace NIP24.Model {

    #region interface

    [Guid("F35B2583-F0F5-41FA-9B04-E2F3EC082F2C")]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [ComVisible(true)]
    public interface IOpisZakonczeniaProcesuUpadlosci
    {
        /// <summary>
        /// Gets or Sets OpisSposobuZakonczeniaPostepowania
        /// </summary>
        [DispId(1)]
        string OpisSposobuZakonczeniaPostepowania { get; set; }

        /// <summary>
        /// Gets or Sets DataZakonczeniaPostepowania
        /// </summary>
        [DispId(2)]
        string DataZakonczeniaPostepowania { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        [DispId(3)]
        string ToString();
    }

    #endregion

    #region implementation

    /// <summary>
    /// 
    /// </summary>
    [Guid("69A44020-846C-49AE-A297-7073DFB75D97")]
    [ClassInterface(ClassInterfaceType.None)]
    [ComVisible(true)]
    [DataContract]
    public class OpisZakonczeniaProcesuUpadlosci : IOpisZakonczeniaProcesuUpadlosci
    {
        /// <summary>
        /// Gets or Sets OpisSposobuZakonczeniaPostepowania
        /// </summary>
        [DataMember(Name = "opisSposobuZakonczeniaPostepowania", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "opisSposobuZakonczeniaPostepowania")]
        public string OpisSposobuZakonczeniaPostepowania { get; set; }

        /// <summary>
        /// Gets or Sets DataZakonczeniaPostepowania
        /// </summary>
        [DataMember(Name = "dataZakonczeniaPostepowania", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "dataZakonczeniaPostepowania")]
        public string DataZakonczeniaPostepowania { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OpisZakonczeniaProcesuUpadlosci {\n");
            sb.Append("  OpisSposobuZakonczeniaPostepowania: ").Append(OpisSposobuZakonczeniaPostepowania).Append("\n");
            sb.Append("  DataZakonczeniaPostepowania: ").Append(DataZakonczeniaPostepowania).Append("\n");
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
