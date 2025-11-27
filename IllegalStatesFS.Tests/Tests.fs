module IllegalStatesFS.Tests

open System
open NUnit.Framework

[<Test>]
let ``Good contact`` () =
    TestData.newContact() |> Console.WriteLine
    
[<Test>]
let ``Bad contact`` () =
    TestData.newContact()
    |> fun c -> { c with EmailAddress = "BAD"  }
    |> Console.WriteLine    