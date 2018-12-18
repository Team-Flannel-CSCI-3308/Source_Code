using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class LoginTest {

    [Test]
    public void LoginTestSimplePasses() {
        // Use the Assert class to test conditions.
    }

    // A UnityTest behaves like a coroutine in PlayMode
    // and allows you to yield null to skip a frame in EditMode
    [UnityTest]
    public IEnumerator LoginTestWithEnumeratorPasses() {
        // Use the Assert class to test conditions.
        // yield to skip a frame
        yield return null;
    }

    [Test]
    public void UserLoadsScoreOnLogin() {
        var score = DBManager.score;
        var player = new GameObject();
        
        Assert.AreEqual(0, score);
    }

    [Test]
    public void UserSavesScoreOnLogout() {
        var expscore = DBManager.score;
        DBManager.LogOut();
        var score = DBManager.score;
        Assert.AreEqual(expscore, score);
    }
}
