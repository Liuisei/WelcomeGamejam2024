using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class Clarsss : MonoBehaviour
{
    [SerializeField] Text _textnameText;
    [SerializeField]            Text _timenameText;
    // Start is called before the first frame update
    void Start()
    {
        _timenameText.text = DataManager.Instance.PlayerName;
        _textnameText.text = DataManager.Instance.Time.ToString("000.00");
        
        GameData.Instance.AddRanking(DataManager.Instance.Time,DataManager.Instance.PlayerName );

    }

}
