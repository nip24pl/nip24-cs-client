using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.Runtime.InteropServices;

namespace NIP24.Model {

    #region interface

    [Guid("628E5A14-229B-4FEB-AAFF-D97C82A4A8AE")]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [ComVisible(true)]
    public interface IImionaOsoby
    {
        /// <summary>
        /// Gets or Sets Imie
        /// </summary>
        [DispId(1)]
        string Imie { get; set; }

        /// <summary>
        /// Gets or Sets ImieDrugie
        /// </summary>
        [DispId(2)]
        string ImieDrugie { get; set; }

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
    [Guid("72723F2D-D369-46DF-BDAF-13CCC1896182")]
    [ClassInterface(ClassInterfaceType.None)]
    [ComVisible(true)]
    [DataContract]
    public class ImionaOsoby : IImionaOsoby
    {
        /// <summary>
        /// Gets or Sets Imie
        /// </summary>
        [DataMember(Name = "imie", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "imie")]
        public string Imie { get; set; }

        /// <summary>
        /// Gets or Sets ImieDrugie
        /// </summary>
        [DataMember(Name = "imieDrugie", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "imieDrugie")]
        public string ImieDrugie { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImionaOsoby {\n");
            sb.Append("  Imie: ").Append(Imie).Append("\n");
            sb.Append("  ImieDrugie: ").Append(ImieDrugie).Append("\n");
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
