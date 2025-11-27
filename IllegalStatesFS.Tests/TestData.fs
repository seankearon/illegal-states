module IllegalStatesFS.TestData

open Bogus
open IllegalStateFS

let newPersonalName () =
    let faker = Faker()
    {
        FirstName = faker.Name.FirstName()
        MiddleInitial = faker.Name.FirstName().[0].ToString()
        LastName = faker.Name.LastName()
    }

let newEmailContactInfo () =
    let faker = Faker()
    {
        EmailAddress = faker.Internet.Email()
        IsEmailVerified = faker.Random.Bool(0.7f)
    }

let newAddress () =
    let faker = Faker()
    {
        Address1 = faker.Address.StreetAddress()
        Address2 = faker.Address.SecondaryAddress()
        City = faker.Address.City()
        State = faker.Address.StateAbbr()
        Zip = faker.Address.ZipCode()
    }

let newAddressContactInfo () =
    let faker = Faker()
    {
        Address = newAddress ()
        IsAddressValid = faker.Random.Bool(0.8f)
    }

let newContact () : Contact =
    {
        Name = newPersonalName ()
        EmailContactInfo = newEmailContactInfo ()
        AddressContactInfo = newAddressContactInfo ()
    }

