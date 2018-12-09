using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    // public bool created = false;

    public GameObject player;
    public GameObject enemy;

    public Scene currentScene;

    public Text playerDisplay;
    public Text scoreDisplay;

    private void Awake() {
        if(DBManager.username == null) {
            SceneManager.LoadScene(0);
        }
        playerDisplay.text = "Player: " + DBManager.username;
        scoreDisplay.text = "Score: " + DBManager.score;

        /* 
        if (!created) {
            DontDestroyOnLoad(this.gameObject);
            created = true;
            Debug.Log("Awake: " + this.gameObject);
        }
        */
    }

    public void CallSaveData() {
        StartCoroutine(SavePlayerData());
    }

    IEnumerator SavePlayerData() {
        WWWForm form = new WWWForm();
        form.AddField("name", DBManager.username);
        form.AddField("score", DBManager.score);

        WWW www = new WWW("http://localhost/sqlconnect/savedata.php", form);
        yield return www;
        if (www.text == "0") {
            Debug.Log("Game saved");
        } else {
            Debug.Log("Save failed with error " + www.text);
        }

        DBManager.LogOut();
        SceneManager.LoadScene(0);
    }

    public void IncreaseScore() {
        DBManager.score++;
        scoreDisplay.text = "Score: " + DBManager.score;
    }

    // Use this for initialization
    void Start () {
        /*
        currentScene = SceneManager.GetActiveScene();
        if (currentScene.name == "combat") {
            player.transform.position = new Vector3(-2, 0.5f, 0);
            enemy.transform.position = new Vector3(2, 0.5f, 0);

            player.GetComponent<PlayerCombat>().enabled = true;
            player.GetComponent<PlayerController>().enabled = false;

            enemy.GetComponent<EnemyCombat>().enabled = true;
            enemy.GetComponent<EnemyController>().enabled = false;
        } else if (currentScene.name == "main") {
            player.transform.position = new Vector3(0f, 0.5f, 0f);
            enemy.transform.position = new Vector3(0f, 0.5f, 3f);

            player.GetComponent<PlayerCombat>().enabled = false;
            player.GetComponent<PlayerController>().enabled = true;

            enemy.GetComponent<EnemyCombat>().enabled = false;
            enemy.GetComponent<EnemyController>().enabled = true;
        }
        */
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
