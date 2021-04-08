using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CounterScript : MonoBehaviour
{

    public static int counter;
    public static int score;
    Text scoreUI;
    public static int test = 33;

    void Start()
    {
        scoreUI = GetComponent<Text>();
        counter = 0;
        scoreUI.text = "" + test;
    }

    void Update()
    {
        scoreUI.text = "" + test;
        Debug.Log(counter.ToString());
    }
}
