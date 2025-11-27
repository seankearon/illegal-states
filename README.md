# Illegal States

Code for a lightning talk on making illegal states unrepresentable in C# and F#.

The code follows Scott Wlashin's excellent [Designing with types](https://fsharpforfunandprofit.com/posts/designing-with-types-intro/#series-toc) blog series.

There are tests for each language, but these don't assert that the code is correct, they just show the shape of the data in the console:

![img.png](img.png)

# How to follow

Start at the `main` branch, then follow the branches by number. 

## Main

This is the starting point.  It shows a naive implementation of a contact type and how that's not safe.

```csharp
public record Contact
{
    public string FirstName     { get; init; } = "";
    public string MiddleInitial { get; init; } = "";
    public string LastName      { get; init; } = "";

    public string EmailAddress  { get; init; } = "";
    public bool IsEmailVerified { get; init; }
    
    public string Address1 { get;      init; } = "";
    public string Address2 { get;      init; } = "";
    public string City     { get;      init; } = "";
    public string State    { get;      init; } = "";
    public string Zip      { get;      init; } = "";
    public bool IsAddressValid { get; init; }
}
```