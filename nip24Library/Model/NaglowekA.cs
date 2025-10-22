using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.Runtime.InteropServices;

namespace NIP24.Model {

    #region interface

    [Guid("C6F920AE-0366-4DAD-A5A8-3DD198C20D6E")]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [ComVisible(true)]
    public interface INaglowekA
    {
        /// <summary>
        /// Gets or Sets Rejestr
        /// </summary>
        [DispId(1)]
        Rejestr Rejestr { get; set; }

        /// <summary>
        /// Gets or Sets NumerKRS
        /// </summary>
        [DispId(2)]
        string NumerKRS { get; set; }

        /// <summary>
        /// Gets or Sets DataCzasOdpisu
        /// </summary>
        [DispId(3)]
        string DataCzasOdpisu { get; set; }

        /// <summary>
        /// Gets or Sets StanZDnia
        /// </summary>
        [DispId(4)]
        string StanZDnia { get; set; }

        /// <summary>
        /// Gets or Sets DataRejestracjiWKRS
        /// </summary>
        [DispId(5)]
        string DataRejestracjiWKRS { get; set; }

        /// <summary>
        /// Gets or Sets NumerOstatniegoWpisu
        /// </summary>
        [DispId(6)]
        int NumerOstatniegoWpisu { get; set; }

        /// <summary>
        /// Gets or Sets DataOstatniegoWpisu
        /// </summary>
        [DispId(7)]
        string DataOstatniegoWpisu { get; set; }

        /// <summary>
        /// Gets or Sets SygnaturaAktSprawyDotyczacejOstatniegoWpisu
        /// </summary>
        [DispId(8)]
        string SygnaturaAktSprawyDotyczacejOstatniegoWpisu { get; set; }

        /// <summary>
        /// Gets or Sets OznaczenieSaduDokonujacegoOstatniegoWpisu
        /// </summary>
        [DispId(9)]
        string OznaczenieSaduDokonujacegoOstatniegoWpisu { get; set; }

        /// <summary>
        /// Gets or Sets StanPozycji
        /// </summary>
        [DispId(10)]
        int StanPozycji { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        [DispId(11)] 
        string ToString();
    }

    #endregion

    #region implementation

    /// <summary>
    /// 
    /// </summary>
    [Guid("6CBF82B7-BF00-45BD-B89A-355CA786EB99")]
    [ClassInterface(ClassInterfaceType.None)]
    [ComVisible(true)]
    [DataContract]
    public class NaglowekA : INaglowekA
    {
        /// <summary>
        /// Gets or Sets Rejestr
        /// </summary>
        [DataMember(Name = "rejestr", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "rejestr")]
        public Rejestr Rejestr { get; set; }

        /// <summary>
        /// Gets or Sets NumerKRS
        /// </summary>
        [DataMember(Name = "numerKRS", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "numerKRS")]
        public string NumerKRS { get; set; }

        /// <summary>
        /// Gets or Sets DataCzasOdpisu
        /// </summary>
        [DataMember(Name = "dataCzasOdpisu", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "dataCzasOdpisu")]
        public string DataCzasOdpisu { get; set; }

        /// <summary>
        /// Gets or Sets StanZDnia
        /// </summary>
        [DataMember(Name = "stanZDnia", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "stanZDnia")]
        public string StanZDnia { get; set; }

        /// <summary>
        /// Gets or Sets DataRejestracjiWKRS
        /// </summary>
        [DataMember(Name = "dataRejestracjiWKRS", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "dataRejestracjiWKRS")]
        public string DataRejestracjiWKRS { get; set; }

        /// <summary>
        /// Gets or Sets NumerOstatniegoWpisu
        /// </summary>
        [DataMember(Name = "numerOstatniegoWpisu", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "numerOstatniegoWpisu")]
        [ComVisible(false)]
        public int? NumerOstatniegoWpisu { get; set; }

        int INaglowekA.NumerOstatniegoWpisu
        {
            get { return NumerOstatniegoWpisu ?? -1; }
            set { NumerOstatniegoWpisu = value; }
        }

        /// <summary>
        /// Gets or Sets DataOstatniegoWpisu
        /// </summary>
        [DataMember(Name = "dataOstatniegoWpisu", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "dataOstatniegoWpisu")]
        public string DataOstatniegoWpisu { get; set; }

        /// <summary>
        /// Gets or Sets SygnaturaAktSprawyDotyczacejOstatniegoWpisu
        /// </summary>
        [DataMember(Name = "sygnaturaAktSprawyDotyczacejOstatniegoWpisu", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sygnaturaAktSprawyDotyczacejOstatniegoWpisu")]
        public string SygnaturaAktSprawyDotyczacejOstatniegoWpisu { get; set; }

        /// <summary>
        /// Gets or Sets OznaczenieSaduDokonujacegoOstatniegoWpisu
        /// </summary>
        [DataMember(Name = "oznaczenieSaduDokonujacegoOstatniegoWpisu", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "oznaczenieSaduDokonujacegoOstatniegoWpisu")]
        public string OznaczenieSaduDokonujacegoOstatniegoWpisu { get; set; }

        /// <summary>
        /// Gets or Sets StanPozycji
        /// </summary>
        [DataMember(Name = "stanPozycji", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "stanPozycji")]
        [ComVisible(false)]
        public int? StanPozycji { get; set; }

        int INaglowekA.StanPozycji
        {
            get { return StanPozycji ?? -1; }
            set { StanPozycji = value; }
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NaglowekA {\n");
            sb.Append("  Rejestr: ").Append(Rejestr).Append("\n");
            sb.Append("  NumerKRS: ").Append(NumerKRS).Append("\n");
            sb.Append("  DataCzasOdpisu: ").Append(DataCzasOdpisu).Append("\n");
            sb.Append("  StanZDnia: ").Append(StanZDnia).Append("\n");
            sb.Append("  DataRejestracjiWKRS: ").Append(DataRejestracjiWKRS).Append("\n");
            sb.Append("  NumerOstatniegoWpisu: ").Append(NumerOstatniegoWpisu).Append("\n");
            sb.Append("  DataOstatniegoWpisu: ").Append(DataOstatniegoWpisu).Append("\n");
            sb.Append("  SygnaturaAktSprawyDotyczacejOstatniegoWpisu: ").Append(SygnaturaAktSprawyDotyczacejOstatniegoWpisu).Append("\n");
            sb.Append("  OznaczenieSaduDokonujacegoOstatniegoWpisu: ").Append(OznaczenieSaduDokonujacegoOstatniegoWpisu).Append("\n");
            sb.Append("  StanPozycji: ").Append(StanPozycji).Append("\n");
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
