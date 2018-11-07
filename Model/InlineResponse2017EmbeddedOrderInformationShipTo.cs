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
    /// InlineResponse2017EmbeddedOrderInformationShipTo
    /// </summary>
    [DataContract]
    public partial class InlineResponse2017EmbeddedOrderInformationShipTo :  IEquatable<InlineResponse2017EmbeddedOrderInformationShipTo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2017EmbeddedOrderInformationShipTo" /> class.
        /// </summary>
        /// <param name="FirstName">First name of the recipient.  **Processor specific maximum length**  - Litle: 25 - All other processors: 60 .</param>
        /// <param name="LastName">Last name of the recipient.  **Processor specific maximum length**  - Litle: 25 - All other processors: 60 .</param>
        /// <param name="Address1">First line of the shipping address..</param>
        /// <param name="Country">Country of the shipping address. Use the two character ISO Standard Country Codes..</param>
        /// <param name="PhoneNumber">Phone number for the shipping address..</param>
        public InlineResponse2017EmbeddedOrderInformationShipTo(string FirstName = default(string), string LastName = default(string), string Address1 = default(string), string Country = default(string), string PhoneNumber = default(string))
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Address1 = Address1;
            this.Country = Country;
            this.PhoneNumber = PhoneNumber;
        }
        
        /// <summary>
        /// First name of the recipient.  **Processor specific maximum length**  - Litle: 25 - All other processors: 60 
        /// </summary>
        /// <value>First name of the recipient.  **Processor specific maximum length**  - Litle: 25 - All other processors: 60 </value>
        [DataMember(Name="firstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Last name of the recipient.  **Processor specific maximum length**  - Litle: 25 - All other processors: 60 
        /// </summary>
        /// <value>Last name of the recipient.  **Processor specific maximum length**  - Litle: 25 - All other processors: 60 </value>
        [DataMember(Name="lastName", EmitDefaultValue=false)]
        public string LastName { get; set; }

        /// <summary>
        /// First line of the shipping address.
        /// </summary>
        /// <value>First line of the shipping address.</value>
        [DataMember(Name="address1", EmitDefaultValue=false)]
        public string Address1 { get; set; }

        /// <summary>
        /// Country of the shipping address. Use the two character ISO Standard Country Codes.
        /// </summary>
        /// <value>Country of the shipping address. Use the two character ISO Standard Country Codes.</value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// Phone number for the shipping address.
        /// </summary>
        /// <value>Phone number for the shipping address.</value>
        [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse2017EmbeddedOrderInformationShipTo {\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Address1: ").Append(Address1).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
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
            return this.Equals(obj as InlineResponse2017EmbeddedOrderInformationShipTo);
        }

        /// <summary>
        /// Returns true if InlineResponse2017EmbeddedOrderInformationShipTo instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse2017EmbeddedOrderInformationShipTo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse2017EmbeddedOrderInformationShipTo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FirstName == other.FirstName ||
                    this.FirstName != null &&
                    this.FirstName.Equals(other.FirstName)
                ) && 
                (
                    this.LastName == other.LastName ||
                    this.LastName != null &&
                    this.LastName.Equals(other.LastName)
                ) && 
                (
                    this.Address1 == other.Address1 ||
                    this.Address1 != null &&
                    this.Address1.Equals(other.Address1)
                ) && 
                (
                    this.Country == other.Country ||
                    this.Country != null &&
                    this.Country.Equals(other.Country)
                ) && 
                (
                    this.PhoneNumber == other.PhoneNumber ||
                    this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(other.PhoneNumber)
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
                if (this.FirstName != null)
                    hash = hash * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hash = hash * 59 + this.LastName.GetHashCode();
                if (this.Address1 != null)
                    hash = hash * 59 + this.Address1.GetHashCode();
                if (this.Country != null)
                    hash = hash * 59 + this.Country.GetHashCode();
                if (this.PhoneNumber != null)
                    hash = hash * 59 + this.PhoneNumber.GetHashCode();
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
            // FirstName (string) maxLength
            if(this.FirstName != null && this.FirstName.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FirstName, length must be less than 60.", new [] { "FirstName" });
            }

            // LastName (string) maxLength
            if(this.LastName != null && this.LastName.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LastName, length must be less than 60.", new [] { "LastName" });
            }

            // Address1 (string) maxLength
            if(this.Address1 != null && this.Address1.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Address1, length must be less than 60.", new [] { "Address1" });
            }

            // Country (string) maxLength
            if(this.Country != null && this.Country.Length > 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Country, length must be less than 2.", new [] { "Country" });
            }

            // PhoneNumber (string) maxLength
            if(this.PhoneNumber != null && this.PhoneNumber.Length > 15)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PhoneNumber, length must be less than 15.", new [] { "PhoneNumber" });
            }

            yield break;
        }
    }

}
