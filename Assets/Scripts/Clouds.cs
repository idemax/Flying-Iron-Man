using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Clouds : MonoBehaviour {
    public List<GameObject> CloudsMap;
    float delay = 0.0f;
    float speedRate = 0.0f;

    void Start () {
        foreach (Transform cloud in transform) {
            if (cloud.tag == "Cloud") {
                CloudsMap.Add (cloud.gameObject);
                cloud.gameObject.transform.position = new Vector3 (17.0f, cloud.gameObject.transform.position.y, cloud.gameObject.transform.position.z);
                // cloud.gameObject.transform.GetComponent<SpriteRenderer> ().orderInLayer = Random.Range (-1, 1);
            }
        }
    }

    void Update () {
        int delayIndex = 0;

        delay += Time.deltaTime;

        foreach (GameObject cloud in CloudsMap) {
            if (cloud.transform.position.x <= 16.0f && cloud.transform.position.x >= -25.0f) {
                if (delay > 2.0f * delayIndex++) {
                    cloud.transform.Translate (Vector3.left * Time.deltaTime * (5.0f + speedRate));
                }
            }
            else {
                float yPos = Random.Range (-6.0f, 6.0f);

                cloud.gameObject.transform.position = new Vector3 (16.0f, yPos, cloud.gameObject.transform.position.z);
                // cloud.gameObject.transform.position = new Vector3 (16.0f, cloud.gameObject.transform.position.y, cloud.gameObject.transform.position.z);

                delayIndex++;
                speedRate += 0.01f;
            }
        }
    }
}
