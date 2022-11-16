using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class slider : MonoBehaviour
{
    [SerializeField] Slider vs;
    
    
    // Start is called before the first frame update
    void Start()
    {
        if(!PlayerPrefs.HasKey("vol"))
        {
            PlayerPrefs.SetFloat("vol", 1);
            Load();
        }
        else
        {
            Load();
        }
    }

    public void changeV()
    {
        AudioListener.volume = vs.value;
        Save();
    }

    private void Load()
    {
        vs.value = PlayerPrefs.GetFloat("vol");
    }
    
    private void Save()
    {
        PlayerPrefs.SetFloat("vol", vs.value);
    }
}
