using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class CountdownScript : MonoBehaviour
{
    [SerializeField]
    private int startCountdown = 300;

    [SerializeField]
    private Text countdownTxt;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Pause());
    }

    IEnumerator Pause()
    {
        while(startCountdown > 0)
        {
            yield return new WaitForSeconds(1f);
            this.startCountdown -= 1;
            TimeSpan time = TimeSpan.FromSeconds(startCountdown);
            this.countdownTxt.text = "Temps avant ouverture : " + time.ToString(@"m\:ss"); 
        }
        SceneManager.LoadScene("gameOverScene");
    }
}
