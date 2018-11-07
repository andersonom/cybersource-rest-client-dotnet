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
    /// InlineResponse2011ReversalAmountDetails
    /// </summary>
    [DataContract]
    public partial class InlineResponse2011ReversalAmountDetails :  IEquatable<InlineResponse2011ReversalAmountDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2011ReversalAmountDetails" /> class.
        /// </summary>
        /// <param name="ReversedAmount">Total reversed amount..</param>
        /// <param name="OriginalTransactionAmount">Amount of the original transaction..</param>
        /// <param name="Currency">Currency used for the order. Use the three-character ISO Standard Currency Codes.  For an authorization reversal or a capture, you must use the same currency that you used in your request for Payment API. .</param>
        public InlineResponse2011ReversalAmountDetails(string ReversedAmount = default(string), string OriginalTransactionAmount = default(string), string Currency = default(string))
        {
            this.ReversedAmount = ReversedAmount;
            this.OriginalTransactionAmount = OriginalTransactionAmount;
            this.Currency = Currency;
        }
        
        /// <summary>
        /// Total reversed amount.
        /// </summary>
        /// <value>Total reversed amount.</value>
        [DataMember(Name="reversedAmount", EmitDefaultValue=false)]
        public string ReversedAmount { get; set; }

        /// <summary>
        /// Amount of the original transaction.
        /// </summary>
        /// <value>Amount of the original transaction.</value>
        [DataMember(Name="originalTransactionAmount", EmitDefaultValue=false)]
        public string OriginalTransactionAmount { get; set; }

        /// <summary>
        /// Currency used for the order. Use the three-character ISO Standard Currency Codes.  For an authorization reversal or a capture, you must use the same currency that you used in your request for Payment API. 
        /// </summary>
        /// <value>Currency used for the order. Use the three-character ISO Standard Currency Codes.  For an authorization reversal or a capture, you must use the same currency that you used in your request for Payment API. </value>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse2011ReversalAmountDetails {\n");
            sb.Append("  ReversedAmount: ").Append(ReversedAmount).Append("\n");
            sb.Append("  OriginalTransactionAmount: ").Append(OriginalTransactionAmount).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
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
            return this.Equals(obj as InlineResponse2011ReversalAmountDetails);
        }

        /// <summary>
        /// Returns true if InlineResponse2011ReversalAmountDetails instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse2011ReversalAmountDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse2011ReversalAmountDetails other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ReversedAmount == other.ReversedAmount ||
                    this.ReversedAmount != null &&
                    this.ReversedAmount.Equals(other.ReversedAmount)
                ) && 
                (
                    this.OriginalTransactionAmount == other.OriginalTransactionAmount ||
                    this.OriginalTransactionAmount != null &&
                    this.OriginalTransactionAmount.Equals(other.OriginalTransactionAmount)
                ) && 
                (
                    this.Currency == other.Currency ||
                    this.Currency != null &&
                    this.Currency.Equals(other.Currency)
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
                if (this.ReversedAmount != null)
                    hash = hash * 59 + this.ReversedAmount.GetHashCode();
                if (this.OriginalTransactionAmount != null)
                    hash = hash * 59 + this.OriginalTransactionAmount.GetHashCode();
                if (this.Currency != null)
                    hash = hash * 59 + this.Currency.GetHashCode();
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
            // ReversedAmount (string) maxLength
            if(this.ReversedAmount != null && this.ReversedAmount.Length > 15)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReversedAmount, length must be less than 15.", new [] { "ReversedAmount" });
            }

            // OriginalTransactionAmount (string) maxLength
            if(this.OriginalTransactionAmount != null && this.OriginalTransactionAmount.Length > 15)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for OriginalTransactionAmount, length must be less than 15.", new [] { "OriginalTransactionAmount" });
            }

            // Currency (string) maxLength
            if(this.Currency != null && this.Currency.Length > 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Currency, length must be less than 3.", new [] { "Currency" });
            }

            yield break;
        }
    }

}
