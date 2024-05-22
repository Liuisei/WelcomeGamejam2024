using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputName : MonoBehaviour
{
    string _name;
    [SerializeField] Text _inputText;
    public void savename()
    {
        _name = _inputText.text;
        Debug.Log(_name);
    }
}
