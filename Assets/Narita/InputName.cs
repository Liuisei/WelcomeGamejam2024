using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputName : MonoBehaviour
{
    string _name;
    [SerializeField] InputField _inputField;
    [SerializeField] Text _text;

    public void savename()
    {
        _inputField = _inputField.GetComponent<InputField>();  
        _text = _text.GetComponent<Text>();
       DataManager.Instance.SaveName(_text.text);
    }
}
