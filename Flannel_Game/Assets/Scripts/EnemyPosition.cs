using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPosition : MonoBehaviour {
    void Awake() {
        GameObject.Find("Enemy").transform.position = this.transform.position;
    }
}
