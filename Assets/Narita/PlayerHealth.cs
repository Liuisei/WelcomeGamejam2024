using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] Text _healthText;
    [SerializeField] float _addHealth;
    [SerializeField] float _maxHp;
    float hp = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _healthText.text = hp.ToString();
        if (hp > _maxHp)
        {
            hp = _maxHp;
        }
    }
    public void PlyerHeal()
    {
        hp += _addHealth;
    }
}
