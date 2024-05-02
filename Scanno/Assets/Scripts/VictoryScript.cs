using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryScript : MonoBehaviour
{
    public bool isActive = false;

    private int finalScoreBook;
    private int finalScoreCoin;
    private int booksCatch;
    private int coinsCatch;

    private int startCountdown = 5;

    // Start is called before the first frame update
    void Start()
    {
        this.finalScoreBook = bookScore.scoreBookFinal;
        this.finalScoreCoin = coinsScrore.scoreCoinFinal;
    }

    private void Update()
    {
        this.booksCatch = bookScore.scoreBook;
        this.coinsCatch = coinsScrore.scoreCoin;
        isConditiopnsReached();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && this.isActive == true)
        {
            SceneManager.LoadScene("endingScene");
        }
    }

    private bool isConditiopnsReached()
    {
        if (this.booksCatch >= this.finalScoreBook && this.coinsCatch >= this.finalScoreCoin) {
            //StartCoroutine(LastDialogue());
            return this.isActive = true;
        } else
        {
            return this.isActive = false;
        }
    }

    IEnumerator LastDialogue()
    {
        while(startCountdown > 0)
        {
            yield return new WaitForSeconds(3f);
            this.startCountdown--;
        }
        GameObject.Find("Littlebot").GetComponent<LittlebotDiscours>().tellEnd();
    }
}
