// Models/Loan.cs


public class Loan
{
    public int Id { get; set; }
    public int BookId { get; set; }
    public int MemberId { get; set; }
    public DateTime LoanDate { get; set; }
    public DateTime ReturnDate { get; set; }
    public bool IsReturned { get; set; }

    public virtual Book Book { get; set; }
    public virtual Member Member { get; set; }
}
