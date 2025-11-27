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
        var contact = TestData.NewContact();
        var badContact = contact with { EmailAddress = "BAD" };
        badContact.Dump();
    }
}