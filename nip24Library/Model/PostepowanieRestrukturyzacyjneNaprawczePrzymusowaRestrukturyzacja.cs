using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.Runtime.InteropServices;

namespace NIP24.Model {

    #region interface

    [Guid("B8266A20-7FAA-436F-8F21-CD9C37AD4A1A")]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [ComVisible(true)]
    public interface IPostepowanieRestrukturyzacyjneNaprawczePrzymusowaRestrukturyzacja
    {
        /// <summary>
        /// Gets or Sets UchylenieUkladu
        /// </summary>
        [DispId(1)]
        UchylenieUkladu UchylenieUkladu { get; set; }

        /// <summary>
        /// Gets or Sets OtwarciePostepowaniaRestrukturyzacyjnegoNaprawczegoPrzymusowejRestrukturyzacji
        /// </summary>
        [DispId(2)]
        OtwarciePostepowaniaRestrukturyzacyjnegoNaprawczegoPrzymusowejRestrukturyzacji OtwarciePostepowaniaRestrukturyzacyjnegoNaprawczegoPrzymusowejRestrukturyzacji { get; set; }

        /// <summary>
        /// Gets or Sets ZakonczeniePostepowaniaRestrukturyzacyjnegoNaprawczegoPrzymusowejRestrukturyzacji
        /// </summary>
        [DispId(3)]
        ZakonczeniePostepowaniaRestrukturyzacyjnegoNaprawczegoPrzymusowejRestrukturyzacji ZakonczeniePostepowaniaRestrukturyzacyjnegoNaprawczegoPrzymusowejRestrukturyzacji { get; set; }

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
    [Guid("63CA0C11-D84D-45C6-A847-1CF019EE5C75")]
    [ClassInterface(ClassInterfaceType.None)]
    [ComVisible(true)]
    [DataContract]
    public class PostepowanieRestrukturyzacyjneNaprawczePrzymusowaRestrukturyzacja : IPostepowanieRestrukturyzacyjneNaprawczePrzymusowaRestrukturyzacja
    {
        /// <summary>
        /// Gets or Sets UchylenieUkladu
        /// </summary>
        [DataMember(Name = "uchylenieUkladu", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "uchylenieUkladu")]
        public UchylenieUkladu UchylenieUkladu { get; set; }

        /// <summary>
        /// Gets or Sets OtwarciePostepowaniaRestrukturyzacyjnegoNaprawczegoPrzymusowejRestrukturyzacji
        /// </summary>
        [DataMember(Name = "otwarciePostepowaniaRestrukturyzacyjnegoNaprawczegoPrzymusowejRestrukturyzacji", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "otwarciePostepowaniaRestrukturyzacyjnegoNaprawczegoPrzymusowejRestrukturyzacji")]
        public OtwarciePostepowaniaRestrukturyzacyjnegoNaprawczegoPrzymusowejRestrukturyzacji OtwarciePostepowaniaRestrukturyzacyjnegoNaprawczegoPrzymusowejRestrukturyzacji { get; set; }

        /// <summary>
        /// Gets or Sets ZakonczeniePostepowaniaRestrukturyzacyjnegoNaprawczegoPrzymusowejRestrukturyzacji
        /// </summary>
        [DataMember(Name = "zakonczeniePostepowaniaRestrukturyzacyjnegoNaprawczegoPrzymusowejRestrukturyzacji", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "zakonczeniePostepowaniaRestrukturyzacyjnegoNaprawczegoPrzymusowejRestrukturyzacji")]
        public ZakonczeniePostepowaniaRestrukturyzacyjnegoNaprawczegoPrzymusowejRestrukturyzacji ZakonczeniePostepowaniaRestrukturyzacyjnegoNaprawczegoPrzymusowejRestrukturyzacji { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString() {
            var sb = new StringBuilder();
            sb.Append("class PostepowanieRestrukturyzacyjneNaprawczePrzymusowaRestrukturyzacja {\n");
            sb.Append("  UchylenieUkladu: ").Append(UchylenieUkladu).Append("\n");
            sb.Append("  OtwarciePostepowaniaRestrukturyzacyjnegoNaprawczegoPrzymusowejRestrukturyzacji: ").Append(OtwarciePostepowaniaRestrukturyzacyjnegoNaprawczegoPrzymusowejRestrukturyzacji).Append("\n");
            sb.Append("  ZakonczeniePostepowaniaRestrukturyzacyjnegoNaprawczegoPrzymusowejRestrukturyzacji: ").Append(ZakonczeniePostepowaniaRestrukturyzacyjnegoNaprawczegoPrzymusowejRestrukturyzacji).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Get the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson() {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }

    #endregion
}
