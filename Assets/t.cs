using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class t : MonoBehaviour
{

    public AudioClip clip;
    
    void Start()
    {
        SoundManager.Instance.PlayBGM(clip);
    }
    
    
}
