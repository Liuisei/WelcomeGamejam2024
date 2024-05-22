using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : BaseSingleton<DataManager>
{

    string _playerName;

    public string PlayerName { get => _playerName; set => _playerName = value; }

    protected override void AwakeFunction() { }



   
    public void SaveName(string playerName)
    {
        PlayerName = playerName;
        Debug.Log(PlayerName);
    }
}