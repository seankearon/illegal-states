namespace IllegalStateFS

type PersonalName = {
    FirstName    : string
    MiddleInitial: string
    LastName     : string
}

type EmailContactInfo = {
    EmailAddress   : string
    IsEmailVerified: bool
}

type Address = {
    Address1: string
    Address2: string
    City    : string
    State   : string
    Zip     : string
}

type AddressContactInfo = {
    Address       : Address
    IsAddressValid: bool
}

type Contact = {
    Name              : PersonalName
    EmailContactInfo  : EmailContactInfo
    AddressContactInfo: AddressContactInfo
}
