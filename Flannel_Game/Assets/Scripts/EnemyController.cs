using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyController : MonoBehaviour {

    private static bool created = false;

    public GameObject self; // the enemy model is a child of the parent to which this script is applied
                            // set this variable to the child object
    public Material enemy;
    public Material stone;

    public bool isAlive;
    
    private void Awake() {
        if (!created) {
            DontDestroyOnLoad(this.gameObject);
            created = true;
            Debug.Log("Awake: " + this.gameObject);
        }
    }

    // Use this for initialization
    void Start() {
        self.GetComponent<MeshRenderer>().material = enemy;
        
        /*
        if (GetComponent<EnemyCombat>().health == 0)
            isAlive = false;
        else
            isAlive = true;
        
        Scene currentScene = SceneManager.GetActiveScene();
        if (currentScene.name == "combat") {
            GetComponent<EnemyCombat>().enabled = true;
            GetComponent<EnemyController>().enabled = false;
        } else if (currentScene.name == "main") {
            GetComponent<EnemyCombat>().enabled = false;
            GetComponent<EnemyController>().enabled = true;
        }
        */
    }
	
	// Update is called once per frame
	void Update() {
        if (!isAlive)
            self.GetComponent<MeshRenderer>().material = stone;
	}

    void OnMouseOver() {
        if (Input.GetMouseButtonDown(0))
            SceneManager.LoadScene("combat");
    }
}
