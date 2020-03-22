using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Text;

namespace NeoSmart.Data.Geographical
{
    static class ExtensionMethods
    {
        internal static T GetAttribute<T>(this Enum value)
            where T: Attribute
        {
            return value
                .GetType().GetTypeInfo()
                .GetDeclaredField(value.ToString())
                .GetCustomAttribute<T>();
        }
    }
}
