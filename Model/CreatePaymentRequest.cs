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
    /// CreatePaymentRequest
    /// </summary>
    [DataContract]
    public partial class CreatePaymentRequest :  IEquatable<CreatePaymentRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePaymentRequest" /> class.
        /// </summary>
        /// <param name="ClientReferenceInformation">ClientReferenceInformation.</param>
        /// <param name="ProcessingInformation">ProcessingInformation.</param>
        /// <param name="IssuerInformation">IssuerInformation.</param>
        /// <param name="PaymentInformation">PaymentInformation.</param>
        /// <param name="OrderInformation">OrderInformation.</param>
        /// <param name="BuyerInformation">BuyerInformation.</param>
        /// <param name="RecipientInformation">RecipientInformation.</param>
        /// <param name="DeviceInformation">DeviceInformation.</param>
        /// <param name="MerchantInformation">MerchantInformation.</param>
        /// <param name="AggregatorInformation">AggregatorInformation.</param>
        /// <param name="ConsumerAuthenticationInformation">ConsumerAuthenticationInformation.</param>
        /// <param name="PointOfSaleInformation">PointOfSaleInformation.</param>
        /// <param name="MerchantDefinedInformation">The object containing the custom data that the merchant defines. .</param>
        /// <param name="InstallmentInformation">InstallmentInformation.</param>
        /// <param name="TravelInformation">TravelInformation.</param>
        /// <param name="PromotionInformation">PromotionInformation.</param>
        /// <param name="TokenInformation">TokenInformation.</param>
        /// <param name="RiskInformation">RiskInformation.</param>
        /// <param name="AcquirerInformation">AcquirerInformation.</param>
        /// <param name="RecurringPaymentInformation">RecurringPaymentInformation.</param>
        public CreatePaymentRequest(Ptsv2paymentsClientReferenceInformation ClientReferenceInformation = default(Ptsv2paymentsClientReferenceInformation), Ptsv2paymentsProcessingInformation ProcessingInformation = default(Ptsv2paymentsProcessingInformation), Ptsv2paymentsIssuerInformation IssuerInformation = default(Ptsv2paymentsIssuerInformation), Ptsv2paymentsPaymentInformation PaymentInformation = default(Ptsv2paymentsPaymentInformation), Ptsv2paymentsOrderInformation OrderInformation = default(Ptsv2paymentsOrderInformation), Ptsv2paymentsBuyerInformation BuyerInformation = default(Ptsv2paymentsBuyerInformation), Ptsv2paymentsRecipientInformation RecipientInformation = default(Ptsv2paymentsRecipientInformation), Ptsv2paymentsDeviceInformation DeviceInformation = default(Ptsv2paymentsDeviceInformation), Ptsv2paymentsMerchantInformation MerchantInformation = default(Ptsv2paymentsMerchantInformation), Ptsv2paymentsAggregatorInformation AggregatorInformation = default(Ptsv2paymentsAggregatorInformation), Ptsv2paymentsConsumerAuthenticationInformation ConsumerAuthenticationInformation = default(Ptsv2paymentsConsumerAuthenticationInformation), Ptsv2paymentsPointOfSaleInformation PointOfSaleInformation = default(Ptsv2paymentsPointOfSaleInformation), List<Ptsv2paymentsMerchantDefinedInformation> MerchantDefinedInformation = default(List<Ptsv2paymentsMerchantDefinedInformation>), Ptsv2paymentsInstallmentInformation InstallmentInformation = default(Ptsv2paymentsInstallmentInformation), Ptsv2paymentsTravelInformation TravelInformation = default(Ptsv2paymentsTravelInformation), Ptsv2paymentsPromotionInformation PromotionInformation = default(Ptsv2paymentsPromotionInformation), Ptsv2paymentsTokenInformation TokenInformation = default(Ptsv2paymentsTokenInformation), Ptsv2paymentsRiskInformation RiskInformation = default(Ptsv2paymentsRiskInformation), Ptsv2paymentsAcquirerInformation AcquirerInformation = default(Ptsv2paymentsAcquirerInformation), Ptsv2paymentsRecurringPaymentInformation RecurringPaymentInformation = default(Ptsv2paymentsRecurringPaymentInformation))
        {
            this.ClientReferenceInformation = ClientReferenceInformation;
            this.ProcessingInformation = ProcessingInformation;
            this.IssuerInformation = IssuerInformation;
            this.PaymentInformation = PaymentInformation;
            this.OrderInformation = OrderInformation;
            this.BuyerInformation = BuyerInformation;
            this.RecipientInformation = RecipientInformation;
            this.DeviceInformation = DeviceInformation;
            this.MerchantInformation = MerchantInformation;
            this.AggregatorInformation = AggregatorInformation;
            this.ConsumerAuthenticationInformation = ConsumerAuthenticationInformation;
            this.PointOfSaleInformation = PointOfSaleInformation;
            this.MerchantDefinedInformation = MerchantDefinedInformation;
            this.InstallmentInformation = InstallmentInformation;
            this.TravelInformation = TravelInformation;
            this.PromotionInformation = PromotionInformation;
            this.TokenInformation = TokenInformation;
            this.RiskInformation = RiskInformation;
            this.AcquirerInformation = AcquirerInformation;
            this.RecurringPaymentInformation = RecurringPaymentInformation;
        }
        
        /// <summary>
        /// Gets or Sets ClientReferenceInformation
        /// </summary>
        [DataMember(Name="clientReferenceInformation", EmitDefaultValue=false)]
        public Ptsv2paymentsClientReferenceInformation ClientReferenceInformation { get; set; }

        /// <summary>
        /// Gets or Sets ProcessingInformation
        /// </summary>
        [DataMember(Name="processingInformation", EmitDefaultValue=false)]
        public Ptsv2paymentsProcessingInformation ProcessingInformation { get; set; }

        /// <summary>
        /// Gets or Sets IssuerInformation
        /// </summary>
        [DataMember(Name="issuerInformation", EmitDefaultValue=false)]
        public Ptsv2paymentsIssuerInformation IssuerInformation { get; set; }

        /// <summary>
        /// Gets or Sets PaymentInformation
        /// </summary>
        [DataMember(Name="paymentInformation", EmitDefaultValue=false)]
        public Ptsv2paymentsPaymentInformation PaymentInformation { get; set; }

        /// <summary>
        /// Gets or Sets OrderInformation
        /// </summary>
        [DataMember(Name="orderInformation", EmitDefaultValue=false)]
        public Ptsv2paymentsOrderInformation OrderInformation { get; set; }

        /// <summary>
        /// Gets or Sets BuyerInformation
        /// </summary>
        [DataMember(Name="buyerInformation", EmitDefaultValue=false)]
        public Ptsv2paymentsBuyerInformation BuyerInformation { get; set; }

        /// <summary>
        /// Gets or Sets RecipientInformation
        /// </summary>
        [DataMember(Name="recipientInformation", EmitDefaultValue=false)]
        public Ptsv2paymentsRecipientInformation RecipientInformation { get; set; }

        /// <summary>
        /// Gets or Sets DeviceInformation
        /// </summary>
        [DataMember(Name="deviceInformation", EmitDefaultValue=false)]
        public Ptsv2paymentsDeviceInformation DeviceInformation { get; set; }

        /// <summary>
        /// Gets or Sets MerchantInformation
        /// </summary>
        [DataMember(Name="merchantInformation", EmitDefaultValue=false)]
        public Ptsv2paymentsMerchantInformation MerchantInformation { get; set; }

        /// <summary>
        /// Gets or Sets AggregatorInformation
        /// </summary>
        [DataMember(Name="aggregatorInformation", EmitDefaultValue=false)]
        public Ptsv2paymentsAggregatorInformation AggregatorInformation { get; set; }

        /// <summary>
        /// Gets or Sets ConsumerAuthenticationInformation
        /// </summary>
        [DataMember(Name="consumerAuthenticationInformation", EmitDefaultValue=false)]
        public Ptsv2paymentsConsumerAuthenticationInformation ConsumerAuthenticationInformation { get; set; }

        /// <summary>
        /// Gets or Sets PointOfSaleInformation
        /// </summary>
        [DataMember(Name="pointOfSaleInformation", EmitDefaultValue=false)]
        public Ptsv2paymentsPointOfSaleInformation PointOfSaleInformation { get; set; }

        /// <summary>
        /// The object containing the custom data that the merchant defines. 
        /// </summary>
        /// <value>The object containing the custom data that the merchant defines. </value>
        [DataMember(Name="merchantDefinedInformation", EmitDefaultValue=false)]
        public List<Ptsv2paymentsMerchantDefinedInformation> MerchantDefinedInformation { get; set; }

        /// <summary>
        /// Gets or Sets InstallmentInformation
        /// </summary>
        [DataMember(Name="installmentInformation", EmitDefaultValue=false)]
        public Ptsv2paymentsInstallmentInformation InstallmentInformation { get; set; }

        /// <summary>
        /// Gets or Sets TravelInformation
        /// </summary>
        [DataMember(Name="travelInformation", EmitDefaultValue=false)]
        public Ptsv2paymentsTravelInformation TravelInformation { get; set; }

        /// <summary>
        /// Gets or Sets PromotionInformation
        /// </summary>
        [DataMember(Name="promotionInformation", EmitDefaultValue=false)]
        public Ptsv2paymentsPromotionInformation PromotionInformation { get; set; }

        /// <summary>
        /// Gets or Sets TokenInformation
        /// </summary>
        [DataMember(Name="tokenInformation", EmitDefaultValue=false)]
        public Ptsv2paymentsTokenInformation TokenInformation { get; set; }

        /// <summary>
        /// Gets or Sets RiskInformation
        /// </summary>
        [DataMember(Name="riskInformation", EmitDefaultValue=false)]
        public Ptsv2paymentsRiskInformation RiskInformation { get; set; }

        /// <summary>
        /// Gets or Sets AcquirerInformation
        /// </summary>
        [DataMember(Name="acquirerInformation", EmitDefaultValue=false)]
        public Ptsv2paymentsAcquirerInformation AcquirerInformation { get; set; }

        /// <summary>
        /// Gets or Sets RecurringPaymentInformation
        /// </summary>
        [DataMember(Name="recurringPaymentInformation", EmitDefaultValue=false)]
        public Ptsv2paymentsRecurringPaymentInformation RecurringPaymentInformation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreatePaymentRequest {\n");
            sb.Append("  ClientReferenceInformation: ").Append(ClientReferenceInformation).Append("\n");
            sb.Append("  ProcessingInformation: ").Append(ProcessingInformation).Append("\n");
            sb.Append("  IssuerInformation: ").Append(IssuerInformation).Append("\n");
            sb.Append("  PaymentInformation: ").Append(PaymentInformation).Append("\n");
            sb.Append("  OrderInformation: ").Append(OrderInformation).Append("\n");
            sb.Append("  BuyerInformation: ").Append(BuyerInformation).Append("\n");
            sb.Append("  RecipientInformation: ").Append(RecipientInformation).Append("\n");
            sb.Append("  DeviceInformation: ").Append(DeviceInformation).Append("\n");
            sb.Append("  MerchantInformation: ").Append(MerchantInformation).Append("\n");
            sb.Append("  AggregatorInformation: ").Append(AggregatorInformation).Append("\n");
            sb.Append("  ConsumerAuthenticationInformation: ").Append(ConsumerAuthenticationInformation).Append("\n");
            sb.Append("  PointOfSaleInformation: ").Append(PointOfSaleInformation).Append("\n");
            sb.Append("  MerchantDefinedInformation: ").Append(MerchantDefinedInformation).Append("\n");
            sb.Append("  InstallmentInformation: ").Append(InstallmentInformation).Append("\n");
            sb.Append("  TravelInformation: ").Append(TravelInformation).Append("\n");
            sb.Append("  PromotionInformation: ").Append(PromotionInformation).Append("\n");
            sb.Append("  TokenInformation: ").Append(TokenInformation).Append("\n");
            sb.Append("  RiskInformation: ").Append(RiskInformation).Append("\n");
            sb.Append("  AcquirerInformation: ").Append(AcquirerInformation).Append("\n");
            sb.Append("  RecurringPaymentInformation: ").Append(RecurringPaymentInformation).Append("\n");
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
            return this.Equals(obj as CreatePaymentRequest);
        }

        /// <summary>
        /// Returns true if CreatePaymentRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CreatePaymentRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreatePaymentRequest other)
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
                    this.IssuerInformation == other.IssuerInformation ||
                    this.IssuerInformation != null &&
                    this.IssuerInformation.Equals(other.IssuerInformation)
                ) && 
                (
                    this.PaymentInformation == other.PaymentInformation ||
                    this.PaymentInformation != null &&
                    this.PaymentInformation.Equals(other.PaymentInformation)
                ) && 
                (
                    this.OrderInformation == other.OrderInformation ||
                    this.OrderInformation != null &&
                    this.OrderInformation.Equals(other.OrderInformation)
                ) && 
                (
                    this.BuyerInformation == other.BuyerInformation ||
                    this.BuyerInformation != null &&
                    this.BuyerInformation.Equals(other.BuyerInformation)
                ) && 
                (
                    this.RecipientInformation == other.RecipientInformation ||
                    this.RecipientInformation != null &&
                    this.RecipientInformation.Equals(other.RecipientInformation)
                ) && 
                (
                    this.DeviceInformation == other.DeviceInformation ||
                    this.DeviceInformation != null &&
                    this.DeviceInformation.Equals(other.DeviceInformation)
                ) && 
                (
                    this.MerchantInformation == other.MerchantInformation ||
                    this.MerchantInformation != null &&
                    this.MerchantInformation.Equals(other.MerchantInformation)
                ) && 
                (
                    this.AggregatorInformation == other.AggregatorInformation ||
                    this.AggregatorInformation != null &&
                    this.AggregatorInformation.Equals(other.AggregatorInformation)
                ) && 
                (
                    this.ConsumerAuthenticationInformation == other.ConsumerAuthenticationInformation ||
                    this.ConsumerAuthenticationInformation != null &&
                    this.ConsumerAuthenticationInformation.Equals(other.ConsumerAuthenticationInformation)
                ) && 
                (
                    this.PointOfSaleInformation == other.PointOfSaleInformation ||
                    this.PointOfSaleInformation != null &&
                    this.PointOfSaleInformation.Equals(other.PointOfSaleInformation)
                ) && 
                (
                    this.MerchantDefinedInformation == other.MerchantDefinedInformation ||
                    this.MerchantDefinedInformation != null &&
                    this.MerchantDefinedInformation.SequenceEqual(other.MerchantDefinedInformation)
                ) && 
                (
                    this.InstallmentInformation == other.InstallmentInformation ||
                    this.InstallmentInformation != null &&
                    this.InstallmentInformation.Equals(other.InstallmentInformation)
                ) && 
                (
                    this.TravelInformation == other.TravelInformation ||
                    this.TravelInformation != null &&
                    this.TravelInformation.Equals(other.TravelInformation)
                ) && 
                (
                    this.PromotionInformation == other.PromotionInformation ||
                    this.PromotionInformation != null &&
                    this.PromotionInformation.Equals(other.PromotionInformation)
                ) && 
                (
                    this.TokenInformation == other.TokenInformation ||
                    this.TokenInformation != null &&
                    this.TokenInformation.Equals(other.TokenInformation)
                ) && 
                (
                    this.RiskInformation == other.RiskInformation ||
                    this.RiskInformation != null &&
                    this.RiskInformation.Equals(other.RiskInformation)
                ) && 
                (
                    this.AcquirerInformation == other.AcquirerInformation ||
                    this.AcquirerInformation != null &&
                    this.AcquirerInformation.Equals(other.AcquirerInformation)
                ) && 
                (
                    this.RecurringPaymentInformation == other.RecurringPaymentInformation ||
                    this.RecurringPaymentInformation != null &&
                    this.RecurringPaymentInformation.Equals(other.RecurringPaymentInformation)
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
                if (this.IssuerInformation != null)
                    hash = hash * 59 + this.IssuerInformation.GetHashCode();
                if (this.PaymentInformation != null)
                    hash = hash * 59 + this.PaymentInformation.GetHashCode();
                if (this.OrderInformation != null)
                    hash = hash * 59 + this.OrderInformation.GetHashCode();
                if (this.BuyerInformation != null)
                    hash = hash * 59 + this.BuyerInformation.GetHashCode();
                if (this.RecipientInformation != null)
                    hash = hash * 59 + this.RecipientInformation.GetHashCode();
                if (this.DeviceInformation != null)
                    hash = hash * 59 + this.DeviceInformation.GetHashCode();
                if (this.MerchantInformation != null)
                    hash = hash * 59 + this.MerchantInformation.GetHashCode();
                if (this.AggregatorInformation != null)
                    hash = hash * 59 + this.AggregatorInformation.GetHashCode();
                if (this.ConsumerAuthenticationInformation != null)
                    hash = hash * 59 + this.ConsumerAuthenticationInformation.GetHashCode();
                if (this.PointOfSaleInformation != null)
                    hash = hash * 59 + this.PointOfSaleInformation.GetHashCode();
                if (this.MerchantDefinedInformation != null)
                    hash = hash * 59 + this.MerchantDefinedInformation.GetHashCode();
                if (this.InstallmentInformation != null)
                    hash = hash * 59 + this.InstallmentInformation.GetHashCode();
                if (this.TravelInformation != null)
                    hash = hash * 59 + this.TravelInformation.GetHashCode();
                if (this.PromotionInformation != null)
                    hash = hash * 59 + this.PromotionInformation.GetHashCode();
                if (this.TokenInformation != null)
                    hash = hash * 59 + this.TokenInformation.GetHashCode();
                if (this.RiskInformation != null)
                    hash = hash * 59 + this.RiskInformation.GetHashCode();
                if (this.AcquirerInformation != null)
                    hash = hash * 59 + this.AcquirerInformation.GetHashCode();
                if (this.RecurringPaymentInformation != null)
                    hash = hash * 59 + this.RecurringPaymentInformation.GetHashCode();
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
