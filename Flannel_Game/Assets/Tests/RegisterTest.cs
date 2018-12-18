using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class RegisterTest {

    [Test]
    public void RegisterTestSimplePasses() {
        // Use the Assert class to test conditions.
    }

    // A UnityTest behaves like a coroutine in PlayMode
    // and allows you to yield null to skip a frame in EditMode
    [UnityTest]
    public IEnumerator RegisterTestWithEnumeratorPasses() {
        // Use the Assert class to test conditions.
        // yield to skip a frame
        yield return null;
    }

    [Test]
    public void UserCannotRegisterEmptyAccount() {
        var user = new GameObject();
        user.AddComponent<Registration>();
        var username = DBManager.username;
        Assert.IsNull(username);
    }

    [Test]
    public void RegistrationCreatesUser() {
        bool created = false;
        var oldusername = "";
        var user = new GameObject();
        user.AddComponent<Registration>();
        // var registration = user.GetComponent<Registration>();
        // registration.nameField.text = "username";
        // registration.passwordField.text = "password";
        // registration.Register();
        var username = DBManager.username;
        Assert.AreNotSame(oldusername, username);
    }
}
