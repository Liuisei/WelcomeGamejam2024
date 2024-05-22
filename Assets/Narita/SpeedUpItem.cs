using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SpeedUpItem : MonoBehaviour
{
    [SerializeField] int _plusSpeed;
    // Start is called before the first frame update
    //
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent<PlayerMove>(out var player))
        {
         
            Debug.Log("エナドリor水をゲット");
            GameManager.Instance.AddSpeed(_plusSpeed);
            Destroy(gameObject);   
        }
    }
    
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
