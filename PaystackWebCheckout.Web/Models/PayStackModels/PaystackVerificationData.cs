using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PaystackWebCheckout.Web.Models.PayStackModels
{
    public class PaystackVerificationData
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("domain")]
        public string Domain { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("reference")]
        public string Reference { get; set; }

        [JsonPropertyName("receipt_number")]
        public string ReceiptNumber { get; set; }

        [JsonPropertyName("amount")]
        public decimal Amount { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("gateway_response")]
        public string GatewayResponse { get; set; }

        [JsonPropertyName("paid_at")]
        public DateTime PaidAt { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("channel")]
        public string Channel { get; set; }

        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("ip_address")]
        public string IpAddress { get; set; }

        [JsonPropertyName("metadata")]
        public PayStackVerificationMetaData MetaData { get; set; }

        [JsonPropertyName("log")]
        public PayStackVerificationLog Log { get; set; }

        [JsonPropertyName("history")]
        public List<PayStackHistoryItem> History { get; set; } = new List<PayStackHistoryItem>();

        [JsonPropertyName("fees")]
        public decimal Fees { get; set; }

        [JsonPropertyName("fees_split")]
        public object FeesSplit { get; set; }

        [JsonPropertyName("authorization")]
        public PayStackVerificationAuthorization Authorization { get; set; }

        [JsonPropertyName("customer")]
        public PayStackCustomerVerification Customer { get; set; }

        [JsonPropertyName("plan")]
        public object Plan { get; set; }

        [JsonPropertyName("split")]
        public object Split { get; set; }

        [JsonPropertyName("order_id")]
        public object OrderId { get; set; }


        [JsonPropertyName("requested_amount")]
        public object RequestedAmount { get; set; }

        [JsonPropertyName("pos_transaction_data")]
        public object PosTransactionData { get; set; }

        [JsonPropertyName("source")]
        public object Source { get; set; }

        [JsonPropertyName("fees_breakdown")]
        public List<PayStackVerificationFeeBreakdown> FeesBreakdown { get; set; } = new List<PayStackVerificationFeeBreakdown>();

        [JsonPropertyName("connect")]
        public object Connect { get; set; }

        [JsonPropertyName("transaction_date")]
        public DateTime TransactionDate { get; set; }

        [JsonPropertyName("plan_object")]
        public object PlanObject { get; set; }

        [JsonPropertyName("subaccount")]
        public object SubAccount { get; set; }
    }
}
