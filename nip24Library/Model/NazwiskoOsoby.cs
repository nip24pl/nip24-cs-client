using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.Runtime.InteropServices;

namespace NIP24.Model {

    #region interface

    [Guid("33C8C69E-B8D0-4B69-B4B4-B479A386BA0B")]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [ComVisible(true)]
    public interface INazwiskoOsoby
    {
        /// <summary>
        /// Gets or Sets NazwiskoICzlon
        /// </summary>
        [DispId(1)]
        string NazwiskoICzlon { get; set; }

        /// <summary>
        /// Gets or Sets NazwiskoIICzlon
        /// </summary>
        [DispId(2)]
        string NazwiskoIICzlon { get; set; }

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
    [Guid("0CE0D7A2-3812-4B03-85B4-3786CA4D5704")]
    [ClassInterface(ClassInterfaceType.None)]
    [ComVisible(true)]
    [DataContract]
    public class NazwiskoOsoby : INazwiskoOsoby
    {
        /// <summary>
        /// Gets or Sets NazwiskoICzlon
        /// </summary>
        [DataMember(Name = "nazwiskoICzlon", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "nazwiskoICzlon")]
        public string NazwiskoICzlon { get; set; }

        /// <summary>
        /// Gets or Sets NazwiskoIICzlon
        /// </summary>
        [DataMember(Name = "nazwiskoIICzlon", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "nazwiskoIICzlon")]
        public string NazwiskoIICzlon { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NazwiskoOsoby {\n");
            sb.Append("  NazwiskoICzlon: ").Append(NazwiskoICzlon).Append("\n");
            sb.Append("  NazwiskoIICzlon: ").Append(NazwiskoIICzlon).Append("\n");
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
