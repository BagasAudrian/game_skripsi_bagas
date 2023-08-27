using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SoalManager : MonoBehaviour
{
    [SerializeField] private LevelSoalPlayerPrefs currentLevel;

    [SerializeField] private GameObject[] PanelSoal;

    [Header("Text Components")]
    [SerializeField] private TextMeshProUGUI Soal1;
    [SerializeField] private TextMeshProUGUI[] Soal1Jawaban;

    [SerializeField] private TextMeshProUGUI Soal2;
    [SerializeField] private TextMeshProUGUI[] Soal2Jawaban;

    [SerializeField] private TextMeshProUGUI Soal3;
    [SerializeField] private TextMeshProUGUI[] Soal3Jawaban;

    [SerializeField] private TextMeshProUGUI Soal4;
    [SerializeField] private TextMeshProUGUI[] Soal4Jawaban;

    [SerializeField] private TextMeshProUGUI Soal5;
    [SerializeField] private TextMeshProUGUI[] Soal5Jawaban;

    [SerializeField] private TextMeshProUGUI Soal6;
    [SerializeField] private TextMeshProUGUI[] Soal6Jawaban;

    [SerializeField] private TextMeshProUGUI Soal7;
    [SerializeField] private TextMeshProUGUI[] Soal7Jawaban;

    [SerializeField] private TextMeshProUGUI Soal8;
    [SerializeField] private TextMeshProUGUI[] Soal8Jawaban;

    [SerializeField] private TextMeshProUGUI Soal9;
    [SerializeField] private TextMeshProUGUI[] Soal9Jawaban;

    [SerializeField] private TextMeshProUGUI Soal10;
    [SerializeField] private TextMeshProUGUI[] Soal10Jawaban;

    public string jawabanBenarSoal1, jawabanBenarSoal2, jawabanBenarSoal3, jawabanBenarSoal4,
                   jawabanBenarSoal5, jawabanBenarSoal6, jawabanBenarSoal7, jawabanBenarSoal8,
                   jawabanBenarSoal9, jawabanBenarSoal10;

    public int currentSoal;
    public int currentScore;
    public TextMeshProUGUI scoreText;

    private void Start()
    {
        currentScore = 0;

        jawabanBenarSoal1 = PlayerPrefs.GetString(currentLevel.Soal1Jawaban[0]);
        jawabanBenarSoal2 = PlayerPrefs.GetString(currentLevel.Soal2Jawaban[0]);
        jawabanBenarSoal3 = PlayerPrefs.GetString(currentLevel.Soal3Jawaban[0]);
        jawabanBenarSoal4 = PlayerPrefs.GetString(currentLevel.Soal4Jawaban[0]);
        jawabanBenarSoal5 = PlayerPrefs.GetString(currentLevel.Soal5Jawaban[0]);
        jawabanBenarSoal6 = PlayerPrefs.GetString(currentLevel.Soal6Jawaban[0]);
        jawabanBenarSoal7 = PlayerPrefs.GetString(currentLevel.Soal7Jawaban[0]);
        jawabanBenarSoal8 = PlayerPrefs.GetString(currentLevel.Soal8Jawaban[0]);
        jawabanBenarSoal9 = PlayerPrefs.GetString(currentLevel.Soal9Jawaban[0]);
        jawabanBenarSoal10 = PlayerPrefs.GetString(currentLevel.Soal10Jawaban[0]);

        Debug.Log("jawaban soal 1 = " + jawabanBenarSoal1);
        Debug.Log("jawaban soal 2 = " + jawabanBenarSoal2);
        Debug.Log("jawaban soal 3 = " + jawabanBenarSoal3);
        Debug.Log("jawaban soal 4 = " + jawabanBenarSoal4);
        Debug.Log("jawaban soal 5 = " + jawabanBenarSoal5);
        Debug.Log("jawaban soal 6 = " + jawabanBenarSoal6);
        Debug.Log("jawaban soal 7 = " + jawabanBenarSoal7);
        Debug.Log("jawaban soal 8 = " + jawabanBenarSoal8);
        Debug.Log("jawaban soal 9 = " + jawabanBenarSoal9);
        Debug.Log("jawaban soal 10 = " + jawabanBenarSoal10);

        FilledSoal();

        currentSoal = 1;
    }

    private void Update()
    {
        ShowingPanel();
    }

    private void FilledSoal()
    {
        Soal1.text = PlayerPrefs.GetString(currentLevel.Soal1);
        RandomizeAndDisplayAnswers(Soal1Jawaban, currentLevel.Soal1Jawaban);

        Soal2.text = PlayerPrefs.GetString(currentLevel.Soal2);
        RandomizeAndDisplayAnswers(Soal2Jawaban, currentLevel.Soal2Jawaban);

        Soal3.text = PlayerPrefs.GetString(currentLevel.Soal3);
        RandomizeAndDisplayAnswers(Soal3Jawaban, currentLevel.Soal3Jawaban);

        Soal4.text = PlayerPrefs.GetString(currentLevel.Soal4);
        RandomizeAndDisplayAnswers(Soal4Jawaban, currentLevel.Soal4Jawaban);

        Soal5.text = PlayerPrefs.GetString(currentLevel.Soal5);
        RandomizeAndDisplayAnswers(Soal5Jawaban, currentLevel.Soal5Jawaban);

        Soal6.text = PlayerPrefs.GetString(currentLevel.Soal6);
        RandomizeAndDisplayAnswers(Soal6Jawaban, currentLevel.Soal6Jawaban);

        Soal7.text = PlayerPrefs.GetString(currentLevel.Soal7);
        RandomizeAndDisplayAnswers(Soal7Jawaban, currentLevel.Soal7Jawaban);

        Soal8.text = PlayerPrefs.GetString(currentLevel.Soal8);
        RandomizeAndDisplayAnswers(Soal8Jawaban, currentLevel.Soal8Jawaban);

        Soal9.text = PlayerPrefs.GetString(currentLevel.Soal9);
        RandomizeAndDisplayAnswers(Soal9Jawaban, currentLevel.Soal9Jawaban);

        Soal10.text = PlayerPrefs.GetString(currentLevel.Soal10);
        RandomizeAndDisplayAnswers(Soal10Jawaban, currentLevel.Soal10Jawaban);
    }

    private void RandomizeAndDisplayAnswers(TextMeshProUGUI[] SoalJawaban, string[] SoalJawabPlayerPrefs)
    {
        int[] randomIndexes = GenerateRandomIndexes(SoalJawabPlayerPrefs.Length);

        for (int i = 0; i < SoalJawaban.Length; i++)
        {
            int randomIndex = randomIndexes[i];
            SoalJawaban[i].text = PlayerPrefs.GetString(SoalJawabPlayerPrefs[randomIndex]);
        }
    }

    private int[] GenerateRandomIndexes(int length)
    {
        int[] indexes = new int[length];
        for (int i = 0; i < length; i++)
        {
            indexes[i] = i;
        }

        for (int i = 0; i < length; i++)
        {
            int temp = indexes[i];
            int randomIndex = Random.Range(i, length);
            indexes[i] = indexes[randomIndex];
            indexes[randomIndex] = temp;
        }

        return indexes;
    }

    public void ShowingPanel()
    {
        if(currentSoal > PanelSoal.Length)
        {
            Debug.Log("win");
            scoreText.text = "Score : " + currentScore.ToString("0");
        }
        else
        {
            for (int i = 0; i < PanelSoal.Length; i++)
            {
                PanelSoal[i].SetActive(false);
            }

            PanelSoal[currentSoal - 1].SetActive(true);
        }
    }
}
