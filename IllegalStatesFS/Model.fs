namespace IllegalStateFS

type Contact = {
    FirstName    : string;
    MiddleInitial: string;
    LastName     : string;

    EmailAddress   : string;
    IsEmailVerified: bool;

    Address1      : string;
    Address2      : string;
    City          : string;
    State         : string;
    Zip           : string;
    IsAddressValid: bool;
}