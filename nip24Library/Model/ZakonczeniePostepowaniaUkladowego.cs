using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.Runtime.InteropServices;

namespace NIP24.Model {

    #region interface

    [Guid("335F132C-6061-4ECC-BB4F-30400DE7C568")]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [ComVisible(true)]
    public interface IZakonczeniePostepowaniaUkladowego
    {
        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DispId(1)]
        string Data { get; set; }

        /// <summary>
        /// Gets or Sets Opis
        /// </summary>
        [DispId(2)]
        string Opis { get; set; }

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
    [Guid("40D32EAA-BDF0-4304-A170-34564D8CA550")]
    [ClassInterface(ClassInterfaceType.None)]
    [ComVisible(true)]
    [DataContract]
    public class ZakonczeniePostepowaniaUkladowego : IZakonczeniePostepowaniaUkladowego
    {
        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "data")]
        public string Data { get; set; }

        /// <summary>
        /// Gets or Sets Opis
        /// </summary>
        [DataMember(Name = "opis", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "opis")]
        public string Opis { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ZakonczeniePostepowaniaUkladowego {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Opis: ").Append(Opis).Append("\n");
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
