using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flannel : MonoBehaviour {

    public GameObject self;
    public Material flannel;
    public Material stone;

    public bool isEmpty;

    public float delay = 3f;

    // Use this for initialization
    void Start () {
        self.GetComponent<MeshRenderer>().material = flannel;
        isEmpty = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (isEmpty) {
            self.GetComponent<MeshRenderer>().material = stone;
            StartCoroutine(Activate());
        } else {
            self.GetComponent<MeshRenderer>().material = flannel;
            StopCoroutine(Activate());
        }
	}

    public IEnumerator Activate() {     
        yield return new WaitForSeconds(delay);
        isEmpty = false;
    }

}
