using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.Runtime.InteropServices;

namespace NIP24.Model {

    #region interface

    [Guid("6AD28A27-9DA1-44BC-84B4-877CA03C6BD0")]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [ComVisible(true)]
    public interface IZawieszenieWznowienie
    {
        /// <summary>
        /// Gets or Sets DataZawieszenia
        /// </summary>
        [DispId(1)]
        string DataZawieszenia { get; set; }

        /// <summary>
        /// Gets or Sets DataWznowienia
        /// </summary>
        [DispId(2)]
        string DataWznowienia { get; set; }

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
    [Guid("D11ED33E-E932-4188-A481-6978968E7090")]
    [ClassInterface(ClassInterfaceType.None)]
    [ComVisible(true)]
    [DataContract]
    public class ZawieszenieWznowienie : IZawieszenieWznowienie
    {
        /// <summary>
        /// Gets or Sets DataZawieszenia
        /// </summary>
        [DataMember(Name = "dataZawieszenia", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "dataZawieszenia")]
        public string DataZawieszenia { get; set; }

        /// <summary>
        /// Gets or Sets DataWznowienia
        /// </summary>
        [DataMember(Name = "dataWznowienia", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "dataWznowienia")]
        public string DataWznowienia { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ZawieszenieWznowienie {\n");
            sb.Append("  DataZawieszenia: ").Append(DataZawieszenia).Append("\n");
            sb.Append("  DataWznowienia: ").Append(DataWznowienia).Append("\n");
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
