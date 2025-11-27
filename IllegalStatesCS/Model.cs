namespace IllegalStatesCS;

public record Contact
{
    public string FirstName     { get; init; } = string.Empty;
    public string MiddleInitial { get; init; } = string.Empty;
    public string LastName      { get; init; } = string.Empty;
    public string EmailAddress  { get; init; } = string.Empty;

    /// <summary>True if ownership of email address is confirmed</summary>
    public bool IsEmailVerified { get; init; } = false;
    
    public string Address1 { get;      init; } = string.Empty;
    public string Address2 { get;      init; } = string.Empty;
    public string City     { get;      init; } = string.Empty;
    public string State    { get;      init; } = string.Empty;
    public string Zip      { get;      init; } = string.Empty;
    /// <summary>True if validated against address service</summary>
    public bool IsAddressValid { get; init; } = false;
}
