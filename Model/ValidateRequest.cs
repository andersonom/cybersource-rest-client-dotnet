/* 
 * CyberSource Merged Spec
 *
 * All CyberSource API specs merged together. These are available at https://developer.cybersource.com/api/reference/api-reference.html
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = CyberSource.Client.SwaggerDateConverter;

namespace CyberSource.Model
{
    /// <summary>
    /// ValidateRequest
    /// </summary>
    [DataContract]
    public partial class ValidateRequest :  IEquatable<ValidateRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateRequest" /> class.
        /// </summary>
        /// <param name="ClientReferenceInformation">ClientReferenceInformation.</param>
        /// <param name="ProcessingInformation">ProcessingInformation.</param>
        /// <param name="OrderInformation">OrderInformation.</param>
        /// <param name="PaymentInformation">PaymentInformation.</param>
        /// <param name="ConsumerAuthenticationInformation">ConsumerAuthenticationInformation.</param>
        public ValidateRequest(Riskv1authenticationsClientReferenceInformation ClientReferenceInformation = default(Riskv1authenticationsClientReferenceInformation), Riskv1authenticationsProcessingInformation ProcessingInformation = default(Riskv1authenticationsProcessingInformation), Riskv1authenticationresultsOrderInformation OrderInformation = default(Riskv1authenticationresultsOrderInformation), Riskv1authenticationresultsPaymentInformation PaymentInformation = default(Riskv1authenticationresultsPaymentInformation), Riskv1authenticationresultsConsumerAuthenticationInformation ConsumerAuthenticationInformation = default(Riskv1authenticationresultsConsumerAuthenticationInformation))
        {
            this.ClientReferenceInformation = ClientReferenceInformation;
            this.ProcessingInformation = ProcessingInformation;
            this.OrderInformation = OrderInformation;
            this.PaymentInformation = PaymentInformation;
            this.ConsumerAuthenticationInformation = ConsumerAuthenticationInformation;
        }
        
        /// <summary>
        /// Gets or Sets ClientReferenceInformation
        /// </summary>
        [DataMember(Name="clientReferenceInformation", EmitDefaultValue=false)]
        public Riskv1authenticationsClientReferenceInformation ClientReferenceInformation { get; set; }

        /// <summary>
        /// Gets or Sets ProcessingInformation
        /// </summary>
        [DataMember(Name="processingInformation", EmitDefaultValue=false)]
        public Riskv1authenticationsProcessingInformation ProcessingInformation { get; set; }

        /// <summary>
        /// Gets or Sets OrderInformation
        /// </summary>
        [DataMember(Name="orderInformation", EmitDefaultValue=false)]
        public Riskv1authenticationresultsOrderInformation OrderInformation { get; set; }

        /// <summary>
        /// Gets or Sets PaymentInformation
        /// </summary>
        [DataMember(Name="paymentInformation", EmitDefaultValue=false)]
        public Riskv1authenticationresultsPaymentInformation PaymentInformation { get; set; }

        /// <summary>
        /// Gets or Sets ConsumerAuthenticationInformation
        /// </summary>
        [DataMember(Name="consumerAuthenticationInformation", EmitDefaultValue=false)]
        public Riskv1authenticationresultsConsumerAuthenticationInformation ConsumerAuthenticationInformation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ValidateRequest {\n");
            sb.Append("  ClientReferenceInformation: ").Append(ClientReferenceInformation).Append("\n");
            sb.Append("  ProcessingInformation: ").Append(ProcessingInformation).Append("\n");
            sb.Append("  OrderInformation: ").Append(OrderInformation).Append("\n");
            sb.Append("  PaymentInformation: ").Append(PaymentInformation).Append("\n");
            sb.Append("  ConsumerAuthenticationInformation: ").Append(ConsumerAuthenticationInformation).Append("\n");
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
            return this.Equals(obj as ValidateRequest);
        }

        /// <summary>
        /// Returns true if ValidateRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ValidateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ValidateRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ClientReferenceInformation == other.ClientReferenceInformation ||
                    this.ClientReferenceInformation != null &&
                    this.ClientReferenceInformation.Equals(other.ClientReferenceInformation)
                ) && 
                (
                    this.ProcessingInformation == other.ProcessingInformation ||
                    this.ProcessingInformation != null &&
                    this.ProcessingInformation.Equals(other.ProcessingInformation)
                ) && 
                (
                    this.OrderInformation == other.OrderInformation ||
                    this.OrderInformation != null &&
                    this.OrderInformation.Equals(other.OrderInformation)
                ) && 
                (
                    this.PaymentInformation == other.PaymentInformation ||
                    this.PaymentInformation != null &&
                    this.PaymentInformation.Equals(other.PaymentInformation)
                ) && 
                (
                    this.ConsumerAuthenticationInformation == other.ConsumerAuthenticationInformation ||
                    this.ConsumerAuthenticationInformation != null &&
                    this.ConsumerAuthenticationInformation.Equals(other.ConsumerAuthenticationInformation)
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
                if (this.ClientReferenceInformation != null)
                    hash = hash * 59 + this.ClientReferenceInformation.GetHashCode();
                if (this.ProcessingInformation != null)
                    hash = hash * 59 + this.ProcessingInformation.GetHashCode();
                if (this.OrderInformation != null)
                    hash = hash * 59 + this.OrderInformation.GetHashCode();
                if (this.PaymentInformation != null)
                    hash = hash * 59 + this.PaymentInformation.GetHashCode();
                if (this.ConsumerAuthenticationInformation != null)
                    hash = hash * 59 + this.ConsumerAuthenticationInformation.GetHashCode();
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
