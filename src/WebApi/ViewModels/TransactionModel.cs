namespace WebApi.ViewModels
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using Domain.Accounts.ValueObjects;

    /// <summary>
    ///     Transaction.
    /// </summary>
    public sealed class TransactionModel
    {
        public TransactionModel(PositiveMoney amount, string description, DateTime transactionDate)
        {
            this.Amount = amount.ToMoney().ToDecimal();
            this.Description = description;
            this.TransactionDate = transactionDate;
        }

        /// <summary>
        ///     Gets Amount.
        /// </summary>
        [Required]
        public decimal Amount { get; }

        /// <summary>
        ///     Gets Description.
        /// </summary>
        [Required]
        public string Description { get; }

        /// <summary>
        ///     Gets Transaction Date.
        /// </summary>
        [Required]
        public DateTime TransactionDate { get; }
    }
}
