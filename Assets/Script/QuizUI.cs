using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Collections;

public class QuizUI : MonoBehaviour
{
    /*public Text questionText;
    public quizData[options] optionTexts; // Gunakan array jika Anda ingin menampilkan beberapa opsi
    
    [SerializeField] GameObject gameManager;
    private List<QuizQuestion> quizData;
    private int currentQuestionIndex = 0;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        quizData = gameManager.quizData;

        // Memastikan jumlah opsi sesuai dengan yang ada di objek teks (Text) yang Anda gunakan
        if (optionTexts.Length != 4) // Misalnya, kita asumsikan ada 4 opsi
        {
            Debug.LogError("Harap tambahkan 4 objek teks (Text) untuk opsi jawaban!");
            return;
        }

        DisplayCurrentQuestion();
    }

    private void DisplayCurrentQuestion()
    {
        if (currentQuestionIndex >= 0 && currentQuestionIndex < quizData.Count)
        {
            QuizQuestion currentQuestion = quizData[currentQuestionIndex];
            questionText.text = currentQuestion.question;

            for (int i = 0; i < 4; i++)
            {
                optionTexts[i].text = currentQuestion.options[i];
            }
        }
        else
        {
            Debug.LogError("Index pertanyaan tidak valid atau data quiz kosong!");
        }
    }

    public void NextQuestion()
    {
        currentQuestionIndex++;
        DisplayCurrentQuestion();
    }

    // Metode lain yang dibutuhkan sesuai dengan kebutuhan Anda*/
}
