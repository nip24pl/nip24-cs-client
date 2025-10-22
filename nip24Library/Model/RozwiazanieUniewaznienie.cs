using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.Runtime.InteropServices;

namespace NIP24.Model {

    #region interface

    [Guid("607844DF-12FA-48AD-8092-7A077775125C")]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [ComVisible(true)]
    public interface IRozwiazanieUniewaznienie
    {
        /// <summary>
        /// Gets or Sets OkreslenieOkolicznosci
        /// </summary>
        [DispId(1)]
        string OkreslenieOkolicznosci { get; set; }

        /// <summary>
        /// Gets or Sets InformacjaORozwiazaniuUniewaznieniu
        /// </summary>
        [DispId(2)]
        string InformacjaORozwiazaniuUniewaznieniu { get; set; }

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
    [Guid("84F2C139-48C0-4A6C-94C8-E251402D2530")]
    [ClassInterface(ClassInterfaceType.None)]
    [ComVisible(true)]
    [DataContract]
    public class RozwiazanieUniewaznienie : IRozwiazanieUniewaznienie
    {
        /// <summary>
        /// Gets or Sets OkreslenieOkolicznosci
        /// </summary>
        [DataMember(Name = "okreslenieOkolicznosci", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "okreslenieOkolicznosci")]
        public string OkreslenieOkolicznosci { get; set; }

        /// <summary>
        /// Gets or Sets InformacjaORozwiazaniuUniewaznieniu
        /// </summary>
        [DataMember(Name = "informacjaORozwiazaniuUniewaznieniu", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "informacjaORozwiazaniuUniewaznieniu")]
        public string InformacjaORozwiazaniuUniewaznieniu { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RozwiazanieUniewaznienie {\n");
            sb.Append("  OkreslenieOkolicznosci: ").Append(OkreslenieOkolicznosci).Append("\n");
            sb.Append("  InformacjaORozwiazaniuUniewaznieniu: ").Append(InformacjaORozwiazaniuUniewaznieniu).Append("\n");
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
