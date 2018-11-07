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
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace CyberSource.Model
{
    /// <summary>
    /// InlineResponse2014
    /// </summary>
    [DataContract]
    public partial class InlineResponse2014 :  IEquatable<InlineResponse2014>, IValidatableObject
    {
        /// <summary>
        /// The status of the submitted transaction.
        /// </summary>
        /// <value>The status of the submitted transaction.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum PENDING for "PENDING"
            /// </summary>
            [EnumMember(Value = "PENDING")]
            PENDING
        }

        /// <summary>
        /// The status of the submitted transaction.
        /// </summary>
        /// <value>The status of the submitted transaction.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2014" /> class.
        /// </summary>
        /// <param name="Links">Links.</param>
        /// <param name="Id">An unique identification number assigned by CyberSource to identify the submitted request..</param>
        /// <param name="SubmitTimeUtc">Time of request in UTC. &#x60;Format: YYYY-MM-DDThh:mm:ssZ&#x60;  Example 2016-08-11T22:47:57Z equals August 11, 2016, at 22:47:57 (10:47:57 p.m.). The T separates the date and the time. The Z indicates UTC. .</param>
        /// <param name="Status">The status of the submitted transaction..</param>
        /// <param name="ReconciliationId">The reconciliation id for the submitted transaction. This value is not returned for all processors. .</param>
        /// <param name="ClientReferenceInformation">ClientReferenceInformation.</param>
        /// <param name="CreditAmountDetails">CreditAmountDetails.</param>
        /// <param name="ProcessorInformation">ProcessorInformation.</param>
        /// <param name="OrderInformation">OrderInformation.</param>
        public InlineResponse2014(InlineResponse2013Links Links = default(InlineResponse2013Links), string Id = default(string), string SubmitTimeUtc = default(string), StatusEnum? Status = default(StatusEnum?), string ReconciliationId = default(string), InlineResponse201ClientReferenceInformation ClientReferenceInformation = default(InlineResponse201ClientReferenceInformation), InlineResponse2014CreditAmountDetails CreditAmountDetails = default(InlineResponse2014CreditAmountDetails), InlineResponse2013ProcessorInformation ProcessorInformation = default(InlineResponse2013ProcessorInformation), InlineResponse2013OrderInformation OrderInformation = default(InlineResponse2013OrderInformation))
        {
            this.Links = Links;
            this.Id = Id;
            this.SubmitTimeUtc = SubmitTimeUtc;
            this.Status = Status;
            this.ReconciliationId = ReconciliationId;
            this.ClientReferenceInformation = ClientReferenceInformation;
            this.CreditAmountDetails = CreditAmountDetails;
            this.ProcessorInformation = ProcessorInformation;
            this.OrderInformation = OrderInformation;
        }
        
        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="_links", EmitDefaultValue=false)]
        public InlineResponse2013Links Links { get; set; }

        /// <summary>
        /// An unique identification number assigned by CyberSource to identify the submitted request.
        /// </summary>
        /// <value>An unique identification number assigned by CyberSource to identify the submitted request.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Time of request in UTC. &#x60;Format: YYYY-MM-DDThh:mm:ssZ&#x60;  Example 2016-08-11T22:47:57Z equals August 11, 2016, at 22:47:57 (10:47:57 p.m.). The T separates the date and the time. The Z indicates UTC. 
        /// </summary>
        /// <value>Time of request in UTC. &#x60;Format: YYYY-MM-DDThh:mm:ssZ&#x60;  Example 2016-08-11T22:47:57Z equals August 11, 2016, at 22:47:57 (10:47:57 p.m.). The T separates the date and the time. The Z indicates UTC. </value>
        [DataMember(Name="submitTimeUtc", EmitDefaultValue=false)]
        public string SubmitTimeUtc { get; set; }


        /// <summary>
        /// The reconciliation id for the submitted transaction. This value is not returned for all processors. 
        /// </summary>
        /// <value>The reconciliation id for the submitted transaction. This value is not returned for all processors. </value>
        [DataMember(Name="reconciliationId", EmitDefaultValue=false)]
        public string ReconciliationId { get; set; }

        /// <summary>
        /// Gets or Sets ClientReferenceInformation
        /// </summary>
        [DataMember(Name="clientReferenceInformation", EmitDefaultValue=false)]
        public InlineResponse201ClientReferenceInformation ClientReferenceInformation { get; set; }

        /// <summary>
        /// Gets or Sets CreditAmountDetails
        /// </summary>
        [DataMember(Name="creditAmountDetails", EmitDefaultValue=false)]
        public InlineResponse2014CreditAmountDetails CreditAmountDetails { get; set; }

        /// <summary>
        /// Gets or Sets ProcessorInformation
        /// </summary>
        [DataMember(Name="processorInformation", EmitDefaultValue=false)]
        public InlineResponse2013ProcessorInformation ProcessorInformation { get; set; }

        /// <summary>
        /// Gets or Sets OrderInformation
        /// </summary>
        [DataMember(Name="orderInformation", EmitDefaultValue=false)]
        public InlineResponse2013OrderInformation OrderInformation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse2014 {\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SubmitTimeUtc: ").Append(SubmitTimeUtc).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ReconciliationId: ").Append(ReconciliationId).Append("\n");
            sb.Append("  ClientReferenceInformation: ").Append(ClientReferenceInformation).Append("\n");
            sb.Append("  CreditAmountDetails: ").Append(CreditAmountDetails).Append("\n");
            sb.Append("  ProcessorInformation: ").Append(ProcessorInformation).Append("\n");
            sb.Append("  OrderInformation: ").Append(OrderInformation).Append("\n");
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
            return this.Equals(obj as InlineResponse2014);
        }

        /// <summary>
        /// Returns true if InlineResponse2014 instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse2014 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse2014 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Links == other.Links ||
                    this.Links != null &&
                    this.Links.Equals(other.Links)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.SubmitTimeUtc == other.SubmitTimeUtc ||
                    this.SubmitTimeUtc != null &&
                    this.SubmitTimeUtc.Equals(other.SubmitTimeUtc)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.ReconciliationId == other.ReconciliationId ||
                    this.ReconciliationId != null &&
                    this.ReconciliationId.Equals(other.ReconciliationId)
                ) && 
                (
                    this.ClientReferenceInformation == other.ClientReferenceInformation ||
                    this.ClientReferenceInformation != null &&
                    this.ClientReferenceInformation.Equals(other.ClientReferenceInformation)
                ) && 
                (
                    this.CreditAmountDetails == other.CreditAmountDetails ||
                    this.CreditAmountDetails != null &&
                    this.CreditAmountDetails.Equals(other.CreditAmountDetails)
                ) && 
                (
                    this.ProcessorInformation == other.ProcessorInformation ||
                    this.ProcessorInformation != null &&
                    this.ProcessorInformation.Equals(other.ProcessorInformation)
                ) && 
                (
                    this.OrderInformation == other.OrderInformation ||
                    this.OrderInformation != null &&
                    this.OrderInformation.Equals(other.OrderInformation)
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
                if (this.Links != null)
                    hash = hash * 59 + this.Links.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.SubmitTimeUtc != null)
                    hash = hash * 59 + this.SubmitTimeUtc.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.ReconciliationId != null)
                    hash = hash * 59 + this.ReconciliationId.GetHashCode();
                if (this.ClientReferenceInformation != null)
                    hash = hash * 59 + this.ClientReferenceInformation.GetHashCode();
                if (this.CreditAmountDetails != null)
                    hash = hash * 59 + this.CreditAmountDetails.GetHashCode();
                if (this.ProcessorInformation != null)
                    hash = hash * 59 + this.ProcessorInformation.GetHashCode();
                if (this.OrderInformation != null)
                    hash = hash * 59 + this.OrderInformation.GetHashCode();
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
            // Id (string) maxLength
            if(this.Id != null && this.Id.Length > 26)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, length must be less than 26.", new [] { "Id" });
            }

            // ReconciliationId (string) maxLength
            if(this.ReconciliationId != null && this.ReconciliationId.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReconciliationId, length must be less than 60.", new [] { "ReconciliationId" });
            }

            yield break;
        }
    }

}
