using Vogen;

namespace IllegalStatesCS.Tests;

public class Tests
{
    [Test]
    public void EmailAddressesHaveValueSemantics()
    {
        var e1 = EmailAddress.From("kenny@south.park");
        var e2 = EmailAddress.From("kenny@south.park");
        Assert.That(e1, Is.EqualTo(e2));
    }
    
    [Test]
    public void IllegalEmailAddressesCannotBeRepresented()
    {
        Assert.Throws<ValueObjectValidationException>(() => EmailAddress.From("BAD"), "should not be able to represent bad email addresses in the domain");
    }
    
    [Test]
    public void GoodContact()
    {
        TestData.NewContact().Dump();
    }
    
    [Test]
    public void BadContact()
    {
        var badEmail   = TestData.NewEmailContactInfo() with { EmailAddress = EmailAddress.From("BAD") };
        var badContact = TestData.NewContact() with { EmailContactInfo =  badEmail};
        badContact.Dump();
    }
}