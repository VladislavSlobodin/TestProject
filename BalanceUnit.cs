namespace TestProject;
public enum BalanceType
{
    ActiveOpeningBalance,
    PassiveOpeningBalance,
    Debit,
    Credit,
    ActiveClosingBalance,
    PassiveClosingBalance
}

public class BalanceUnit
{
    public int Id { get; set; }
    public int AccountId { get; set; }
    public BalanceType BalanceType { get; set; }
    public int ClassId { get; set; }
    public decimal Value { get; set; }
}

//CreateTable(
//    "dbo.BalanceUnits",
//    c => new
//    {
//        Id = c.Int(nullable: false, identity: true),
//        AccountId = c.Int(nullable: false),
//        BalanceType = c.Int(nullable: false),
//        ClassId = c.Int(nullable: false),
//        Value = c.Decimal(nullable: false, precision: 18, scale: 2),
//    })
//    .PrimaryKey(t => t.Id);