using Vogen;

namespace IllegalStatesCS;

public record PersonalName
{
    public string FirstName     { get; init; } = "";
    public string MiddleInitial { get; init; } = "";
    public string LastName      { get; init; } = "";
}

[ValueObject<string>]
public readonly partial struct EmailAddress
{
    private static Validation Validate(string value) =>
        ValidEmailRegex().IsMatch(value)
            ? Validation.Ok
            : Validation.Invalid($"'{value}' is not a valid email address.");
    
    [System.Text.RegularExpressions.GeneratedRegex(@"^\S+@\S+\.\S+$")]
    private static partial System.Text.RegularExpressions.Regex ValidEmailRegex();
}

public record EmailContactInfo
{
    public EmailAddress EmailAddress    { get; init; }
    public bool         IsEmailVerified { get; init; }
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