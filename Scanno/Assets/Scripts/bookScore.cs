using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bookScore : MonoBehaviour
{

    public static bookScore instance;

    public static int scoreBook = 0;
    public static int scoreBookFinal = 5;

    [SerializeField]
    private Text scoreBookTxt;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddBook(int value)
    {
        scoreBook += value;
        scoreBookTxt.text = scoreBook.ToString() + "/5";
        if (scoreBook >= scoreBookFinal)
        {
            GameObject.Find("checkLight").GetComponent<greenLightScript>().bookGreen = true;
        }
    }
}
