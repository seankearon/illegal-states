namespace IllegalStateFS

type PersonalName = {
    FirstName    : string
    MiddleInitial: string
    LastName     : string
}

type EmailAddress = private EmailAddress of string

module EmailAddress =
    let private isValidEmail (value: string) =
        System.Text.RegularExpressions.Regex.IsMatch(value, @"^\S+@\S+\.\S+$")

    let from (value: string) =
        if not (isValidEmail value) then
            failwith $"'{value}' is not a valid email address."
        EmailAddress value


type EmailContactInfo = {
    EmailAddress   : EmailAddress
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
