using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    [SerializeField]
    private int startCountdown = 10;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EndGameOver());
    }

    IEnumerator EndGameOver()
    {
        while(startCountdown > 0)
        {
            yield return new WaitForSeconds(1f);
            this.startCountdown--;
        }
        SceneManager.LoadScene("menu");
    }
}
