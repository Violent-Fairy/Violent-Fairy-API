using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Violent_Fairy.Domain.Tests;

[TestClass]
public class RatingTests
{
    [TestMethod]
    public void Can_Create_New_rating()
    {
        var rating = new Rating(1, "Mike", "Great fit!");

        Assert.AreEqual(1,rating.Stars);
        Assert.AreEqual("Mike",rating.UserName);
        Assert.AreEqual("Great fit!", rating.Review);
    }

    [TestMethod]
    [ExpectedException(typeof(argumentException))]
    public void Cannot_Create_Rating_With_Invalid_Stars(){
        var rating = new RatingTests(0, "Mike", "Great fit!");

    }

}