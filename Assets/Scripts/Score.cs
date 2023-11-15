using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public int score;
    public int highScore = 0;
    public TextMeshProUGUI scoreUI;
    public TextMeshProUGUI highScoreUI;

    // Start is called before the first frame update
    void Start()
    {
        //PlayerPrefs.DeleteAll(); - to clear the high score
        highScore = PlayerPrefs.GetInt("highscore");
    }

    // Update is called once per frame
    void Update()
    {
        scoreUI.text = score.ToString();
        highScoreUI.text = highScore.ToString();
        if(score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("highscore", highScore);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "score_up")
        {
            score++;
        }
    }
}
