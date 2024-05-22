using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Flag : MonoBehaviour
{
    GameManager                                    _gM;

    void Start()
    {
        _gM = GameManager.Instance;
    }

    void FixedUpdate()
    {
        transform.position += new Vector3(0, _gM.Speed / -1000f);   
    }
    
}
