using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.Runtime.InteropServices;

namespace NIP24.Model {

    #region interface

    [Guid("5EC257CB-7BF0-46DA-9266-778ECC5D897F")]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [ComVisible(true)]
    public interface IOsoba
    {
        /// <summary>
        /// Gets or Sets Nazwisko
        /// </summary>
        [DispId(1)]
        NazwiskoOsoby Nazwisko { get; set; }

        /// <summary>
        /// Gets or Sets Imiona
        /// </summary>
        [DispId(2)]
        ImionaOsoby Imiona { get; set; }

        /// <summary>
        /// Gets or Sets Identyfikator
        /// </summary>
        [DispId(3)]
        IdentyfikatorOsoby Identyfikator { get; set; }

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
    [Guid("63D8F5F9-61D6-460D-A741-C00400D5D7EA")]
    [ClassInterface(ClassInterfaceType.None)]
    [ComVisible(true)]
    [DataContract]
    public class Osoba : IOsoba
    {
        /// <summary>
        /// Gets or Sets Nazwisko
        /// </summary>
        [DataMember(Name = "nazwisko", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "nazwisko")]
        public NazwiskoOsoby Nazwisko { get; set; }

        /// <summary>
        /// Gets or Sets Imiona
        /// </summary>
        [DataMember(Name = "imiona", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "imiona")]
        public ImionaOsoby Imiona { get; set; }

        /// <summary>
        /// Gets or Sets Identyfikator
        /// </summary>
        [DataMember(Name = "identyfikator", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "identyfikator")]
        public IdentyfikatorOsoby Identyfikator { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Osoba {\n");
            sb.Append("  Nazwisko: ").Append(Nazwisko).Append("\n");
            sb.Append("  Imiona: ").Append(Imiona).Append("\n");
            sb.Append("  Identyfikator: ").Append(Identyfikator).Append("\n");
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
