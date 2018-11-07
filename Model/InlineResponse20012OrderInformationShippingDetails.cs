/* 
 * CyberSource Flex API
 *
 * Simple PAN tokenization service
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace CyberSource.Model
{
    /// <summary>
    /// InlineResponse20012OrderInformationShippingDetails
    /// </summary>
    [DataContract]
    public partial class InlineResponse20012OrderInformationShippingDetails :  IEquatable<InlineResponse20012OrderInformationShippingDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse20012OrderInformationShippingDetails" /> class.
        /// </summary>
        /// <param name="GiftWrap">The description for this field is not available..</param>
        /// <param name="ShippingMethod">Shipping method for the product. Possible values:   - lowcost: Lowest-cost service  - sameday: Courier or same-day service  - oneday: Next-day or overnight service  - twoday: Two-day service  - threeday: Three-day service  - pickup: Store pick-up  - other: Other shipping method  - none: No shipping method because product is a service or subscription .</param>
        public InlineResponse20012OrderInformationShippingDetails(bool? GiftWrap = default(bool?), string ShippingMethod = default(string))
        {
            this.GiftWrap = GiftWrap;
            this.ShippingMethod = ShippingMethod;
        }
        
        /// <summary>
        /// The description for this field is not available.
        /// </summary>
        /// <value>The description for this field is not available.</value>
        [DataMember(Name="giftWrap", EmitDefaultValue=false)]
        public bool? GiftWrap { get; set; }

        /// <summary>
        /// Shipping method for the product. Possible values:   - lowcost: Lowest-cost service  - sameday: Courier or same-day service  - oneday: Next-day or overnight service  - twoday: Two-day service  - threeday: Three-day service  - pickup: Store pick-up  - other: Other shipping method  - none: No shipping method because product is a service or subscription 
        /// </summary>
        /// <value>Shipping method for the product. Possible values:   - lowcost: Lowest-cost service  - sameday: Courier or same-day service  - oneday: Next-day or overnight service  - twoday: Two-day service  - threeday: Three-day service  - pickup: Store pick-up  - other: Other shipping method  - none: No shipping method because product is a service or subscription </value>
        [DataMember(Name="shippingMethod", EmitDefaultValue=false)]
        public string ShippingMethod { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse20012OrderInformationShippingDetails {\n");
            sb.Append("  GiftWrap: ").Append(GiftWrap).Append("\n");
            sb.Append("  ShippingMethod: ").Append(ShippingMethod).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as InlineResponse20012OrderInformationShippingDetails);
        }

        /// <summary>
        /// Returns true if InlineResponse20012OrderInformationShippingDetails instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse20012OrderInformationShippingDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse20012OrderInformationShippingDetails other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.GiftWrap == other.GiftWrap ||
                    this.GiftWrap != null &&
                    this.GiftWrap.Equals(other.GiftWrap)
                ) && 
                (
                    this.ShippingMethod == other.ShippingMethod ||
                    this.ShippingMethod != null &&
                    this.ShippingMethod.Equals(other.ShippingMethod)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.GiftWrap != null)
                    hash = hash * 59 + this.GiftWrap.GetHashCode();
                if (this.ShippingMethod != null)
                    hash = hash * 59 + this.ShippingMethod.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // ShippingMethod (string) maxLength
            if(this.ShippingMethod != null && this.ShippingMethod.Length > 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ShippingMethod, length must be less than 10.", new [] { "ShippingMethod" });
            }

            yield break;
        }
    }

}
