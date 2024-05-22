using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : BaseSingleton<DataManager>
{

    string _playerName;

    public string PlayerName { get => _playerName; set => _playerName = value; }

    protected override void AwakeFunction() { }


    float        time ;
    public float Time { get { return time; } set { time = value; } }

   
    public void SaveName(string playerName)
    {
        PlayerName = playerName;
        Debug.Log(PlayerName);
    }
}
