using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace NIP24.Model
{
    #region interface

    /// <summary>
    /// Dane firmy pobrane z rejestru KRS
    /// </summary>
    [Guid("8F90CA00-7EB3-40DF-BB1D-B2BAC0FAB657")]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [ComVisible(true)]
    public interface IKRSData
    {
        /// <summary>
        /// Unikalny identyfikator odpowiedzi
        /// </summary>
        [DispId(1)]
        string UID { get; set; }

        /// <summary>
        /// Dane z rejestru KRS
        /// </summary>
        [DispId(2)]
        Odpis Data { get; set; }

        /// <summary>
        /// Identyfikator odpowiedzi z rejestru KRS (obecnie brak)
        /// </summary>
        [DispId(3)]
        string ID { get; set; }

        /// <summary>
        /// Data pobrania danych
        /// </summary>
        [DispId(4)]
        DateTime Date { get; set; }

        /// <summary>
        /// èrÛd≥o danych
        /// </summary>
        [DispId(5)]
        string Source { get; set; }

        [DispId(6)]
        string ToString();
    }

    #endregion

    #region implementation

    /// <summary>
    /// Dane firmy pobrane z rejestru KRS
    /// </summary>
    [Guid("C191ED45-B595-419A-9D86-56B571B78DB8")]
    [ClassInterface(ClassInterfaceType.None)]
    [ComVisible(true)]
    [DataContract]
    public class KRSData :IKRSData
    {
        /// <summary>
        /// Unikalny identyfikator odpowiedzi
        /// </summary>
        [DataMember(Name = "uid", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "uid")]
        public string UID { get; set; }

        /// <summary>
        /// Dane z rejestru KRS
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "data")]
        public Odpis Data { get; set; }

        /// <summary>
        /// Identyfikator odpowiedzi z rejestru KRS (obecnie brak)
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id")]
        public string ID { get; set; }

        /// <summary>
        /// Data pobrania danych
        /// </summary>
        [DataMember(Name = "date", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "date")]
        [ComVisible(false)]
        public DateTime? Date { get; set; }

        /// <summary>
        /// Data pobrania danych
        /// </summary>
        DateTime IKRSData.Date
        {
            get { return Date ?? DateTime.MinValue; }
            set { Date = value; }
        }

        /// <summary>
        /// èrÛd≥o danych
        /// </summary>
        [DataMember(Name = "source", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "source")]
        public string Source { get; set; }

        /// <summary>
		/// Tworzy nowy, pusty obiekt
		/// </summary>
		public KRSData()
        {
        }

        public override string ToString()
        {
            return "KRSData: [uid = " + UID
                + ", data = " + Data
                + ", id = " + ID
                + ", date = " + Date
                + ", source = " + Source
                + "]";
        }
    }

    #endregion
}
