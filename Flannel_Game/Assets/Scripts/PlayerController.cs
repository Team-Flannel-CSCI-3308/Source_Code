using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float moveSpeed;
    public Material flannel;
    public GameObject self;
    public GameObject altar;

    public EnemyController enemy;

    private bool inRange = false;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void FixedUpdate() {
        Movement();
        WearFlannel();
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Flannel")) {
            inRange = true;
        }
    }

    void Movement() {
        if (Input.GetKey(KeyCode.W))
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.A))
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.S))
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.D))
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
    }

    void WearFlannel() {
        if (inRange && !enemy.isAlive) {
            if (Input.GetKey(KeyCode.E)) {
                self.GetComponent<MeshRenderer>().material = flannel;
                Flannel flannelScript = altar.GetComponent<Flannel>();
                flannelScript.isEmpty = true;
            }
        }
    }

}
