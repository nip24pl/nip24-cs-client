using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.Runtime.InteropServices;

namespace NIP24.Model {

    #region interface

    [Guid("656F7011-25C0-4A19-800F-398429E661FE")]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [ComVisible(true)]
    public interface IPostepowanieUpadlosciowe
    {
        /// <summary>
        /// Gets or Sets SposobProwadzeniaPostepowania
        /// </summary>
        [DispId(1)]
        string SposobProwadzeniaPostepowania { get; set; }

        /// <summary>
        /// Gets or Sets InformacjaOUchyleniuUkladu
        /// </summary>
        [DispId(2)]
        InformacjaOUchyleniuUkladu InformacjaOUchyleniuUkladu { get; set; }

        /// <summary>
        /// Gets or Sets InformacjaOOgloszeniuUpadlosci
        /// </summary>
        [DispId(3)]
        InformacjaOOgloszeniuUpadlosci InformacjaOOgloszeniuUpadlosci { get; set; }

        /// <summary>
        /// Gets or Sets OpisZakonczeniaProcesuUpadlosci
        /// </summary>
        [DispId(4)]
        OpisZakonczeniaProcesuUpadlosci OpisZakonczeniaProcesuUpadlosci { get; set; }

        /// <summary>
        /// Gets or Sets DaneSyndyka
        /// </summary>
        [DispId(5)]
        DaneSyndyka[] DaneSyndyka { get; set; }

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
    [Guid("5C79823E-B8C5-4C69-8A31-2FBB9F45BF56")]
    [ClassInterface(ClassInterfaceType.None)]
    [ComVisible(true)]
    [DataContract]
    public class PostepowanieUpadlosciowe : IPostepowanieUpadlosciowe
    {
        /// <summary>
        /// Gets or Sets SposobProwadzeniaPostepowania
        /// </summary>
        [DataMember(Name = "sposobProwadzeniaPostepowania", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sposobProwadzeniaPostepowania")]
        public string SposobProwadzeniaPostepowania { get; set; }

        /// <summary>
        /// Gets or Sets InformacjaOUchyleniuUkladu
        /// </summary>
        [DataMember(Name = "informacjaOUchyleniuUkladu", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "informacjaOUchyleniuUkladu")]
        public InformacjaOUchyleniuUkladu InformacjaOUchyleniuUkladu { get; set; }

        /// <summary>
        /// Gets or Sets InformacjaOOgloszeniuUpadlosci
        /// </summary>
        [DataMember(Name = "informacjaOOgloszeniuUpadlosci", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "informacjaOOgloszeniuUpadlosci")]
        public InformacjaOOgloszeniuUpadlosci InformacjaOOgloszeniuUpadlosci { get; set; }

        /// <summary>
        /// Gets or Sets OpisZakonczeniaProcesuUpadlosci
        /// </summary>
        [DataMember(Name = "opisZakonczeniaProcesuUpadlosci", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "opisZakonczeniaProcesuUpadlosci")]
        public OpisZakonczeniaProcesuUpadlosci OpisZakonczeniaProcesuUpadlosci { get; set; }

        /// <summary>
        /// Gets or Sets DaneSyndyka
        /// </summary>
        [DataMember(Name = "daneSyndyka", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "daneSyndyka")]
        [ComVisible(false)]
        public List<DaneSyndyka> DaneSyndyka { get; set; }

        DaneSyndyka[] IPostepowanieUpadlosciowe.DaneSyndyka
        {
            get { return DaneSyndyka.ToArray(); }
            set { DaneSyndyka = new List<DaneSyndyka>(value); }
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostepowanieUpadlosciowe {\n");
            sb.Append("  SposobProwadzeniaPostepowania: ").Append(SposobProwadzeniaPostepowania).Append("\n");
            sb.Append("  InformacjaOUchyleniuUkladu: ").Append(InformacjaOUchyleniuUkladu).Append("\n");
            sb.Append("  InformacjaOOgloszeniuUpadlosci: ").Append(InformacjaOOgloszeniuUpadlosci).Append("\n");
            sb.Append("  OpisZakonczeniaProcesuUpadlosci: ").Append(OpisZakonczeniaProcesuUpadlosci).Append("\n");
            sb.Append("  DaneSyndyka: ").Append(DaneSyndyka).Append("\n");
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
