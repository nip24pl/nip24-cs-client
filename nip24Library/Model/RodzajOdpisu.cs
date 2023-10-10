using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace NIP24.Model
{
    /// <summary>
    /// Defines RodzajOdpisu
    /// </summary>
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
        Aktualny = 2    }
}
