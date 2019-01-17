using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Ironman : MonoBehaviour {
    void Start () {

    }

    private void OnTriggerEnter2D (Collider2D other) {
        Debug.Log ("iron: " + other.gameObject.name);
    }

    void Update () {
        float moveSpeed = 10.0f;

        if (Input.GetKey (KeyCode.Q))
            transform.position += Vector3.up * moveSpeed * Time.deltaTime / 2;
        else if (Input.GetKey (KeyCode.E))
            transform.position += -Vector3.up * moveSpeed * Time.deltaTime / 2;
    }
}
