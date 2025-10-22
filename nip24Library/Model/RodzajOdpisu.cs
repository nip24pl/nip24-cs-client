using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.InteropServices;

namespace NIP24.Model
{
    /// <summary>
    /// Defines RodzajOdpisu
    /// </summary>
	[Guid("7D5CBAF6-EC6F-41AA-B5FE-0097F20B6D4F")]
    [ComVisible(true)]
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RodzajOdpisu
    {
        /// <summary>
        /// Enum Peny for value: Pełny
        /// </summary>
        [EnumMember(Value = "Pełny")]
        Pelny = 1,
        /// <summary>
        /// Enum Aktualny for value: Aktualny
        /// </summary>
        [EnumMember(Value = "Aktualny")]
        Aktualny = 2
    }
}
