using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeAway : MonoBehaviour
{
    public float earliesFade = 10.0f;
    public float latestFade = 20.0f;
    private float timeToDestruction;

    void Start()
    {
        timeToDestruction = Random.Range(earliesFade,latestFade);
    }
        // Update is called once per frame
        void Update()
    {
        timeToDestruction -= Time.deltaTime;

        if (timeToDestruction < 0)
        {
            gameObject.SetActive(false);
        }
    }
}
