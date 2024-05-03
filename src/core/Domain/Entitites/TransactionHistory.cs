using Domain.Entities.Commons;
using Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entitites;

public class TransactionHistory : BaseEntity, ICreation
{
    public Guid? CreatedBy { get; set; }
    public Guid? ToAccountId { get; set; } // the id of creator account (when received coins from audience)
    public Guid? AssetId { get; set; }
    public Guid? ProposalId { get; set; }
    [MaxLength(150)]
    public string Detail { get; set; } = default!;
    public double Price { get; set; }
    public double WalletBalance { get; set; }
    public double Fee { get; set; } = 0;
    public TransactionStatusEnum TransactionStatus { get; set; } = TransactionStatusEnum.InProgress;
    public DateTime CreatedOn { get; set; }

    public virtual Account Account { get; set; } = default!;
    public virtual Account? ToAccount { get; set; }
    public virtual Asset? Asset { get; set; }
    public virtual Proposal? Proposal { get; set; }
}
