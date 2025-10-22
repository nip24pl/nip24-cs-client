using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.Runtime.InteropServices;

namespace NIP24.Model {

    #region interface

    [Guid("A2DDD1D5-B29A-46A7-A5CD-4FD1122AE314")]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [ComVisible(true)]
    public interface IDzial6
    {
        /// <summary>
        /// Gets or Sets PostepowanieUpadlosciowe
        /// </summary>
        [DispId(1)]
        PostepowanieUpadlosciowe[] PostepowanieUpadlosciowe { get; set; }

        /// <summary>
        /// Gets or Sets PolaczeniePodzialPrzeksztalcenie
        /// </summary>
        [DispId(2)]
        PolaczeniePodzialPrzeksztalcenie[] PolaczeniePodzialPrzeksztalcenie { get; set; }

        /// <summary>
        /// Gets or Sets Likwidacja
        /// </summary>
        [DispId(3)]
        Likwidacja[] Likwidacja { get; set; }

        /// <summary>
        /// Gets or Sets RozwiazanieUniewaznienie
        /// </summary>
        [DispId(4)]
        RozwiazanieUniewaznienie[] RozwiazanieUniewaznienie { get; set; }

        /// <summary>
        /// Gets or Sets ZawieszenieWznowienie
        /// </summary>
        [DispId(5)]
        ZawieszenieWznowienie[] ZawieszenieWznowienie { get; set; }

        /// <summary>
        /// Gets or Sets PostepowanieUkladowe
        /// </summary>
        [DispId(6)]
        PostepowanieUkladowe[] PostepowanieUkladowe { get; set; }

        /// <summary>
        /// Gets or Sets PostepowanieRestrukturyzacyjneNaprawczePrzymusowaRestrukturyzacja
        /// </summary>
        [DispId(7)]
        PostepowanieRestrukturyzacyjneNaprawczePrzymusowaRestrukturyzacja[] PostepowanieRestrukturyzacyjneNaprawczePrzymusowaRestrukturyzacja { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        [DispId(8)]
        string ToString();
    }

    #endregion

    #region implementation

    /// <summary>
    /// 
    /// </summary>
    [Guid("3713F2F2-C01F-4817-81B8-BD64CC65FBB4")]
    [ClassInterface(ClassInterfaceType.None)]
    [ComVisible(true)]
    [DataContract]
    public class Dzial6 : IDzial6
    {
        public Dzial6()
        {
            PostepowanieUpadlosciowe = new List<PostepowanieUpadlosciowe>();
            PolaczeniePodzialPrzeksztalcenie = new List<PolaczeniePodzialPrzeksztalcenie>();
            Likwidacja = new List<Likwidacja>();
            RozwiazanieUniewaznienie = new List<RozwiazanieUniewaznienie>();
            ZawieszenieWznowienie = new List<ZawieszenieWznowienie>();
            PostepowanieUkladowe = new List<PostepowanieUkladowe>();
            PostepowanieRestrukturyzacyjneNaprawczePrzymusowaRestrukturyzacja = new List<PostepowanieRestrukturyzacyjneNaprawczePrzymusowaRestrukturyzacja>();
        }

        /// <summary>
        /// Gets or Sets PostepowanieUpadlosciowe
        /// </summary>
        [DataMember(Name = "postepowanieUpadlosciowe", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "postepowanieUpadlosciowe")]
        [ComVisible(false)]
        public List<PostepowanieUpadlosciowe> PostepowanieUpadlosciowe { get; set; }

        PostepowanieUpadlosciowe[] IDzial6.PostepowanieUpadlosciowe
        {
            get { return PostepowanieUpadlosciowe.ToArray(); }
            set { PostepowanieUpadlosciowe = new List<PostepowanieUpadlosciowe>(value); }
        }

        /// <summary>
        /// Gets or Sets PolaczeniePodzialPrzeksztalcenie
        /// </summary>
        [DataMember(Name = "polaczeniePodzialPrzeksztalcenie", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "polaczeniePodzialPrzeksztalcenie")]
        [ComVisible(false)]
        public List<PolaczeniePodzialPrzeksztalcenie> PolaczeniePodzialPrzeksztalcenie { get; set; }

        PolaczeniePodzialPrzeksztalcenie[] IDzial6.PolaczeniePodzialPrzeksztalcenie
        {
            get { return PolaczeniePodzialPrzeksztalcenie.ToArray(); }
            set { PolaczeniePodzialPrzeksztalcenie = new List<PolaczeniePodzialPrzeksztalcenie>(value); }
        }

        /// <summary>
        /// Gets or Sets Likwidacja
        /// </summary>
        [DataMember(Name = "likwidacja", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "likwidacja")]
        [ComVisible(false)]
        public List<Likwidacja> Likwidacja { get; set; }

        Likwidacja[] IDzial6.Likwidacja
        {
            get { return Likwidacja.ToArray(); }
            set { Likwidacja = new List<Likwidacja>(value); }
        }

        /// <summary>
        /// Gets or Sets RozwiazanieUniewaznienie
        /// </summary>
        [DataMember(Name = "rozwiazanieUniewaznienie", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "rozwiazanieUniewaznienie")]
        [ComVisible(false)]
        public List<RozwiazanieUniewaznienie> RozwiazanieUniewaznienie { get; set; }

        RozwiazanieUniewaznienie[] IDzial6.RozwiazanieUniewaznienie
        {
            get { return RozwiazanieUniewaznienie.ToArray(); }
            set { RozwiazanieUniewaznienie = new List<RozwiazanieUniewaznienie>(value); }
        }

        /// <summary>
        /// Gets or Sets ZawieszenieWznowienie
        /// </summary>
        [DataMember(Name = "zawieszenieWznowienie", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "zawieszenieWznowienie")]
        [ComVisible(false)]
        public List<ZawieszenieWznowienie> ZawieszenieWznowienie { get; set; }

        ZawieszenieWznowienie[] IDzial6.ZawieszenieWznowienie
        {
            get { return ZawieszenieWznowienie.ToArray(); }
            set { ZawieszenieWznowienie = new List<ZawieszenieWznowienie>(value); }
        }

        /// <summary>
        /// Gets or Sets PostepowanieUkladowe
        /// </summary>
        [DataMember(Name = "postepowanieUkladowe", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "postepowanieUkladowe")]
        [ComVisible(false)]
        public List<PostepowanieUkladowe> PostepowanieUkladowe { get; set; }

        PostepowanieUkladowe[] IDzial6.PostepowanieUkladowe
        {
            get { return PostepowanieUkladowe.ToArray(); }
            set { PostepowanieUkladowe = new List<PostepowanieUkladowe>(value); }
        }

        /// <summary>
        /// Gets or Sets PostepowanieRestrukturyzacyjneNaprawczePrzymusowaRestrukturyzacja
        /// </summary>
        [DataMember(Name = "postepowanieRestrukturyzacyjneNaprawczePrzymusowaRestrukturyzacja", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "postepowanieRestrukturyzacyjneNaprawczePrzymusowaRestrukturyzacja")]
        [ComVisible(false)]
        public List<PostepowanieRestrukturyzacyjneNaprawczePrzymusowaRestrukturyzacja> PostepowanieRestrukturyzacyjneNaprawczePrzymusowaRestrukturyzacja { get; set; }

        PostepowanieRestrukturyzacyjneNaprawczePrzymusowaRestrukturyzacja[] IDzial6.PostepowanieRestrukturyzacyjneNaprawczePrzymusowaRestrukturyzacja
        {
            get { return PostepowanieRestrukturyzacyjneNaprawczePrzymusowaRestrukturyzacja.ToArray(); }
            set { PostepowanieRestrukturyzacyjneNaprawczePrzymusowaRestrukturyzacja = new List<PostepowanieRestrukturyzacyjneNaprawczePrzymusowaRestrukturyzacja>(value); }
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Dzial6 {\n");
            sb.Append("  PostepowanieUpadlosciowe: ").Append(PostepowanieUpadlosciowe).Append("\n");
            sb.Append("  PolaczeniePodzialPrzeksztalcenie: ").Append(PolaczeniePodzialPrzeksztalcenie).Append("\n");
            sb.Append("  Likwidacja: ").Append(Likwidacja).Append("\n");
            sb.Append("  RozwiazanieUniewaznienie: ").Append(RozwiazanieUniewaznienie).Append("\n");
            sb.Append("  ZawieszenieWznowienie: ").Append(ZawieszenieWznowienie).Append("\n");
            sb.Append("  PostepowanieUkladowe: ").Append(PostepowanieUkladowe).Append("\n");
            sb.Append("  PostepowanieRestrukturyzacyjneNaprawczePrzymusowaRestrukturyzacja: ").Append(PostepowanieRestrukturyzacyjneNaprawczePrzymusowaRestrukturyzacja).Append("\n");
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
