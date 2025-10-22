using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.Runtime.InteropServices;

namespace NIP24.Model {

    #region interface

    [Guid("88785136-A903-471C-B1CC-1CEA873E8551")]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [ComVisible(true)]
    public interface IIdentyfikatorOsoby
    {
        /// <summary>
        /// Gets or Sets Pesel
        /// </summary>
        [DispId(1)]
        string Pesel { get; set; }

        /// <summary>
        /// Gets or Sets NumerPaszportu
        /// </summary>
        [DispId(2)]
        string NumerPaszportu { get; set; }

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
    [Guid("E3E782B9-FBDD-4206-8216-A534133968B9")]
    [ClassInterface(ClassInterfaceType.None)]
    [ComVisible(true)]
    [DataContract]
    public class IdentyfikatorOsoby : IIdentyfikatorOsoby
    {
        /// <summary>
        /// Gets or Sets Pesel
        /// </summary>
        [DataMember(Name = "pesel", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pesel")]
        public string Pesel { get; set; }

        /// <summary>
        /// Gets or Sets NumerPaszportu
        /// </summary>
        [DataMember(Name = "numerPaszportu", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "numerPaszportu")]
        public string NumerPaszportu { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IdentyfikatorOsoby {\n");
            sb.Append("  Pesel: ").Append(Pesel).Append("\n");
            sb.Append("  NumerPaszportu: ").Append(NumerPaszportu).Append("\n");
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
