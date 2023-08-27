using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SoalSettingManager : MonoBehaviour
{
    [SerializeField] private LevelSoalPlayerPrefs level1;
    [SerializeField] private LevelSoalPlayerPrefs level2;
    [SerializeField] private LevelSoalPlayerPrefs level3;

    [SerializeField] private Button saveButton;

    [SerializeField] private Button[] levelsButton;

    [Header("Text Components")]
    [SerializeField] private TMP_InputField Soal1;
    [SerializeField] private TMP_InputField[] Soal1Jawaban;

    [SerializeField] private TMP_InputField Soal2;
    [SerializeField] private TMP_InputField[] Soal2Jawaban;

    [SerializeField] private TMP_InputField Soal3;
    [SerializeField] private TMP_InputField[] Soal3Jawaban;

    [SerializeField] private TMP_InputField Soal4;
    [SerializeField] private TMP_InputField[] Soal4Jawaban;

    [SerializeField] private TMP_InputField Soal5;
    [SerializeField] private TMP_InputField[] Soal5Jawaban;

    [SerializeField] private TMP_InputField Soal6;
    [SerializeField] private TMP_InputField[] Soal6Jawaban;

    [SerializeField] private TMP_InputField Soal7;
    [SerializeField] private TMP_InputField[] Soal7Jawaban;

    [SerializeField] private TMP_InputField Soal8;
    [SerializeField] private TMP_InputField[] Soal8Jawaban;

    [SerializeField] private TMP_InputField Soal9;
    [SerializeField] private TMP_InputField[] Soal9Jawaban;

    [SerializeField] private TMP_InputField Soal10;
    [SerializeField] private TMP_InputField[] Soal10Jawaban;

    [SerializeField] private TMP_InputField[] allInputField;
    [SerializeField] private GameObject altertText;
    private int currentLevel;

    private void Start()
    {
        currentLevel = 0;
        LevelsButtonSelection(currentLevel);
        saveButton.interactable = false;
    }

    private void Update()
    {
        CheckInputFields();
    }

    public void LevelsButtonSelection(int index)
    {
        for (int i = 0; i < levelsButton.Length; i++)
        {
            levelsButton[i].interactable = true;
        }

        levelsButton[index].interactable = false;
        currentLevel = index;

        if(index == 0)
        {
            Soal1.text = PlayerPrefs.GetString(level1.Soal1);
            for (int i = 0; i < Soal1Jawaban.Length; i++)
            {
                Soal1Jawaban[i].text = PlayerPrefs.GetString(level1.Soal1Jawaban[i]);
            }

            Soal2.text = PlayerPrefs.GetString(level1.Soal2);
            for (int i = 0; i < Soal2Jawaban.Length; i++)
            {
                Soal2Jawaban[i].text = PlayerPrefs.GetString(level1.Soal2Jawaban[i]);
            }

            Soal3.text = PlayerPrefs.GetString(level1.Soal3);
            for (int i = 0; i < Soal3Jawaban.Length; i++)
            {
                Soal3Jawaban[i].text = PlayerPrefs.GetString(level1.Soal3Jawaban[i]);
            }

            Soal4.text = PlayerPrefs.GetString(level1.Soal4);
            for (int i = 0; i < Soal4Jawaban.Length; i++)
            {
                Soal4Jawaban[i].text = PlayerPrefs.GetString(level1.Soal4Jawaban[i]);
            }

            Soal5.text = PlayerPrefs.GetString(level1.Soal5);
            for (int i = 0; i < Soal5Jawaban.Length; i++)
            {
                Soal5Jawaban[i].text = PlayerPrefs.GetString(level1.Soal5Jawaban[i]);
            }

            Soal6.text = PlayerPrefs.GetString(level1.Soal6);
            for (int i = 0; i < Soal6Jawaban.Length; i++)
            {
                Soal6Jawaban[i].text = PlayerPrefs.GetString(level1.Soal6Jawaban[i]);
            }

            Soal7.text = PlayerPrefs.GetString(level1.Soal7);
            for (int i = 0; i < Soal7Jawaban.Length; i++)
            {
                Soal7Jawaban[i].text = PlayerPrefs.GetString(level1.Soal7Jawaban[i]);
            }

            Soal8.text = PlayerPrefs.GetString(level1.Soal8);
            for (int i = 0; i < Soal8Jawaban.Length; i++)
            {
                Soal8Jawaban[i].text = PlayerPrefs.GetString(level1.Soal8Jawaban[i]);
            }

            Soal9.text = PlayerPrefs.GetString(level1.Soal9);
            for (int i = 0; i < Soal9Jawaban.Length; i++)
            {
                Soal9Jawaban[i].text = PlayerPrefs.GetString(level1.Soal9Jawaban[i]);
            }

            Soal10.text = PlayerPrefs.GetString(level1.Soal10);
            for (int i = 0; i < Soal10Jawaban.Length; i++)
            {
                Soal10Jawaban[i].text = PlayerPrefs.GetString(level1.Soal10Jawaban[i]);
            }
        }
        else if(index == 1)
        {
            Soal1.text = PlayerPrefs.GetString(level2.Soal1);
            for (int i = 0; i < Soal1Jawaban.Length; i++)
            {
                Soal1Jawaban[i].text = PlayerPrefs.GetString(level2.Soal1Jawaban[i]);
            }

            Soal2.text = PlayerPrefs.GetString(level2.Soal2);
            for (int i = 0; i < Soal2Jawaban.Length; i++)
            {
                Soal2Jawaban[i].text = PlayerPrefs.GetString(level2.Soal2Jawaban[i]);
            }

            Soal3.text = PlayerPrefs.GetString(level2.Soal3);
            for (int i = 0; i < Soal3Jawaban.Length; i++)
            {
                Soal3Jawaban[i].text = PlayerPrefs.GetString(level2.Soal3Jawaban[i]);
            }

            Soal4.text = PlayerPrefs.GetString(level2.Soal4);
            for (int i = 0; i < Soal4Jawaban.Length; i++)
            {
                Soal4Jawaban[i].text = PlayerPrefs.GetString(level2.Soal4Jawaban[i]);
            }

            Soal5.text = PlayerPrefs.GetString(level2.Soal5);
            for (int i = 0; i < Soal5Jawaban.Length; i++)
            {
                Soal5Jawaban[i].text = PlayerPrefs.GetString(level2.Soal5Jawaban[i]);
            }

            Soal6.text = PlayerPrefs.GetString(level2.Soal6);
            for (int i = 0; i < Soal6Jawaban.Length; i++)
            {
                Soal6Jawaban[i].text = PlayerPrefs.GetString(level2.Soal6Jawaban[i]);
            }

            Soal7.text = PlayerPrefs.GetString(level2.Soal7);
            for (int i = 0; i < Soal7Jawaban.Length; i++)
            {
                Soal7Jawaban[i].text = PlayerPrefs.GetString(level2.Soal7Jawaban[i]);
            }

            Soal8.text = PlayerPrefs.GetString(level2.Soal8);
            for (int i = 0; i < Soal8Jawaban.Length; i++)
            {
                Soal8Jawaban[i].text = PlayerPrefs.GetString(level2.Soal8Jawaban[i]);
            }

            Soal9.text = PlayerPrefs.GetString(level2.Soal9);
            for (int i = 0; i < Soal9Jawaban.Length; i++)
            {
                Soal9Jawaban[i].text = PlayerPrefs.GetString(level2.Soal9Jawaban[i]);
            }

            Soal10.text = PlayerPrefs.GetString(level2.Soal10);
            for (int i = 0; i < Soal10Jawaban.Length; i++)
            {
                Soal10Jawaban[i].text = PlayerPrefs.GetString(level2.Soal10Jawaban[i]);
            }
        }
        else if(index == 2)
        {
            Soal1.text = PlayerPrefs.GetString(level3.Soal1);
            for (int i = 0; i < Soal1Jawaban.Length; i++)
            {
                Soal1Jawaban[i].text = PlayerPrefs.GetString(level3.Soal1Jawaban[i]);
            }

            Soal2.text = PlayerPrefs.GetString(level3.Soal2);
            for (int i = 0; i < Soal2Jawaban.Length; i++)
            {
                Soal2Jawaban[i].text = PlayerPrefs.GetString(level3.Soal2Jawaban[i]);
            }

            Soal3.text = PlayerPrefs.GetString(level3.Soal3);
            for (int i = 0; i < Soal3Jawaban.Length; i++)
            {
                Soal3Jawaban[i].text = PlayerPrefs.GetString(level3.Soal3Jawaban[i]);
            }

            Soal4.text = PlayerPrefs.GetString(level3.Soal4);
            for (int i = 0; i < Soal4Jawaban.Length; i++)
            {
                Soal4Jawaban[i].text = PlayerPrefs.GetString(level3.Soal4Jawaban[i]);
            }

            Soal5.text = PlayerPrefs.GetString(level3.Soal5);
            for (int i = 0; i < Soal5Jawaban.Length; i++)
            {
                Soal5Jawaban[i].text = PlayerPrefs.GetString(level3.Soal5Jawaban[i]);
            }

            Soal6.text = PlayerPrefs.GetString(level3.Soal6);
            for (int i = 0; i < Soal6Jawaban.Length; i++)
            {
                Soal6Jawaban[i].text = PlayerPrefs.GetString(level3.Soal6Jawaban[i]);
            }

            Soal7.text = PlayerPrefs.GetString(level3.Soal7);
            for (int i = 0; i < Soal7Jawaban.Length; i++)
            {
                Soal7Jawaban[i].text = PlayerPrefs.GetString(level3.Soal7Jawaban[i]);
            }

            Soal8.text = PlayerPrefs.GetString(level3.Soal8);
            for (int i = 0; i < Soal8Jawaban.Length; i++)
            {
                Soal8Jawaban[i].text = PlayerPrefs.GetString(level3.Soal8Jawaban[i]);
            }

            Soal9.text = PlayerPrefs.GetString(level3.Soal9);
            for (int i = 0; i < Soal9Jawaban.Length; i++)
            {
                Soal9Jawaban[i].text = PlayerPrefs.GetString(level3.Soal9Jawaban[i]);
            }

            Soal10.text = PlayerPrefs.GetString(level3.Soal10);
            for (int i = 0; i < Soal10Jawaban.Length; i++)
            {
                Soal10Jawaban[i].text = PlayerPrefs.GetString(level3.Soal10Jawaban[i]);
            }
        }
    }

    public void OnSoalValueChanged()
    {
        saveButton.interactable = true;
    }

    public void SaveButton()
    {
        saveButton.interactable = false;

        if(currentLevel == 0)
        {
            PlayerPrefs.SetString(level1.Soal1, Soal1.text);
            for (int i = 0; i < level1.Soal1Jawaban.Length; i++)
            {
                PlayerPrefs.SetString(level1.Soal1Jawaban[i], Soal1Jawaban[i].text);
            }

            PlayerPrefs.SetString(level1.Soal2, Soal2.text);
            for (int i = 0; i < level1.Soal2Jawaban.Length; i++)
            {
                PlayerPrefs.SetString(level1.Soal2Jawaban[i], Soal2Jawaban[i].text);
            }

            PlayerPrefs.SetString(level1.Soal3, Soal3.text);
            for (int i = 0; i < level1.Soal3Jawaban.Length; i++)
            {
                PlayerPrefs.SetString(level1.Soal3Jawaban[i], Soal3Jawaban[i].text);
            }

            PlayerPrefs.SetString(level1.Soal4, Soal4.text);
            for (int i = 0; i < level1.Soal4Jawaban.Length; i++)
            {
                PlayerPrefs.SetString(level1.Soal4Jawaban[i], Soal4Jawaban[i].text);
            }

            PlayerPrefs.SetString(level1.Soal5, Soal5.text);
            for (int i = 0; i < level1.Soal5Jawaban.Length; i++)
            {
                PlayerPrefs.SetString(level1.Soal5Jawaban[i], Soal5Jawaban[i].text);
            }

            PlayerPrefs.SetString(level1.Soal6, Soal6.text);
            for (int i = 0; i < level1.Soal6Jawaban.Length; i++)
            {
                PlayerPrefs.SetString(level1.Soal6Jawaban[i], Soal6Jawaban[i].text);
            }

            PlayerPrefs.SetString(level1.Soal7, Soal7.text);
            for (int i = 0; i < level1.Soal7Jawaban.Length; i++)
            {
                PlayerPrefs.SetString(level1.Soal7Jawaban[i], Soal7Jawaban[i].text);
            }

            PlayerPrefs.SetString(level1.Soal8, Soal8.text);
            for (int i = 0; i < level1.Soal8Jawaban.Length; i++)
            {
                PlayerPrefs.SetString(level1.Soal8Jawaban[i], Soal8Jawaban[i].text);
            }

            PlayerPrefs.SetString(level1.Soal9, Soal9.text);
            for (int i = 0; i < level1.Soal9Jawaban.Length; i++)
            {
                PlayerPrefs.SetString(level1.Soal9Jawaban[i], Soal9Jawaban[i].text);
            }

            PlayerPrefs.SetString(level1.Soal10, Soal10.text);
            for (int i = 0; i < level1.Soal10Jawaban.Length; i++)
            {
                PlayerPrefs.SetString(level1.Soal10Jawaban[i], Soal10Jawaban[i].text);
            }
        }
        else if(currentLevel == 1)
        {
            PlayerPrefs.SetString(level2.Soal1, Soal1.text);
            for (int i = 0; i < level2.Soal1Jawaban.Length; i++)
            {
                PlayerPrefs.SetString(level2.Soal1Jawaban[i], Soal1Jawaban[i].text);
            }

            PlayerPrefs.SetString(level2.Soal2, Soal2.text);
            for (int i = 0; i < level2.Soal2Jawaban.Length; i++)
            {
                PlayerPrefs.SetString(level2.Soal2Jawaban[i], Soal2Jawaban[i].text);
            }

            PlayerPrefs.SetString(level2.Soal3, Soal3.text);
            for (int i = 0; i < level2.Soal3Jawaban.Length; i++)
            {
                PlayerPrefs.SetString(level2.Soal3Jawaban[i], Soal3Jawaban[i].text);
            }

            PlayerPrefs.SetString(level2.Soal4, Soal4.text);
            for (int i = 0; i < level2.Soal4Jawaban.Length; i++)
            {
                PlayerPrefs.SetString(level2.Soal4Jawaban[i], Soal4Jawaban[i].text);
            }

            PlayerPrefs.SetString(level2.Soal5, Soal5.text);
            for (int i = 0; i < level2.Soal5Jawaban.Length; i++)
            {
                PlayerPrefs.SetString(level2.Soal5Jawaban[i], Soal5Jawaban[i].text);
            }

            PlayerPrefs.SetString(level2.Soal6, Soal6.text);
            for (int i = 0; i < level2.Soal6Jawaban.Length; i++)
            {
                PlayerPrefs.SetString(level2.Soal6Jawaban[i], Soal6Jawaban[i].text);
            }

            PlayerPrefs.SetString(level2.Soal7, Soal7.text);
            for (int i = 0; i < level2.Soal7Jawaban.Length; i++)
            {
                PlayerPrefs.SetString(level2.Soal7Jawaban[i], Soal7Jawaban[i].text);
            }

            PlayerPrefs.SetString(level2.Soal8, Soal8.text);
            for (int i = 0; i < level2.Soal8Jawaban.Length; i++)
            {
                PlayerPrefs.SetString(level2.Soal8Jawaban[i], Soal8Jawaban[i].text);
            }

            PlayerPrefs.SetString(level2.Soal9, Soal9.text);
            for (int i = 0; i < level2.Soal9Jawaban.Length; i++)
            {
                PlayerPrefs.SetString(level2.Soal9Jawaban[i], Soal9Jawaban[i].text);
            }

            PlayerPrefs.SetString(level2.Soal10, Soal10.text);
            for (int i = 0; i < level2.Soal10Jawaban.Length; i++)
            {
                PlayerPrefs.SetString(level2.Soal10Jawaban[i], Soal10Jawaban[i].text);
            }
        }
        else if(currentLevel == 2)
        {
            PlayerPrefs.SetString(level3.Soal1, Soal1.text);
            for (int i = 0; i < level3.Soal1Jawaban.Length; i++)
            {
                PlayerPrefs.SetString(level3.Soal1Jawaban[i], Soal1Jawaban[i].text);
            }

            PlayerPrefs.SetString(level3.Soal2, Soal2.text);
            for (int i = 0; i < level3.Soal2Jawaban.Length; i++)
            {
                PlayerPrefs.SetString(level3.Soal2Jawaban[i], Soal2Jawaban[i].text);
            }

            PlayerPrefs.SetString(level3.Soal3, Soal3.text);
            for (int i = 0; i < level3.Soal3Jawaban.Length; i++)
            {
                PlayerPrefs.SetString(level3.Soal3Jawaban[i], Soal3Jawaban[i].text);
            }

            PlayerPrefs.SetString(level3.Soal4, Soal4.text);
            for (int i = 0; i < level3.Soal4Jawaban.Length; i++)
            {
                PlayerPrefs.SetString(level3.Soal4Jawaban[i], Soal4Jawaban[i].text);
            }

            PlayerPrefs.SetString(level3.Soal5, Soal5.text);
            for (int i = 0; i < level3.Soal5Jawaban.Length; i++)
            {
                PlayerPrefs.SetString(level3.Soal5Jawaban[i], Soal5Jawaban[i].text);
            }

            PlayerPrefs.SetString(level3.Soal6, Soal6.text);
            for (int i = 0; i < level3.Soal6Jawaban.Length; i++)
            {
                PlayerPrefs.SetString(level3.Soal6Jawaban[i], Soal6Jawaban[i].text);
            }

            PlayerPrefs.SetString(level3.Soal7, Soal7.text);
            for (int i = 0; i < level3.Soal7Jawaban.Length; i++)
            {
                PlayerPrefs.SetString(level3.Soal7Jawaban[i], Soal7Jawaban[i].text);
            }

            PlayerPrefs.SetString(level3.Soal8, Soal8.text);
            for (int i = 0; i < level3.Soal8Jawaban.Length; i++)
            {
                PlayerPrefs.SetString(level3.Soal8Jawaban[i], Soal8Jawaban[i].text);
            }

            PlayerPrefs.SetString(level3.Soal9, Soal9.text);
            for (int i = 0; i < level3.Soal9Jawaban.Length; i++)
            {
                PlayerPrefs.SetString(level3.Soal9Jawaban[i], Soal9Jawaban[i].text);
            }

            PlayerPrefs.SetString(level3.Soal10, Soal10.text);
            for (int i = 0; i < level3.Soal10Jawaban.Length; i++)
            {
                PlayerPrefs.SetString(level3.Soal10Jawaban[i], Soal10Jawaban[i].text);
            }
        }
    }

    private void CheckInputFields()
    {
        bool atLeastOneEmpty = false;

        foreach (TMP_InputField inputField in allInputField)
        {
            if (inputField.text == "")
            {
                atLeastOneEmpty = true;
                break;
            }
        }

        if (atLeastOneEmpty)
        {
            altertText.SetActive(true);

            if(currentLevel == 0)
            {
                PlayerPrefs.SetInt(level1.IsAllSoalFilled, 1);
                Debug.Log("level 1 unfull");
            }
            else if(currentLevel == 1)
            {
                PlayerPrefs.SetInt(level2.IsAllSoalFilled, 1);
                Debug.Log("level 2 unfull");
            }
            else if (currentLevel == 2)
            {
                PlayerPrefs.SetInt(level3.IsAllSoalFilled, 1);
                Debug.Log("level 3 unfull");
            }
        }
        else
        {
            altertText.SetActive(false);

            if (currentLevel == 0)
            {
                PlayerPrefs.SetInt(level1.IsAllSoalFilled, 0);
                Debug.Log("level 1 full");
            }
            else if (currentLevel == 1)
            {
                PlayerPrefs.SetInt(level2.IsAllSoalFilled, 0);
                Debug.Log("level 2 full");
            }
            else if (currentLevel == 2)
            {
                PlayerPrefs.SetInt(level3.IsAllSoalFilled, 0);
                Debug.Log("level 3 full");
            }
        }
    }
}
