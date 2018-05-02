using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using AttributeSample.Attributes;

namespace AttributeSample.Extensions
{
    /// <summary>The attribute extension.</summary>
    public static class AttributeExtension
    {
        /// <summary>The get alias.</summary>
        /// <param name="type">The type.</param>
        /// <returns>The <see cref="string"/>.</returns>
        public static string GetAlias(this Enum type)
        {
            FieldInfo fi = type.GetType().GetField(type.ToString());
            var attribute = fi.GetCustomAttribute(typeof(AliasAttribute), false) as AliasAttribute;

            if (attribute != null)
            {
                return attribute.Alias;
            }

            return type.ToString();
        }
    }
}