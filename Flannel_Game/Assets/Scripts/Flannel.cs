using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flannel : MonoBehaviour {

    public GameObject self;
    public Material flannel;
    public Material stone;

    public bool isEmpty;

    // Use this for initialization
    void Start () {
        self.GetComponent<MeshRenderer>().material = flannel;
        isEmpty = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (isEmpty)
            self.GetComponent<MeshRenderer>().material = stone;
	}

}
