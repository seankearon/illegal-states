namespace IllegalStatesCS.Tests;

public class Tests
{
    [Test]
    public void GoodContact()
    {
        TestData.NewContact().Dump();
    }
    
    [Test]
    public void BadContact()
    {
        var badEmail   = TestData.NewEmailContactInfo() with { EmailAddress = "BAD" };
        var badContact = TestData.NewContact() with { EmailContactInfo =  badEmail};
        badContact.Dump();
    }
}