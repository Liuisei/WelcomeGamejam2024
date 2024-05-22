using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedMeter : MonoBehaviour
{
    [SerializeField] Text _speedText;
    void Update()
    {
        _speedText.text = GameManager.Instance.Speed.ToString();    
    }
   
}
