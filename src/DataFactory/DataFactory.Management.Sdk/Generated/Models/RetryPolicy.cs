// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using System.Linq;

    /// <summary>
    /// Execution policy for an activity.
    /// </summary>
    public partial class RetryPolicy
    {
        /// <summary>
        /// Initializes a new instance of the RetryPolicy class.
        /// </summary>
        public RetryPolicy()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RetryPolicy class.
        /// </summary>

        /// <param name="count">Maximum ordinary retry attempts. Default is 0. Type: integer (or Expression
        /// with resultType integer), minimum: 0.
        /// </param>

        /// <param name="intervalInSeconds">Interval between retries in seconds. Default is 30.
        /// </param>
        public RetryPolicy(object count = default(object), int? intervalInSeconds = default(int?))

        {
            this.Count = count;
            this.IntervalInSeconds = intervalInSeconds;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets maximum ordinary retry attempts. Default is 0. Type: integer
        /// (or Expression with resultType integer), minimum: 0.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "count")]
        public object Count {get; set; }

        /// <summary>
        /// Gets or sets interval between retries in seconds. Default is 30.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "intervalInSeconds")]
        public int? IntervalInSeconds {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {

            if (this.IntervalInSeconds != null)
            {
                if (this.IntervalInSeconds > 86400)
                {
                    throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.InclusiveMaximum, "IntervalInSeconds", 86400);
                }
                if (this.IntervalInSeconds < 30)
                {
                    throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.InclusiveMinimum, "IntervalInSeconds", 30);
                }
            }
        }
    }
}