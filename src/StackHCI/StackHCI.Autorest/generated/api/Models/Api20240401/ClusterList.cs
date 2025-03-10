// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Extensions;

    /// <summary>List of clusters.</summary>
    public partial class ClusterList :
        Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IClusterList,
        Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IClusterListInternal
    {

        /// <summary>Internal Acessors for NextLink</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IClusterListInternal.NextLink { get => this._nextLink; set { {_nextLink = value;} } }

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>Link to the next set of results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Origin(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.ICluster[] _value;

        /// <summary>List of clusters.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Origin(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.ICluster[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="ClusterList" /> instance.</summary>
        public ClusterList()
        {

        }
    }
    /// List of clusters.
    public partial interface IClusterList :
        Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.IJsonSerializable
    {
        /// <summary>Link to the next set of results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Link to the next set of results.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get;  }
        /// <summary>List of clusters.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of clusters.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.ICluster) })]
        Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.ICluster[] Value { get; set; }

    }
    /// List of clusters.
    internal partial interface IClusterListInternal

    {
        /// <summary>Link to the next set of results.</summary>
        string NextLink { get; set; }
        /// <summary>List of clusters.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.ICluster[] Value { get; set; }

    }
}