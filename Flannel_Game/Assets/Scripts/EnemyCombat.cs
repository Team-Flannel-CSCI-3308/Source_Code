using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCombat : MonoBehaviour {

    public int health, attack;

	// Use this for initialization
	void Start () {
        health = 5;
        attack = 1;
	}
	
	// Update is called once per frame
	void Update () {
        if (health == 0)
            GetComponent<EnemyController>().isAlive = false;
	}
}
