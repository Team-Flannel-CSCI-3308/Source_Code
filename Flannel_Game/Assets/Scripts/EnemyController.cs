using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    public GameObject self;
    public Material enemy;
    public Material stone;

    public bool isAlive;

    // Use this for initialization
    void Start() {
        self.GetComponent<MeshRenderer>().material = enemy;
        isAlive = true;
	}
	
	// Update is called once per frame
	void Update() {
        if (!isAlive)
            self.GetComponent<MeshRenderer>().material = stone;
	}

    void OnMouseOver() {
        if (Input.GetMouseButtonDown(0))
            isAlive = false;
    }
}
