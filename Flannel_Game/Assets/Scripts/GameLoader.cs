using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameLoader : MonoBehaviour {

    public Button startButton;

	// Use this for initialization
	void Start () {
        startButton.onClick.AddListener(LoadGame);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void LoadGame() {
        SceneManager.LoadScene("main");
    }
}
