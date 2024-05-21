using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tairyoku : MonoBehaviour
{
    [SerializeField] int HP = 100;
    [SerializeField] int MaxHP = 100;
    [SerializeField] Slider HPSlider;
 

    void Update()
    {
        HPSlider.value = HP / MaxHP;
    }
}
