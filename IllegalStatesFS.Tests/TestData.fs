module IllegalStatesFS.TestData

open Bogus
open IllegalStateFS

let newContact () : Contact =
    let faker = Faker()
    {
        FirstName       = faker.Name.FirstName()
        MiddleInitial   = faker.Name.FirstName().[0].ToString()
        LastName        = faker.Name.LastName()
        EmailAddress    = faker.Internet.Email()
        IsEmailVerified = faker.Random.Bool(0.7f)
        Address1        = faker.Address.StreetAddress()
        Address2        = faker.Address.SecondaryAddress()
        City            = faker.Address.City()
        State           = faker.Address.StateAbbr()
        Zip             = faker.Address.ZipCode()
        IsAddressValid  = faker.Random.Bool(0.8f)
    }
