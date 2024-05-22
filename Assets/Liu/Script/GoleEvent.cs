using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoleEvent : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent<PlayerMove>(out var player))
        {
            Debug.Log("Gole");
            GameManager.Instance.Gole();
        }
    }
}
