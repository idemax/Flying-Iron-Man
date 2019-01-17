using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Enemy : MonoBehaviour {
    public static int index = 0;

    int instanceIndex;
    float speedRate = 0.0f;
    float speedRateBase;
    float objectScale;
    float delay = 0.0f;

    void Start () {
        instanceIndex = index++;
        // speedRateBase = Random.Range (3.0f, 6.0f);

        Debug.Log (instanceIndex);

        transform.position = new Vector3 (
            18.0f,
            transform.position.y,
            transform.position.z
        );
    }

    void Update () {
        delay += Time.deltaTime;

        if (transform.position.x <= 16.0f && transform.position.x >= -25.0f) {
            if (delay > (2.0f * instanceIndex)) {
                transform.Translate (Vector3.left * Time.deltaTime * (speedRateBase + speedRate));
            }
        }
        else {
            float yPos = Random.Range (-6.0f, 6.0f);

            speedRate += 0.01f;
            speedRateBase = Random.Range (3.0f, 6.0f);
            objectScale = Random.Range (0.2f, 0.6f);

            transform.position = new Vector3 (16.0f, yPos, transform.position.z);
            transform.localScale = new Vector3 (objectScale, objectScale, transform.localScale.z);
        }
    }
}
