using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
//using Math;

public class TextAppear : MonoBehaviour
{
    public float OneLetterTime = 0.1f;

    private string Text;
    private int letterCounter = 0;
    private float CurrentWait = 0.0f;
    private TMP_Text tmpText;

    // Start is called before the first frame update
    void Start()
    {
        tmpText = GetComponent<TMP_Text>();
        Text = tmpText.text;
        tmpText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        CurrentWait += Time.deltaTime;

        if (CurrentWait > OneLetterTime)
        {
            CurrentWait -= OneLetterTime;

            tmpText.text = Text.Substring(0, letterCounter);

            if (letterCounter < Text.Length) { letterCounter++; }
        }

    }
}
