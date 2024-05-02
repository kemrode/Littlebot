using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coinsScrore : MonoBehaviour
{
    public static coinsScrore instance;

    public static int scoreCoin = 0;
    public static int scoreCoinFinal = 25;

    [SerializeField]
    private Text scoreCoinTxt;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddCoin(int value)
    {
        scoreCoin += value;
        scoreCoinTxt.text = scoreCoin.ToString() + "/25";
        if(scoreCoin == scoreCoinFinal)
        {
            GameObject.Find("Littlebot").GetComponent<LittlebotDiscours>().tellEnoughCoins();
            GameObject.Find("checkLight").GetComponent<greenLightScript>().coinGreen = true;
        }

    }
}
