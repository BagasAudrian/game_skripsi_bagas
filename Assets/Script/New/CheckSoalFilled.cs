using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CheckSoalFilled : MonoBehaviour
{
    [SerializeField] private LevelSoalPlayerPrefs level1;
    [SerializeField] private LevelSoalPlayerPrefs level2;
    [SerializeField] private LevelSoalPlayerPrefs level3;

    public Button[] buttonsLevel;

    void Update()
    {
        Check(0, level1.IsAllSoalFilled);
        Check(1, level2.IsAllSoalFilled);
        Check(2, level3.IsAllSoalFilled);

        Debug.Log("2 = "+ PlayerPrefs.GetInt(level2.IsAllSoalFilled));
        Debug.Log("1 = " + PlayerPrefs.GetInt(level1.IsAllSoalFilled));
    }

    private void Check(int index, string value)
    {
        if(PlayerPrefs.GetInt(value) == 0)
        {
            buttonsLevel[index].interactable = true;
        }
        else if (PlayerPrefs.GetInt(value) == 1)
        {
            buttonsLevel[index].interactable = false;
        }
    }

    public void LoadScened(int index)
    {
        SceneManager.LoadScene(index);
    }
}
