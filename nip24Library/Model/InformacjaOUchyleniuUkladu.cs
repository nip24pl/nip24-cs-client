using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.Runtime.InteropServices;

namespace NIP24.Model {

    #region interface

    [Guid("B7E0D91C-A800-495F-B216-F5D234B5CFE4")]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [ComVisible(true)]
    public interface IInformacjaOUchyleniuUkladu
    {
        /// <summary>
        /// Gets or Sets Pole1
        /// </summary>
        [DispId(1)]
        string Pole1 { get; set; }

        /// <summary>
        /// Gets or Sets Pole2
        /// </summary>
        [DispId(2)]
        string Pole2 { get; set; }

        /// <summary>
        /// Gets or Sets Pole3
        /// </summary>
        [DispId(3)]
        string Pole3 { get; set; }

        /// <summary>
        /// Gets or Sets Pole4
        /// </summary>
        [DispId(4)]
        string Pole4 { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        [DispId(5)]
        string ToString();
    }

    #endregion

    #region implementation

    /// <summary>
    /// 
    /// </summary>
    [Guid("1A767D59-D170-402B-8CC6-2D09A166DFCF")]
    [ClassInterface(ClassInterfaceType.None)]
    [ComVisible(true)]
    [DataContract]
    public class InformacjaOUchyleniuUkladu : IInformacjaOUchyleniuUkladu
    {
        /// <summary>
        /// Gets or Sets Pole1
        /// </summary>
        [DataMember(Name = "pole1", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pole1")]
        public string Pole1 { get; set; }

        /// <summary>
        /// Gets or Sets Pole2
        /// </summary>
        [DataMember(Name = "pole2", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pole2")]
        public string Pole2 { get; set; }

        /// <summary>
        /// Gets or Sets Pole3
        /// </summary>
        [DataMember(Name = "pole3", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pole3")]
        public string Pole3 { get; set; }

        /// <summary>
        /// Gets or Sets Pole4
        /// </summary>
        [DataMember(Name = "pole4", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pole4")]
        public string Pole4 { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InformacjaOUchyleniuUkladu {\n");
            sb.Append("  pole1: ").Append(Pole1).Append("\n");
            sb.Append("  pole2: ").Append(Pole2).Append("\n");
            sb.Append("  pole3: ").Append(Pole3).Append("\n");
            sb.Append("  pole4: ").Append(Pole4).Append("\n");
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
