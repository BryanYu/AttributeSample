using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AttributeSample.Attributes;

namespace AttributeSample.Enums
{
    /// <summary>The message type.</summary>
    public enum MessageType
    {
        /// <summary>The mail.</summary>
        [Alias("電子郵件")]
        Mail,

        /// <summary>The sms.</summary>
        [Alias("簡訊")]
        Sms,

        /// <summary>The line.</summary>
        [Alias("Line訊息")]
        Line,
    }
}