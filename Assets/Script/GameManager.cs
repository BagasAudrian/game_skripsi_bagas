using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TMP_InputField input_soal1;
    public TMP_InputField input_soal2;
    public TMP_InputField input_soal3;
    public TMP_InputField input_soal4;
    public TMP_InputField input_soal5;
    public TMP_InputField input_soal6;
    public TMP_InputField input_soal7;
    public TMP_InputField input_soal8;
    public TMP_InputField input_soal9;
    public TMP_InputField input_soal10;

    public TMP_InputField input_jawaban_benar1;
    public TMP_InputField input_jawaban_benar2;
    public TMP_InputField input_jawaban_benar3;
    public TMP_InputField input_jawaban_benar4;
    public TMP_InputField input_jawaban_benar5;
    public TMP_InputField input_jawaban_benar6;
    public TMP_InputField input_jawaban_benar7;
    public TMP_InputField input_jawaban_benar8;
    public TMP_InputField input_jawaban_benar9;
    public TMP_InputField input_jawaban_benar10;

    public TMP_InputField input_jawaban1_1;
    public TMP_InputField input_jawaban1_2;
    public TMP_InputField input_jawaban1_3;
    public TMP_InputField input_jawaban2_1;
    public TMP_InputField input_jawaban2_2;
    public TMP_InputField input_jawaban2_3;
    public TMP_InputField input_jawaban3_1;
    public TMP_InputField input_jawaban3_2;
    public TMP_InputField input_jawaban3_3;
    public TMP_InputField input_jawaban4_1;
    public TMP_InputField input_jawaban4_2;
    public TMP_InputField input_jawaban4_3;
    public TMP_InputField input_jawaban5_1;
    public TMP_InputField input_jawaban5_2;
    public TMP_InputField input_jawaban5_3;
    public TMP_InputField input_jawaban6_1;
    public TMP_InputField input_jawaban6_2;
    public TMP_InputField input_jawaban6_3;
    public TMP_InputField input_jawaban7_1;
    public TMP_InputField input_jawaban7_2;
    public TMP_InputField input_jawaban7_3;
    public TMP_InputField input_jawaban8_1;
    public TMP_InputField input_jawaban8_2;
    public TMP_InputField input_jawaban8_3;
    public TMP_InputField input_jawaban9_1;
    public TMP_InputField input_jawaban9_2;
    public TMP_InputField input_jawaban9_3;
    public TMP_InputField input_jawaban10_1;
    public TMP_InputField input_jawaban10_2;
    public TMP_InputField input_jawaban10_3;

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void Tentang()
    {
        SceneManager.LoadScene("Tentang");
    }
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
    public void SoalSetting()
    {
        SceneManager.LoadScene("SoalSetting");
    }
    public void Level1()
    {
        SceneManager.LoadScene("Level 1");
    }
    public void Level2()
    {
        SceneManager.LoadScene("Level 2");
    }
    public void Level3()
    {
        SceneManager.LoadScene("Level 3");
    }

    //public AudioSource lagu;

    //public void mulai()
    //{
    //    lagu.Play();
    //}
    //public void stoplagu()
    //{
    //    lagu.Stop();
    //}

    public void simpan_soal()
    {
        PlayerPrefs.SetString("soal1", input_soal1.text);
        PlayerPrefs.SetString("soal2", input_soal2.text);
        PlayerPrefs.SetString("soal3", input_soal3.text);
        PlayerPrefs.SetString("soal4", input_soal4.text);
        PlayerPrefs.SetString("soal5", input_soal5.text);
        PlayerPrefs.SetString("soal6", input_soal6.text);
        PlayerPrefs.SetString("soal7", input_soal7.text);
        PlayerPrefs.SetString("soal8", input_soal8.text);
        PlayerPrefs.SetString("soal9", input_soal9.text);
        PlayerPrefs.SetString("soal10", input_soal10.text);
    }
    public void soal()
    {
        input_soal1.text = PlayerPrefs.GetString("soal1");
        input_soal2.text = PlayerPrefs.GetString("soal2");
        input_soal3.text = PlayerPrefs.GetString("soal3");
        input_soal4.text = PlayerPrefs.GetString("soal4");
        input_soal5.text = PlayerPrefs.GetString("soal5");
        input_soal6.text = PlayerPrefs.GetString("soal6");
        input_soal7.text = PlayerPrefs.GetString("soal7");
        input_soal8.text = PlayerPrefs.GetString("soal8");
        input_soal9.text = PlayerPrefs.GetString("soal9");
        input_soal10.text = PlayerPrefs.GetString("soal10");
    }
    public void simpan_jawaban()
    {
      PlayerPrefs.SetString("jawaban1", input_jawaban_benar1.text);
      PlayerPrefs.SetString("jawaban2", input_jawaban_benar2.text);
      PlayerPrefs.SetString("jawaban3", input_jawaban_benar3.text);
      PlayerPrefs.SetString("jawaban4", input_jawaban_benar4.text);
      PlayerPrefs.SetString("jawaban5", input_jawaban_benar5.text);
      PlayerPrefs.SetString("jawaban6", input_jawaban_benar6.text);
      PlayerPrefs.SetString("jawaban7", input_jawaban_benar7.text);
      PlayerPrefs.SetString("jawaban8", input_jawaban_benar8.text);
      PlayerPrefs.SetString("jawaban9", input_jawaban_benar9.text);
      PlayerPrefs.SetString("jawaban10", input_jawaban_benar10.text);
    }
    public void simpan_jawaban_salah()
    {
        PlayerPrefs.SetString("jawaban1_1", input_jawaban1_1.text);
        PlayerPrefs.SetString("jawaban1_2", input_jawaban1_2.text);
        PlayerPrefs.SetString("jawaban1_3", input_jawaban1_3.text);
        PlayerPrefs.SetString("jawaban2_1", input_jawaban2_1.text);
        PlayerPrefs.SetString("jawaban2_2", input_jawaban2_2.text);
        PlayerPrefs.SetString("jawaban2_3", input_jawaban2_3.text);
        PlayerPrefs.SetString("jawaban3_1", input_jawaban3_1.text);
        PlayerPrefs.SetString("jawaban3_2", input_jawaban3_2.text);
        PlayerPrefs.SetString("jawaban3_3", input_jawaban3_3.text);
        PlayerPrefs.SetString("jawaban4_1", input_jawaban4_1.text);
        PlayerPrefs.SetString("jawaban4_2", input_jawaban4_2.text);
        PlayerPrefs.SetString("jawaban4_3", input_jawaban4_3.text);
        PlayerPrefs.SetString("jawaban5_1", input_jawaban5_1.text);
        PlayerPrefs.SetString("jawaban5_2", input_jawaban5_2.text);
        PlayerPrefs.SetString("jawaban5_3", input_jawaban5_3.text);
        PlayerPrefs.SetString("jawaban6_1", input_jawaban6_1.text);
        PlayerPrefs.SetString("jawaban6_2", input_jawaban6_2.text);
        PlayerPrefs.SetString("jawaban6_3", input_jawaban6_3.text);
        PlayerPrefs.SetString("jawaban7_1", input_jawaban7_1.text);
        PlayerPrefs.SetString("jawaban7_2", input_jawaban7_2.text);
        PlayerPrefs.SetString("jawaban7_3", input_jawaban7_3.text);
        PlayerPrefs.SetString("jawaban8_1", input_jawaban8_1.text);
        PlayerPrefs.SetString("jawaban8_2", input_jawaban8_2.text);
        PlayerPrefs.SetString("jawaban8_3", input_jawaban8_3.text);
        PlayerPrefs.SetString("jawaban9_1", input_jawaban9_1.text);
        PlayerPrefs.SetString("jawaban9_2", input_jawaban9_2.text);
        PlayerPrefs.SetString("jawaban9_3", input_jawaban9_3.text);
        PlayerPrefs.SetString("jawaban10_1", input_jawaban10_1.text);
        PlayerPrefs.SetString("jawaban10_2", input_jawaban10_2.text);
        PlayerPrefs.SetString("jawaban10_3", input_jawaban10_3.text);
    }
    public void jawaban_benar()
    {
        input_jawaban_benar1.text = PlayerPrefs.GetString("jawaban1");
        input_jawaban_benar2.text = PlayerPrefs.GetString("jawaban2");
        input_jawaban_benar3.text = PlayerPrefs.GetString("jawaban3");
        input_jawaban_benar4.text = PlayerPrefs.GetString("jawaban4");
        input_jawaban_benar5.text = PlayerPrefs.GetString("jawaban5");
        input_jawaban_benar6.text = PlayerPrefs.GetString("jawaban6");
        input_jawaban_benar7.text = PlayerPrefs.GetString("jawaban7");
        input_jawaban_benar8.text = PlayerPrefs.GetString("jawaban8");
        input_jawaban_benar9.text = PlayerPrefs.GetString("jawaban9");
        input_jawaban_benar10.text = PlayerPrefs.GetString("jawaban10");
    }
    public void jawaban_salah()
    {
        input_jawaban1_1.text = PlayerPrefs.GetString("jawaban1_1");
        input_jawaban1_2.text = PlayerPrefs.GetString("jawaban1_2");
        input_jawaban1_3.text = PlayerPrefs.GetString("jawaban1_3");
        input_jawaban2_1.text = PlayerPrefs.GetString("jawaban2_1");
        input_jawaban2_2.text = PlayerPrefs.GetString("jawaban2_2");
        input_jawaban2_3.text = PlayerPrefs.GetString("jawaban2_3");
        input_jawaban3_1.text = PlayerPrefs.GetString("jawaban3_1");
        input_jawaban3_2.text = PlayerPrefs.GetString("jawaban3_2");
        input_jawaban3_3.text = PlayerPrefs.GetString("jawaban3_3");
        input_jawaban4_1.text = PlayerPrefs.GetString("jawaban4_1");
        input_jawaban4_2.text = PlayerPrefs.GetString("jawaban4_2");
        input_jawaban4_3.text = PlayerPrefs.GetString("jawaban4_3");
        input_jawaban5_1.text = PlayerPrefs.GetString("jawaban5_1");
        input_jawaban5_2.text = PlayerPrefs.GetString("jawaban5_2");
        input_jawaban5_3.text = PlayerPrefs.GetString("jawaban5_3");
        input_jawaban6_1.text = PlayerPrefs.GetString("jawaban6_1");
        input_jawaban6_2.text = PlayerPrefs.GetString("jawaban6_2");
        input_jawaban6_3.text = PlayerPrefs.GetString("jawaban6_3");
        input_jawaban7_1.text = PlayerPrefs.GetString("jawaban7_1");
        input_jawaban7_2.text = PlayerPrefs.GetString("jawaban7_2");
        input_jawaban7_3.text = PlayerPrefs.GetString("jawaban7_3");
        input_jawaban8_1.text = PlayerPrefs.GetString("jawaban8_1");
        input_jawaban8_2.text = PlayerPrefs.GetString("jawaban8_2");
        input_jawaban8_3.text = PlayerPrefs.GetString("jawaban8_3");
        input_jawaban9_1.text = PlayerPrefs.GetString("jawaban9_1");
        input_jawaban9_2.text = PlayerPrefs.GetString("jawaban9_2");
        input_jawaban9_3.text = PlayerPrefs.GetString("jawaban9_3");
        input_jawaban10_1.text = PlayerPrefs.GetString("jawaban10_1");
        input_jawaban10_2.text = PlayerPrefs.GetString("jawaban10_2");
        input_jawaban10_3.text = PlayerPrefs.GetString("jawaban10_3");
    }
}

