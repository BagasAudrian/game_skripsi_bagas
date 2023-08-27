using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScened : MonoBehaviour
{
    public void SceneToLoad(int index)
    {
        SceneManager.LoadScene(index);
    }
}
