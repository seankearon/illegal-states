module IllegalStatesFS.Tests

open System
open IllegalStateFS
open NUnit.Framework

[<Test>]
let ``Good contact`` () =
    TestData.newContact() |> Console.WriteLine
    
[<Test>]
let ``Bad contact`` () =
    TestData.newContact()
    |> fun c -> { c with EmailContactInfo = { TestData.newEmailContactInfo() with EmailAddress = EmailAddress.from "BAD"} }
    |> Console.WriteLine    