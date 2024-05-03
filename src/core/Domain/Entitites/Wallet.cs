using Domain.Entities.Commons;
using Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entitites;

public class Wallet : BaseEntity
{
    public Guid AccountId { get; set; }
    public double Balance { get; set; } = 0;
    public WithdrawMethodEnum WithdrawMethod { get; set; }
    [MaxLength(150)]
    public string WithdrawInformation { get; set; } = string.Empty;

    public virtual Account Account { get; set; } = default!;
    //public virtual ICollection<WalletHistory> WalletHistories { get; set; } = new List<WalletHistory>();
}
