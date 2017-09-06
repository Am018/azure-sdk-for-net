// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.StorSimple.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.StorSimple;
    using Microsoft.Azure.Management.StorSimple.Fluent;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for AuthenticationType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AuthenticationType
    {
        [EnumMember(Value = "Invalid")]
        Invalid,
        [EnumMember(Value = "None")]
        None,
        [EnumMember(Value = "Basic")]
        Basic,
        [EnumMember(Value = "NTLM")]
        NTLM
    }
    internal static class AuthenticationTypeEnumExtension
    {
        internal static string ToSerializedValue(this AuthenticationType? value)
        {
            return value == null ? null : ((AuthenticationType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this AuthenticationType value)
        {
            switch( value )
            {
                case AuthenticationType.Invalid:
                    return "Invalid";
                case AuthenticationType.None:
                    return "None";
                case AuthenticationType.Basic:
                    return "Basic";
                case AuthenticationType.NTLM:
                    return "NTLM";
            }
            return null;
        }

        internal static AuthenticationType? ParseAuthenticationType(this string value)
        {
            switch( value )
            {
                case "Invalid":
                    return AuthenticationType.Invalid;
                case "None":
                    return AuthenticationType.None;
                case "Basic":
                    return AuthenticationType.Basic;
                case "NTLM":
                    return AuthenticationType.NTLM;
            }
            return null;
        }
    }
}