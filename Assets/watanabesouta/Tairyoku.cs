using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class Tairyoku : MonoBehaviour
{
    [Range(0, 100)] [SerializeField] int    HP    = 100;
    [SerializeField]                 int    MaxHP = 100;
    [SerializeField]                 Slider HPSlider;


    void Start()
    {
        MaxHP = GameManager.Instance.MaxSpeed;
    }

    void Update()
    {
        HP = GameManager.Instance.Speed;
        HPSlider.value = (float)HP / (float)MaxHP; 
    }
}