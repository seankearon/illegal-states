using Bogus;

namespace IllegalStatesCS.Tests;

public static class TestData
{
    public static Contact NewContact()
    {
        var faker = new Faker<Contact>()
            .RuleFor(c => c.FirstName, f => f.Name.FirstName())
            .RuleFor(c => c.MiddleInitial, f => f.Name.FirstName().Substring(0, 1))
            .RuleFor(c => c.LastName, f => f.Name.LastName())
            .RuleFor(c => c.EmailAddress, f => f.Internet.Email())
            .RuleFor(c => c.IsEmailVerified, f => f.Random.Bool(0.7f))
            .RuleFor(c => c.Address1, f => f.Address.StreetAddress())
            .RuleFor(c => c.Address2, f => f.Address.SecondaryAddress())
            .RuleFor(c => c.City, f => f.Address.City())
            .RuleFor(c => c.State, f => f.Address.StateAbbr())
            .RuleFor(c => c.Zip, f => f.Address.ZipCode())
            .RuleFor(c => c.IsAddressValid, f => f.Random.Bool(0.8f));
        
        return faker.Generate();
    }
}