// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for ExportState.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ExportState
    {
        /// <summary>
        /// The state of the export to file job is undefined
        /// </summary>
        [EnumMember(Value = "Undefined")]
        Undefined,
        /// <summary>
        /// The export to file job didn't start
        /// </summary>
        [EnumMember(Value = "NotStarted")]
        NotStarted,
        /// <summary>
        /// The export to file job is running
        /// </summary>
        [EnumMember(Value = "Running")]
        Running,
        /// <summary>
        /// The export to file job finished successfully
        /// </summary>
        [EnumMember(Value = "Succeeded")]
        Succeeded,
        /// <summary>
        /// The export to file job failed
        /// </summary>
        [EnumMember(Value = "Failed")]
        Failed
    }
    internal static class ExportStateEnumExtension
    {
        internal static string ToSerializedValue(this ExportState? value)
        {
            return value == null ? null : ((ExportState)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this ExportState value)
        {
            switch( value )
            {
                case ExportState.Undefined:
                    return "Undefined";
                case ExportState.NotStarted:
                    return "NotStarted";
                case ExportState.Running:
                    return "Running";
                case ExportState.Succeeded:
                    return "Succeeded";
                case ExportState.Failed:
                    return "Failed";
            }
            return null;
        }

        internal static ExportState? ParseExportState(this string value)
        {
            switch( value )
            {
                case "Undefined":
                    return ExportState.Undefined;
                case "NotStarted":
                    return ExportState.NotStarted;
                case "Running":
                    return ExportState.Running;
                case "Succeeded":
                    return ExportState.Succeeded;
                case "Failed":
                    return ExportState.Failed;
            }
            return null;
        }
    }
}
