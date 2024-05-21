using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
   [SerializeField] float _speed = 1f;
    [SerializeField] float _maxrange;
    private void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A) && this.transform.position.x >= -_maxrange)
        {
                transform.position += transform.right * -_speed;
        }
        if (Input.GetKey(KeyCode.D) && this.transform.position.x <= _maxrange)
        {
            transform.position += transform.right * +_speed;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.tag == "water")
        {
            GetWater();
        }
        if (collision.gameObject.tag == "energy")
        {
            GetEnergy();
        }
    }
    void GetWater()
    {
        Debug.Log("GetWater");
        var playerhealth = GetComponent<PlayerHealth>();
        playerhealth.PlyerHeal();
    }
    void GetEnergy()
    {
        Debug.Log("GetEnergy");
    }

}
