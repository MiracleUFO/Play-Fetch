using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float countDown = 1.0f;

    // Update is called once per frame
    void Update()
    {
        countDown += Time.deltaTime;

        // On spacebar press and if 1 second has elapsed between spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && countDown >= 1)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);

            // Reinstantiates countdown
            countDown = 0.0f;
        }
    }
}
