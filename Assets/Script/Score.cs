using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] TMP_Text gameOverScore;
    [SerializeField] int score = 0;
    public void jawabanbenar()
    {
        score +=1;
    }
    public void finish()
    {
        gameOverScore.text = "Score: " + score.ToString();
    }
}
