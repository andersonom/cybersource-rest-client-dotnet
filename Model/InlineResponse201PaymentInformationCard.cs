﻿/* 
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
    /// InlineResponse201PaymentInformationCard
    /// </summary>
    [DataContract]
    public partial class InlineResponse201PaymentInformationCard :  IEquatable<InlineResponse201PaymentInformationCard>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse201PaymentInformationCard" /> class.
        /// </summary>
        /// <param name="Suffix">Last four digits of the cardholder’s account number. This field is returned only for tokenized transactions. You can use this value on the receipt that you give to the cardholder. .</param>
        public InlineResponse201PaymentInformationCard(string Suffix = default(string))
        {
            this.Suffix = Suffix;
        }
        
        /// <summary>
        /// Last four digits of the cardholder’s account number. This field is returned only for tokenized transactions. You can use this value on the receipt that you give to the cardholder. 
        /// </summary>
        /// <value>Last four digits of the cardholder’s account number. This field is returned only for tokenized transactions. You can use this value on the receipt that you give to the cardholder. </value>
        [DataMember(Name="suffix", EmitDefaultValue=false)]
        public string Suffix { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse201PaymentInformationCard {\n");
            sb.Append("  Suffix: ").Append(Suffix).Append("\n");
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
            return this.Equals(obj as InlineResponse201PaymentInformationCard);
        }

        /// <summary>
        /// Returns true if InlineResponse201PaymentInformationCard instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse201PaymentInformationCard to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse201PaymentInformationCard other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Suffix == other.Suffix ||
                    this.Suffix != null &&
                    this.Suffix.Equals(other.Suffix)
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
                if (this.Suffix != null)
                    hash = hash * 59 + this.Suffix.GetHashCode();
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
            // Suffix (string) maxLength
            if(this.Suffix != null && this.Suffix.Length > 4)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Suffix, length must be less than 4.", new [] { "Suffix" });
            }

            yield break;
        }
    }

}
