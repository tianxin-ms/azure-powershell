// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.DevTestLabs.Models
{
    using System.Linq;

    /// <summary>
    /// Properties of an hourly schedule.
    /// </summary>
    public partial class HourDetailsFragment
    {
        /// <summary>
        /// Initializes a new instance of the HourDetailsFragment class.
        /// </summary>
        public HourDetailsFragment()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HourDetailsFragment class.
        /// </summary>

        /// <param name="minute">Minutes of the hour the schedule will run.
        /// </param>
        public HourDetailsFragment(int? minute = default(int?))

        {
            this.Minute = minute;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets minutes of the hour the schedule will run.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "minute")]
        public int? Minute {get; set; }
    }
}