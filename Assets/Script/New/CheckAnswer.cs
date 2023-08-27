using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CheckAnswer : MonoBehaviour
{
    [SerializeField] private SoalManager sm;
    [SerializeField] TMP_Text gameOverScore;
    [SerializeField] public int score = 0;

    public void _CheckingAnswer(int soalNomor)
    {
        if (soalNomor == 1)
        {
            TrueFalse(sm.jawabanBenarSoal1);
        }
        else if (soalNomor == 2)
        {
            TrueFalse(sm.jawabanBenarSoal2);
        }
        else if (soalNomor == 3)
        {
            TrueFalse(sm.jawabanBenarSoal3);
        }
        else if (soalNomor == 4)
        {
            TrueFalse(sm.jawabanBenarSoal4);
        }
        else if (soalNomor == 5)
        {
            TrueFalse(sm.jawabanBenarSoal5);
        }
        else if (soalNomor == 6)
        {
            TrueFalse(sm.jawabanBenarSoal6);
        }
        else if (soalNomor == 7)
        {
            TrueFalse(sm.jawabanBenarSoal7);
        }
        else if (soalNomor == 8)
        {
            TrueFalse(sm.jawabanBenarSoal8);
        }
        else if (soalNomor == 9)
        {
            TrueFalse(sm.jawabanBenarSoal9);
        }
        else if (soalNomor == 10)
        {
            TrueFalse(sm.jawabanBenarSoal10);
        }
    }

    private void TrueFalse(string jawaban)
    {
        if (gameObject.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>().text == jawaban)
        {
            Debug.Log("benar");
            sm.currentSoal += 1;
            score += 1;
            Debug.Log("skor= " + score);
        }
        else
        {
            Debug.Log("salah");
            sm.currentSoal += 1;
        }
    }
    void update()
    {
        gameOverScore.text = "Score: " + score.ToString();
    }
}
