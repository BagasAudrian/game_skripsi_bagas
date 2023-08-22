using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class save_soal : MonoBehaviour
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

    // Start is called before the first frame update
    void Start()
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


    // Update is called once per frame
    void Update()
    {
        
    }
}
