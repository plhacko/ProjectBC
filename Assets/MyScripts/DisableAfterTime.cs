using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableAfterTime : MonoBehaviour
{
    public float TimeToDisable = 1.0f;
    private float CurrentWait = 0.0f;
    // Update is called once per frame
    void Update()
    {
        CurrentWait += Time.deltaTime;

        if (CurrentWait > TimeToDisable)
        {
            CurrentWait = 0.0f;
            gameObject.SetActive(false);
        }
    }
}
