namespace IllegalStatesCS;

public record Contact
{
    public string FirstName     { get; init; } = "";
    public string MiddleInitial { get; init; } = "";
    public string LastName      { get; init; } = "";

    public string EmailAddress  { get; init; } = "";
    public bool IsEmailVerified { get; init; }
    
    public string Address1 { get;      init; } = "";
    public string Address2 { get;      init; } = "";
    public string City     { get;      init; } = "";
    public string State    { get;      init; } = "";
    public string Zip      { get;      init; } = "";
    public bool IsAddressValid { get; init; }
}
