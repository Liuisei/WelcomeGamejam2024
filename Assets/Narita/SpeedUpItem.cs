using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUpItem : MonoBehaviour
{
    [SerializeField] float _plusSpeed;
    // Start is called before the first frame update
    //
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("エナドリor水をゲット");
        GameManager.Instance.SetSpeed(_plusSpeed);
    }
  
}
