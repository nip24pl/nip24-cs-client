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
    /// Defines Rejestr
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
        public enum Rejestr
    {
        /// <summary>
        /// Enum RejP for value: RejP
        /// </summary>
        [EnumMember(Value = "RejP")]
        RejP = 1,
        /// <summary>
        /// Enum RejS for value: RejS
        /// </summary>
        [EnumMember(Value = "RejS")]
        RejS = 2    }
}
