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
    /// InlineResponse201OrderInformation
    /// </summary>
    [DataContract]
    public partial class InlineResponse201OrderInformation :  IEquatable<InlineResponse201OrderInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse201OrderInformation" /> class.
        /// </summary>
        /// <param name="AmountDetails">AmountDetails.</param>
        /// <param name="InvoiceDetails">InvoiceDetails.</param>
        public InlineResponse201OrderInformation(InlineResponse201OrderInformationAmountDetails AmountDetails = default(InlineResponse201OrderInformationAmountDetails), InlineResponse201OrderInformationInvoiceDetails InvoiceDetails = default(InlineResponse201OrderInformationInvoiceDetails))
        {
            this.AmountDetails = AmountDetails;
            this.InvoiceDetails = InvoiceDetails;
        }
        
        /// <summary>
        /// Gets or Sets AmountDetails
        /// </summary>
        [DataMember(Name="amountDetails", EmitDefaultValue=false)]
        public InlineResponse201OrderInformationAmountDetails AmountDetails { get; set; }

        /// <summary>
        /// Gets or Sets InvoiceDetails
        /// </summary>
        [DataMember(Name="invoiceDetails", EmitDefaultValue=false)]
        public InlineResponse201OrderInformationInvoiceDetails InvoiceDetails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse201OrderInformation {\n");
            sb.Append("  AmountDetails: ").Append(AmountDetails).Append("\n");
            sb.Append("  InvoiceDetails: ").Append(InvoiceDetails).Append("\n");
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
            return this.Equals(obj as InlineResponse201OrderInformation);
        }

        /// <summary>
        /// Returns true if InlineResponse201OrderInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse201OrderInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse201OrderInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AmountDetails == other.AmountDetails ||
                    this.AmountDetails != null &&
                    this.AmountDetails.Equals(other.AmountDetails)
                ) && 
                (
                    this.InvoiceDetails == other.InvoiceDetails ||
                    this.InvoiceDetails != null &&
                    this.InvoiceDetails.Equals(other.InvoiceDetails)
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
                if (this.AmountDetails != null)
                    hash = hash * 59 + this.AmountDetails.GetHashCode();
                if (this.InvoiceDetails != null)
                    hash = hash * 59 + this.InvoiceDetails.GetHashCode();
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
            yield break;
        }
    }

}
