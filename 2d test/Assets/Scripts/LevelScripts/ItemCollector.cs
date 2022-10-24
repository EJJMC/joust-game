using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class ItemCollector : MonoBehaviour
{
    public TMP_Text score;
    public int scoreValue = 0;

    private void Update()
    {
        endGame();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Collectable"))
        {
            Destroy(collision.gameObject);
            scoreValue += 1;
            SetScore();
        }
    }
    void SetScore()
    {
        score.text = "Score: " + scoreValue;
    }

    void endGame()
    {
        if (scoreValue > 3)
        {
            SceneManager.LoadScene("End Screen");
            
            Debug.Log("endgame");
        }
    }
}
