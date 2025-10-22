using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.Runtime.InteropServices;

namespace NIP24.Model {

    #region interface

    [Guid("6B8A6C42-85C1-4935-9AF9-8A48A39B0EA2")]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [ComVisible(true)]
    public interface IPodmioty
    {
        /// <summary>
        /// Gets or Sets Nazwa
        /// </summary>
        [DispId(1)]
        string Nazwa { get; set; }

        /// <summary>
        /// Gets or Sets KrajNazwaRejestruEwidencji
        /// </summary>
        [DispId(2)]
        string KrajNazwaRejestruEwidencji { get; set; }

        /// <summary>
        /// Gets or Sets NumerWRejestrzeAlboEwidencji
        /// </summary>
        [DispId(3)]
        string NumerWRejestrzeAlboEwidencji { get; set; }

        /// <summary>
        /// Gets or Sets NazwaSaduOrganuProwadzacegoRejestrEwidencje
        /// </summary>
        [DispId(4)]
        string NazwaSaduOrganuProwadzacegoRejestrEwidencje { get; set; }

        /// <summary>
        /// Gets or Sets Identyfikatory
        /// </summary>
        [DispId(5)]
        IdentyfikatoryPodmiotu Identyfikatory { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        [DispId(6)]
        string ToString();
    }

    #endregion

    #region implementation

    /// <summary>
    /// 
    /// </summary>
    [Guid("FED837BC-8491-48D3-A753-D08853C1EBC6")]
    [ClassInterface(ClassInterfaceType.None)]
    [ComVisible(true)]
    [DataContract]
    public class Podmioty : IPodmioty
    {
        /// <summary>
        /// Gets or Sets Nazwa
        /// </summary>
        [DataMember(Name = "nazwa", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "nazwa")]
        public string Nazwa { get; set; }

        /// <summary>
        /// Gets or Sets KrajNazwaRejestruEwidencji
        /// </summary>
        [DataMember(Name = "krajNazwaRejestruEwidencji", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "krajNazwaRejestruEwidencji")]
        public string KrajNazwaRejestruEwidencji { get; set; }

        /// <summary>
        /// Gets or Sets NumerWRejestrzeAlboEwidencji
        /// </summary>
        [DataMember(Name = "numerWRejestrzeAlboEwidencji", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "numerWRejestrzeAlboEwidencji")]
        public string NumerWRejestrzeAlboEwidencji { get; set; }

        /// <summary>
        /// Gets or Sets NazwaSaduOrganuProwadzacegoRejestrEwidencje
        /// </summary>
        [DataMember(Name = "nazwaSaduOrganuProwadzacegoRejestrEwidencje", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "nazwaSaduOrganuProwadzacegoRejestrEwidencje")]
        public string NazwaSaduOrganuProwadzacegoRejestrEwidencje { get; set; }

        /// <summary>
        /// Gets or Sets Identyfikatory
        /// </summary>
        [DataMember(Name = "identyfikatory", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "identyfikatory")]
        public IdentyfikatoryPodmiotu Identyfikatory { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Podmioty {\n");
            sb.Append("  Nazwa: ").Append(Nazwa).Append("\n");
            sb.Append("  KrajNazwaRejestruEwidencji: ").Append(KrajNazwaRejestruEwidencji).Append("\n");
            sb.Append("  NumerWRejestrzeAlboEwidencji: ").Append(NumerWRejestrzeAlboEwidencji).Append("\n");
            sb.Append("  NazwaSaduOrganuProwadzacegoRejestrEwidencje: ").Append(NazwaSaduOrganuProwadzacegoRejestrEwidencje).Append("\n");
            sb.Append("  Identyfikatory: ").Append(Identyfikatory).Append("\n");
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
