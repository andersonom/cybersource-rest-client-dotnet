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
    /// Riskv1authenticationresultsPaymentInformation
    /// </summary>
    [DataContract]
    public partial class Riskv1authenticationresultsPaymentInformation :  IEquatable<Riskv1authenticationresultsPaymentInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Riskv1authenticationresultsPaymentInformation" /> class.
        /// </summary>
        /// <param name="Card">Card.</param>
        /// <param name="TokenizedCard">TokenizedCard.</param>
        /// <param name="FluidData">FluidData.</param>
        public Riskv1authenticationresultsPaymentInformation(Riskv1authenticationresultsPaymentInformationCard Card = default(Riskv1authenticationresultsPaymentInformationCard), Riskv1authenticationresultsPaymentInformationTokenizedCard TokenizedCard = default(Riskv1authenticationresultsPaymentInformationTokenizedCard), Riskv1authenticationsPaymentInformationFluidData FluidData = default(Riskv1authenticationsPaymentInformationFluidData))
        {
            this.Card = Card;
            this.TokenizedCard = TokenizedCard;
            this.FluidData = FluidData;
        }
        
        /// <summary>
        /// Gets or Sets Card
        /// </summary>
        [DataMember(Name="card", EmitDefaultValue=false)]
        public Riskv1authenticationresultsPaymentInformationCard Card { get; set; }

        /// <summary>
        /// Gets or Sets TokenizedCard
        /// </summary>
        [DataMember(Name="tokenizedCard", EmitDefaultValue=false)]
        public Riskv1authenticationresultsPaymentInformationTokenizedCard TokenizedCard { get; set; }

        /// <summary>
        /// Gets or Sets FluidData
        /// </summary>
        [DataMember(Name="fluidData", EmitDefaultValue=false)]
        public Riskv1authenticationsPaymentInformationFluidData FluidData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Riskv1authenticationresultsPaymentInformation {\n");
            sb.Append("  Card: ").Append(Card).Append("\n");
            sb.Append("  TokenizedCard: ").Append(TokenizedCard).Append("\n");
            sb.Append("  FluidData: ").Append(FluidData).Append("\n");
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
            return this.Equals(obj as Riskv1authenticationresultsPaymentInformation);
        }

        /// <summary>
        /// Returns true if Riskv1authenticationresultsPaymentInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of Riskv1authenticationresultsPaymentInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Riskv1authenticationresultsPaymentInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Card == other.Card ||
                    this.Card != null &&
                    this.Card.Equals(other.Card)
                ) && 
                (
                    this.TokenizedCard == other.TokenizedCard ||
                    this.TokenizedCard != null &&
                    this.TokenizedCard.Equals(other.TokenizedCard)
                ) && 
                (
                    this.FluidData == other.FluidData ||
                    this.FluidData != null &&
                    this.FluidData.Equals(other.FluidData)
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
                if (this.Card != null)
                    hash = hash * 59 + this.Card.GetHashCode();
                if (this.TokenizedCard != null)
                    hash = hash * 59 + this.TokenizedCard.GetHashCode();
                if (this.FluidData != null)
                    hash = hash * 59 + this.FluidData.GetHashCode();
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
