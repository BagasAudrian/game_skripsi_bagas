using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;
    [SerializeField] public AudioSource[] Audio_Source;

    public Button[] audioButton;
    private bool isOnAudio;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        SetUnmuteAudio();
    }

    public void PlayAudio(string name)
    {
        for (int i = 0; i < Audio_Source.Length; i++)
        {
            if (Audio_Source[i].name == name)
            {
                Audio_Source[i].GetComponent<AudioSource>().Play();
            }
        }
    }

    public void StopAudio(string name)
    {
        for (int i = 0; i < Audio_Source.Length; i++)
        {
            if (Audio_Source[i].name == name)
            {
                Audio_Source[i].GetComponent<AudioSource>().Stop();
            }
        }
    }

    public void SetMuteAudio()
    {
        for (int i = 0; i < Audio_Source.Length; i++)
        {
            Audio_Source[i].volume = 0;
            PlayerPrefs.SetFloat("AudioSetting", Audio_Source[i].volume);
            audioButton[0].interactable = true;
            audioButton[1].interactable = false;
        }
    }

    public void SetUnmuteAudio()
    {
        for (int i = 0; i < Audio_Source.Length; i++)
        {
            Audio_Source[i].volume = 1;
            PlayerPrefs.SetFloat("AudioSetting", Audio_Source[i].volume);
            audioButton[0].interactable = false;
            audioButton[1].interactable = true;
        }
    }
}
