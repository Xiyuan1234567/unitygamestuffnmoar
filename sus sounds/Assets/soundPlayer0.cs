using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class soundPlayer0 : MonoBehaviour
{
    
    [SerializeField] GameObject exitConf;
    
    public float Volume;
    public AudioClip soundToPlay;
    AudioSource audio0;
    public bool muted = false;
    
    
    public void PlaySound()
    {
        audio0 = GetComponent<AudioSource>();
        audio0.PlayOneShot(soundToPlay, Volume); 
    }

    public void clickQuit()
    {
        exitConf.SetActive(true);
    }

    public void userChoice(int choice) //1 is yes
    {
        if(choice == 1)
        {
            Application.Quit();
        }
        exitConf.SetActive(false);
    }

    public void mute()
    {
        if(muted)
        {
            AudioListener.volume = 1;
            muted = false;
        }
        else
        {
            AudioListener.volume = 0;
            muted = true;
        }    
    }

    
}
