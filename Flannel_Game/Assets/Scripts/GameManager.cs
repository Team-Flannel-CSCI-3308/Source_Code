using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public bool created = false;

    public GameObject player;
    public GameObject enemy;

    public Scene currentScene;

    private void Awake() {
        if (!created) {
            DontDestroyOnLoad(this.gameObject);
            created = true;
            Debug.Log("Awake: " + this.gameObject);
        }
    }

    // Use this for initialization
    void Start () {
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
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
