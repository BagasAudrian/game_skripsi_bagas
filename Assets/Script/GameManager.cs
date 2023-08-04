using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using System.Collections.Generic;

[System.Serializable]
public class QuizQuestion
{
    public string question;
    public List<string> options;
    public int correctOptionIndex;
}


public class GameManager : MonoBehaviour
{
    [SerializeField]
    public List<QuizQuestion> quizData = new List<QuizQuestion>();

    // Metode untuk membaca file teks dan memuat data quiz
    public void LoadQuizFromFile(string fileName)
    {
        string filePath = fileName; // Jangan sertakan ekstensi .txt
        TextAsset quizTextAsset = Resources.Load<TextAsset>(filePath);

        if (quizTextAsset != null)
        {
            string quizContent = quizTextAsset.text;
            string[] questionBlocks = quizContent.Split(new string[] { "\n\n" }, System.StringSplitOptions.RemoveEmptyEntries);

            foreach (string questionBlock in questionBlocks)
            {
                string[] lines = questionBlock.Split(new string[] { "\n" }, System.StringSplitOptions.RemoveEmptyEntries);
                QuizQuestion currentQuestion = new QuizQuestion();

                foreach (string line in lines)
                {
                    if (line.StartsWith("Soal: "))
                    {
                        currentQuestion.question = line.Substring(6);
                        currentQuestion.options = new List<string>();
                    }
                    else if (line.StartsWith("Pilihan: "))
                    {
                        string option = line.Substring(9);
                        currentQuestion.options.Add(option);
                    }
                    else if (line.StartsWith("Jawaban: "))
                    {
                        int correctOptionIndex = int.Parse(line.Substring(9));
                        currentQuestion.correctOptionIndex = correctOptionIndex;
                    }
                }

                quizData.Add(currentQuestion);
            }
        }
        else
        {
            Debug.LogError("File tidak ditemukan: " + fileName);
        }
    }

    // Metode lain seperti BackToMainMenu, LevelMenu, dll. tetap sama seperti sebelumnya.
    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    // Metode lain seperti LevelMenu, GamePause, dll. tetap sama seperti sebelumnya.

    public void Level1()
    {
        // Panggil metode untuk memuat data quiz untuk level 1
        LoadQuizFromFile("quiz_level1");
        SceneManager.LoadScene("Level1");
    }

    public void Level2()
    {
        // Panggil metode untuk memuat data quiz untuk level 2
        LoadQuizFromFile("quiz_level2.txt");
        SceneManager.LoadScene("Level2");
    }

    public void Level3()
    {
        // Panggil metode untuk memuat data quiz untuk level 3
        LoadQuizFromFile("quiz_level3.txt");
        SceneManager.LoadScene("Level3");
    }

    // Metode lain seperti GamePause, CaraBermain, dll. tetap sama seperti sebelumnya.

    // Metode untuk membaca file teks dan memuat data quiz

    // Metode lain seperti PauseGame, ResumeGame, dll. tetap sama seperti sebelumnya.
   
    public void LevelMenu()
    {
        SceneManager.LoadScene("LevelMenu");
    }
  
    public void GamePause()
    {
        SceneManager.LoadScene("GamePause");
    }
    public void CaraBermain()
    {
        SceneManager.LoadScene("CaraBermain");
    }

}

