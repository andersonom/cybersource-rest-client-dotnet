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
    /// Notification Of Change
    /// </summary>
    [DataContract]
    public partial class InlineResponse2003NotificationOfChanges :  IEquatable<InlineResponse2003NotificationOfChanges>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2003NotificationOfChanges" /> class.
        /// </summary>
        /// <param name="MerchantReferenceNumber">Merchant Reference Number.</param>
        /// <param name="TransactionReferenceNumber">Transaction Reference Number.</param>
        /// <param name="Time">Notification Of Change Date(ISO 8601 Extended).</param>
        /// <param name="Code">Merchant Reference Number.</param>
        /// <param name="AccountType">Account Type.</param>
        /// <param name="RoutingNumber">Routing Number.</param>
        /// <param name="AccountNumber">Account Number.</param>
        /// <param name="ConsumerName">Consumer Name.</param>
        public InlineResponse2003NotificationOfChanges(string MerchantReferenceNumber = default(string), string TransactionReferenceNumber = default(string), DateTime? Time = default(DateTime?), string Code = default(string), string AccountType = default(string), string RoutingNumber = default(string), string AccountNumber = default(string), string ConsumerName = default(string))
        {
            this.MerchantReferenceNumber = MerchantReferenceNumber;
            this.TransactionReferenceNumber = TransactionReferenceNumber;
            this.Time = Time;
            this.Code = Code;
            this.AccountType = AccountType;
            this.RoutingNumber = RoutingNumber;
            this.AccountNumber = AccountNumber;
            this.ConsumerName = ConsumerName;
        }
        
        /// <summary>
        /// Merchant Reference Number
        /// </summary>
        /// <value>Merchant Reference Number</value>
        [DataMember(Name="merchantReferenceNumber", EmitDefaultValue=false)]
        public string MerchantReferenceNumber { get; set; }

        /// <summary>
        /// Transaction Reference Number
        /// </summary>
        /// <value>Transaction Reference Number</value>
        [DataMember(Name="transactionReferenceNumber", EmitDefaultValue=false)]
        public string TransactionReferenceNumber { get; set; }

        /// <summary>
        /// Notification Of Change Date(ISO 8601 Extended)
        /// </summary>
        /// <value>Notification Of Change Date(ISO 8601 Extended)</value>
        [DataMember(Name="time", EmitDefaultValue=false)]
        public DateTime? Time { get; set; }

        /// <summary>
        /// Merchant Reference Number
        /// </summary>
        /// <value>Merchant Reference Number</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// Account Type
        /// </summary>
        /// <value>Account Type</value>
        [DataMember(Name="accountType", EmitDefaultValue=false)]
        public string AccountType { get; set; }

        /// <summary>
        /// Routing Number
        /// </summary>
        /// <value>Routing Number</value>
        [DataMember(Name="routingNumber", EmitDefaultValue=false)]
        public string RoutingNumber { get; set; }

        /// <summary>
        /// Account Number
        /// </summary>
        /// <value>Account Number</value>
        [DataMember(Name="accountNumber", EmitDefaultValue=false)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Consumer Name
        /// </summary>
        /// <value>Consumer Name</value>
        [DataMember(Name="consumerName", EmitDefaultValue=false)]
        public string ConsumerName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse2003NotificationOfChanges {\n");
            sb.Append("  MerchantReferenceNumber: ").Append(MerchantReferenceNumber).Append("\n");
            sb.Append("  TransactionReferenceNumber: ").Append(TransactionReferenceNumber).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  AccountType: ").Append(AccountType).Append("\n");
            sb.Append("  RoutingNumber: ").Append(RoutingNumber).Append("\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  ConsumerName: ").Append(ConsumerName).Append("\n");
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
            return this.Equals(obj as InlineResponse2003NotificationOfChanges);
        }

        /// <summary>
        /// Returns true if InlineResponse2003NotificationOfChanges instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse2003NotificationOfChanges to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse2003NotificationOfChanges other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.MerchantReferenceNumber == other.MerchantReferenceNumber ||
                    this.MerchantReferenceNumber != null &&
                    this.MerchantReferenceNumber.Equals(other.MerchantReferenceNumber)
                ) && 
                (
                    this.TransactionReferenceNumber == other.TransactionReferenceNumber ||
                    this.TransactionReferenceNumber != null &&
                    this.TransactionReferenceNumber.Equals(other.TransactionReferenceNumber)
                ) && 
                (
                    this.Time == other.Time ||
                    this.Time != null &&
                    this.Time.Equals(other.Time)
                ) && 
                (
                    this.Code == other.Code ||
                    this.Code != null &&
                    this.Code.Equals(other.Code)
                ) && 
                (
                    this.AccountType == other.AccountType ||
                    this.AccountType != null &&
                    this.AccountType.Equals(other.AccountType)
                ) && 
                (
                    this.RoutingNumber == other.RoutingNumber ||
                    this.RoutingNumber != null &&
                    this.RoutingNumber.Equals(other.RoutingNumber)
                ) && 
                (
                    this.AccountNumber == other.AccountNumber ||
                    this.AccountNumber != null &&
                    this.AccountNumber.Equals(other.AccountNumber)
                ) && 
                (
                    this.ConsumerName == other.ConsumerName ||
                    this.ConsumerName != null &&
                    this.ConsumerName.Equals(other.ConsumerName)
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
                if (this.MerchantReferenceNumber != null)
                    hash = hash * 59 + this.MerchantReferenceNumber.GetHashCode();
                if (this.TransactionReferenceNumber != null)
                    hash = hash * 59 + this.TransactionReferenceNumber.GetHashCode();
                if (this.Time != null)
                    hash = hash * 59 + this.Time.GetHashCode();
                if (this.Code != null)
                    hash = hash * 59 + this.Code.GetHashCode();
                if (this.AccountType != null)
                    hash = hash * 59 + this.AccountType.GetHashCode();
                if (this.RoutingNumber != null)
                    hash = hash * 59 + this.RoutingNumber.GetHashCode();
                if (this.AccountNumber != null)
                    hash = hash * 59 + this.AccountNumber.GetHashCode();
                if (this.ConsumerName != null)
                    hash = hash * 59 + this.ConsumerName.GetHashCode();
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
