namespace IllegalStatesCS;

public record PersonalName
{
    public string FirstName     { get; init; } = "";
    public string MiddleInitial { get; init; } = "";
    public string LastName      { get; init; } = "";
}

public record EmailContactInfo
{
    public string EmailAddress  { get; init; } = "";
    public bool IsEmailVerified { get; init; }
}

public record Address
{
    public string Address1 { get; init; } = "";
    public string Address2 { get; init; } = "";
    public string City     { get; init; } = "";
    public string State    { get; init; } = "";
    public string Zip      { get; init; } = "";
}

public record AddressContactInfo
{
    public Address Address { get; init; }
    public bool IsAddressValid { get; init; }
}

public record Contact
{
    public PersonalName Name { get; init; } = new();
    public EmailContactInfo EmailContactInfo { get; init; } = new();
    public AddressContactInfo AddressContactInfo { get; init; } = new();
}