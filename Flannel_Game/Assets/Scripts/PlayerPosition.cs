using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPosition : MonoBehaviour {
    void Awake() {
        GameObject.Find("Player").transform.position = this.transform.position;
    }
}
