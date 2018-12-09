using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class MoveTest {

    [Test]
    public void MoveTestSimplePasses() {
        // Use the Assert class to test conditions.
    }

    // A UnityTest behaves like a coroutine in PlayMode
    // and allows you to yield null to skip a frame in EditMode
    [UnityTest]
    public IEnumerator MoveTestWithEnumeratorPasses() {
        // Use the Assert class to test conditions.
        // yield to skip a frame
        yield return null;
    }

    [UnityTest]
    public IEnumerator PlayerCanMove() {
        var player = new GameObject();
        player.AddComponent<PlayerController>();
        player.AddComponent<Rigidbody>();
        var posn = player.transform.position;

        yield return new WaitForFixedUpdate();

        var move = player.GetComponent<PlayerController>();
        move.Movement();

        Assert.AreNotEqual(posn, player.transform.position);
    }

    [UnityTest]
    public IEnumerator PlayerCanCollectFlannel() {
        var player = new GameObject();
        player.AddComponent<PlayerController>();
        var score = DBManager.score;

        yield return new WaitForFixedUpdate();

        var collect = player.GetComponent<PlayerController>();
        collect.WearFlannel();
        DBManager.score++;

        var expscore = score + 1;
        var newscore = DBManager.score;

        Assert.AreEqual(expscore, newscore);
    }

}
