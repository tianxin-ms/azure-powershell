// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.PowerShell;

    /// <summary>
    /// Properties of the devcenter encryption set. These properties can be updated after the resource has been created.
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(DevCenterEncryptionSetUpdatePropertiesTypeConverter))]
    public partial class DevCenterEncryptionSetUpdateProperties
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview.DevCenterEncryptionSetUpdateProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview.IDevCenterEncryptionSetUpdateProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview.IDevCenterEncryptionSetUpdateProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new DevCenterEncryptionSetUpdateProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview.DevCenterEncryptionSetUpdateProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview.IDevCenterEncryptionSetUpdateProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview.IDevCenterEncryptionSetUpdateProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new DevCenterEncryptionSetUpdateProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview.DevCenterEncryptionSetUpdateProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal DevCenterEncryptionSetUpdateProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("DevboxDisksEncryptionEnableStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview.IDevCenterEncryptionSetUpdatePropertiesInternal)this).DevboxDisksEncryptionEnableStatus = (Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.DevboxDisksEncryptionEnableStatus?) content.GetValueForProperty("DevboxDisksEncryptionEnableStatus",((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview.IDevCenterEncryptionSetUpdatePropertiesInternal)this).DevboxDisksEncryptionEnableStatus, Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.DevboxDisksEncryptionEnableStatus.CreateFrom);
            }
            if (content.Contains("KeyEncryptionKeyUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview.IDevCenterEncryptionSetUpdatePropertiesInternal)this).KeyEncryptionKeyUrl = (string) content.GetValueForProperty("KeyEncryptionKeyUrl",((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview.IDevCenterEncryptionSetUpdatePropertiesInternal)this).KeyEncryptionKeyUrl, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview.DevCenterEncryptionSetUpdateProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal DevCenterEncryptionSetUpdateProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("DevboxDisksEncryptionEnableStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview.IDevCenterEncryptionSetUpdatePropertiesInternal)this).DevboxDisksEncryptionEnableStatus = (Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.DevboxDisksEncryptionEnableStatus?) content.GetValueForProperty("DevboxDisksEncryptionEnableStatus",((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview.IDevCenterEncryptionSetUpdatePropertiesInternal)this).DevboxDisksEncryptionEnableStatus, Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.DevboxDisksEncryptionEnableStatus.CreateFrom);
            }
            if (content.Contains("KeyEncryptionKeyUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview.IDevCenterEncryptionSetUpdatePropertiesInternal)this).KeyEncryptionKeyUrl = (string) content.GetValueForProperty("KeyEncryptionKeyUrl",((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview.IDevCenterEncryptionSetUpdatePropertiesInternal)this).KeyEncryptionKeyUrl, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="DevCenterEncryptionSetUpdateProperties" />, deserializing the content from a json
        /// string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>
        /// an instance of the <see cref="DevCenterEncryptionSetUpdateProperties" /> model class.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview.IDevCenterEncryptionSetUpdateProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Properties of the devcenter encryption set. These properties can be updated after the resource has been created.
    [System.ComponentModel.TypeConverter(typeof(DevCenterEncryptionSetUpdatePropertiesTypeConverter))]
    public partial interface IDevCenterEncryptionSetUpdateProperties

    {

    }
}