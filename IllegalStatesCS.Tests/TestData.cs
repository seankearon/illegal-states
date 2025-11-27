using Bogus;

namespace IllegalStatesCS.Tests;

public static class TestData
{
    public static Contact NewContact()
    {
        var faker = new Faker<Contact>()
            .RuleFor(c => c.Name, _ => NewPersonalName())
            .RuleFor(c => c.EmailContactInfo, _ => NewEmailContactInfo())
            .RuleFor(c => c.AddressContactInfo, _ => NewAddressContactInfo());
        
        return faker.Generate();
    }

    public static PersonalName NewPersonalName()
    {
        var faker = new Faker();
        return new PersonalName
        {
            FirstName = faker.Name.FirstName(),
            MiddleInitial = faker.Name.FirstName().Substring(0, 1),
            LastName = faker.Name.LastName()
        };
    }

    public static EmailContactInfo NewEmailContactInfo()
    {
        var faker = new Faker();
        return new EmailContactInfo
        {
            EmailAddress = faker.Internet.Email(),
            IsEmailVerified = faker.Random.Bool(0.7f)
        };
    }

    public static AddressContactInfo NewAddressContactInfo()
    {
        var faker = new Faker();
        return new AddressContactInfo
        {
            Address = new Address
            {
                Address1 = faker.Address.StreetAddress(),
                Address2 = faker.Address.SecondaryAddress(),
                City = faker.Address.City(),
                State = faker.Address.StateAbbr(),
                Zip = faker.Address.ZipCode()
            },
            IsAddressValid = faker.Random.Bool(0.8f)
        };
    }
}