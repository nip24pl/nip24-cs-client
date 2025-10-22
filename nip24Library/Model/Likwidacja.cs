using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.Runtime.InteropServices;

namespace NIP24.Model {

    #region interface

    [Guid("02059748-6518-49F4-A812-63F64B4DEF7E")]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [ComVisible(true)]
    public interface ILikwidacja
    {
        /// <summary>
        /// Gets or Sets OtwarcieLikwidacji
        /// </summary>
        [DispId(1)]
        string OtwarcieLikwidacji { get; set; }

        /// <summary>
        /// Gets or Sets SposobReprezentacjiPodmiotuPrzezLikwidatorow
        /// </summary>
        [DispId(2)]
        string SposobReprezentacjiPodmiotuPrzezLikwidatorow { get; set; }

        /// <summary>
        /// Gets or Sets Likwidatorzy
        /// </summary>
        [DispId(3)]
        Osoba[] Likwidatorzy { get; set; }

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
    [Guid("3F312951-DC34-4A3F-B450-1D59A139AD65")]
    [ClassInterface(ClassInterfaceType.None)]
    [ComVisible(true)]
    [DataContract]
    public class Likwidacja : ILikwidacja
    {
        /// <summary>
        /// Gets or Sets OtwarcieLikwidacji
        /// </summary>
        [DataMember(Name = "otwarcieLikwidacji", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "otwarcieLikwidacji")]
        public string OtwarcieLikwidacji { get; set; }

        /// <summary>
        /// Gets or Sets SposobReprezentacjiPodmiotuPrzezLikwidatorow
        /// </summary>
        [DataMember(Name = "sposobReprezentacjiPodmiotuPrzezLikwidatorow", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sposobReprezentacjiPodmiotuPrzezLikwidatorow")]
        public string SposobReprezentacjiPodmiotuPrzezLikwidatorow { get; set; }

        /// <summary>
        /// Gets or Sets Likwidatorzy
        /// </summary>
        [DataMember(Name = "likwidatorzy", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "likwidatorzy")]
        [ComVisible(false)]
        public List<Osoba> Likwidatorzy { get; set; }

        Osoba[] ILikwidacja.Likwidatorzy
        {
            get { return Likwidatorzy.ToArray(); }
            set { Likwidatorzy = new List<Osoba>(value); }
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Likwidacja {\n");
            sb.Append("  OtwarcieLikwidacji: ").Append(OtwarcieLikwidacji).Append("\n");
            sb.Append("  SposobReprezentacjiPodmiotuPrzezLikwidatorow: ").Append(SposobReprezentacjiPodmiotuPrzezLikwidatorow).Append("\n");
            sb.Append("  Likwidatorzy: ").Append(Likwidatorzy).Append("\n");
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
