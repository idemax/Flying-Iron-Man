using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class Ironman : MonoBehaviour {
    GameObject scoreTextObject;
    private Text scoreText;
    private int scoreInstance;

    void Start () {
        scoreTextObject = GameObject.FindWithTag("ScoreText"); 

        if (scoreTextObject != null)
        {
            scoreText = scoreTextObject.GetComponent<Text>();
        }

        scoreInstance = 0;

        updateScore ();
    }

    private void updateScore ()
    {
        scoreText.text = scoreInstance.ToString ();
    }

    private void OnTriggerEnter2D (Collider2D other) {
        Debug.Log ("iron: " + other.gameObject.name);

        scoreInstance++;

        updateScore ();
    }

    void Update () {
        float moveSpeed = 10.0f;

        if (Input.GetKey (KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            transform.position += Vector3.up * moveSpeed * Time.deltaTime / 2;
        else if (Input.GetKey (KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            transform.position += -Vector3.up * moveSpeed * Time.deltaTime / 2;
    }
}
