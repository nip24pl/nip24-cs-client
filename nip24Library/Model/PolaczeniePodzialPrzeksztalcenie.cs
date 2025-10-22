using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.Runtime.InteropServices;

namespace NIP24.Model {

    #region interface

    [Guid("600457CA-0DC6-4A36-97EC-40BEC4FD9F45")]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [ComVisible(true)]
    public interface IPolaczeniePodzialPrzeksztalcenie
    {
        /// <summary>
        /// Gets or Sets OkreslenieOkolicznosci
        /// </summary>
        [DispId(1)]
        string OkreslenieOkolicznosci { get; set; }

        /// <summary>
        /// Gets or Sets OpisPolaczeniaPodzialuPrzeksztalcenia
        /// </summary>
        [DispId(2)]
        string OpisPolaczeniaPodzialuPrzeksztalcenia { get; set; }

        /// <summary>
        /// Gets or Sets PodmiotyPrzejmowane
        /// </summary>
        [DispId(3)]
        Podmioty[] PodmiotyPrzejmowane { get; set; }

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
    [Guid("BE03CD0A-E8B5-4C3A-97C0-189D240F4550")]
    [ClassInterface(ClassInterfaceType.None)]
    [ComVisible(true)]
    [DataContract]
    public class PolaczeniePodzialPrzeksztalcenie : IPolaczeniePodzialPrzeksztalcenie
    {
        /// <summary>
        /// Gets or Sets OkreslenieOkolicznosci
        /// </summary>
        [DataMember(Name = "okreslenieOkolicznosci", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "okreslenieOkolicznosci")]
        public string OkreslenieOkolicznosci { get; set; }

        /// <summary>
        /// Gets or Sets OpisPolaczeniaPodzialuPrzeksztalcenia
        /// </summary>
        [DataMember(Name = "opisPolaczeniaPodzialuPrzeksztalcenia", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "opisPolaczeniaPodzialuPrzeksztalcenia")]
        public string OpisPolaczeniaPodzialuPrzeksztalcenia { get; set; }

        /// <summary>
        /// Gets or Sets PodmiotyPrzejmowane
        /// </summary>
        [DataMember(Name = "podmiotyPrzejmowane", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "podmiotyPrzejmowane")]
        [ComVisible(false)]
        public List<Podmioty> PodmiotyPrzejmowane { get; set; }

        Podmioty[] IPolaczeniePodzialPrzeksztalcenie.PodmiotyPrzejmowane
        {
            get { return PodmiotyPrzejmowane.ToArray(); }
            set { PodmiotyPrzejmowane = new List<Podmioty>(value); }
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PolaczeniePodzialPrzeksztalcenie {\n");
            sb.Append("  OkreslenieOkolicznosci: ").Append(OkreslenieOkolicznosci).Append("\n");
            sb.Append("  OpisPolaczeniaPodzialuPrzeksztalcenia: ").Append(OpisPolaczeniaPodzialuPrzeksztalcenia).Append("\n");
            sb.Append("  PodmiotyPrzejmowane: ").Append(PodmiotyPrzejmowane).Append("\n");
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
