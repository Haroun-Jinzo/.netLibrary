// Models/Member.cs

using System.ComponentModel.DataAnnotations;

public class Member
{
    public int Id { get; set; }

    [Required]
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public DateTime SubscriptionDate { get; set; }

    public ICollection<Loan> Loans { get; set; }
    public override string ToString()
    {
        return this.FirstName + " " + this.LastName;
    }
}